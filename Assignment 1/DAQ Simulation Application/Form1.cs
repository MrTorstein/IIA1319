using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Globalization;
using static System.Windows.Forms.LinkLabel;
using SensorApp;

namespace DAQ_Simulation_Application
{
    public partial class main_window : Form
    {
        readonly int sampling_time = 3400;
        readonly int logging_time = 47000;
        readonly TimeSpan min_sample_time = new(0, 0, 0, 3, 400);
        readonly TimeSpan min_log_time = new(0, 0, 0, 47, 0);

        readonly List<Sensor> sensors = [];
        readonly List<Sensordata> samples = [];

        Boolean sampling_status = false;
        Boolean logging_status = false;


        public main_window()
        {
            InitializeComponent();

            for (int i = 0; i < 6; i++)
            {
                sensors.Add(new Sensor(i));
            }

            sampling_timer.Interval = sampling_time;
            logging_timer.Interval = logging_time;
        }

        private void TakeSample()
        {
            sensor_value_textbox.Text += DateTime.Now.ToString() + ": ";
            samples.Add(new Sensordata());
            for (int i = 0; i < sensors.Count; i++)
            {
                samples[^1][i] = sensors[i].GetNewValue();
                sensor_value_textbox.Text += samples[^1][i].ToString() + Environment.NewLine;
            }
            next_sampling_time_textbox.Text = DateTime.Now.Add(min_sample_time).ToString();
        }

        private void LogSamples()
        {
            string path = "../../../data/";
            string filename;


            if (logging_filename_textbox.Text == "")
            {
                filename = DateTime.Now.ToString().Replace("/", "_").Replace(" ", "_").Replace(":", "_") + ".csv";
            }
            else if (logging_filename_textbox.Text.ToLower().Contains(".csv", StringComparison.CurrentCulture))
            {
                filename = logging_filename_textbox.Text;
            }
            else
            {
                filename = logging_filename_textbox.Text + ".csv";
            }

            FileInfo outfile_info = new(path + filename);
            Boolean appending = false;
            if (outfile_info.Exists)
            {
                if (outfile_info.Length != 0)
                {
                    appending = true;
                }
            }

            using (StreamWriter outfile = new(Path.Combine(path, filename), appending))
            {
                foreach (Sensordata sample in samples)
                    outfile.WriteLine("{0},{1},{2},{3},{4},{5}", sample[0], sample[1], sample[2], sample[3], sample[4], sample[5]);
            }

            samples.Clear();
            sensor_value_textbox.Text = "";
            next_logging_time_textbox.Text = DateTime.Now.Add(min_log_time).ToString();
        }

        private void SampleButtonClick(object sender, EventArgs e)
        {
            if (!sampling_status)
            {
                sampling_status = true;
                sample_button.Text = "Stop Sampling";
                sample_once_button.Enabled = false;

                if (!sampling_timer.Enabled)
                {
                    if (samples.Count == 0)
                    {
                        sensor_value_textbox.Text = "";
                    }
                    TakeSample();
                    sampling_timer.Start();
                }
            }
            else
            {
                sampling_status = false;
                sample_button.Text = "Start Sampling";
            }
        }

        private void LoggingButtonClick(object sender, EventArgs e)
        {
            if (!logging_status)
            {
                logging_status = true;
                logging_button.Text = "Stop Logging";
                log_once_button.Enabled = false;

                if (!logging_timer.Enabled)
                {
                    LogSamples();
                    logging_timer.Start();
                }
            }
            else
            {
                logging_status = false;
                logging_button.Text = "Start Logging";
            }
        }

        private void SampleOnceButtonClick(object sender, EventArgs e)
        {
            TakeSample();
            sampling_timer.Start();
            sample_once_button.Enabled = false;
        }

        private void LogOnceButtonClick(object sender, EventArgs e)
        {
            LogSamples();
            logging_timer.Start();
            log_once_button.Enabled = false;
        }

        private void SamplingTimerTick(object sender, EventArgs e)
        {
            if (sampling_status)
            {
                TakeSample();
            }
            else
            {
                sampling_timer.Stop();
                sample_once_button.Enabled = true;
            }
        }

        private void LoggingTimerTick(object sender, EventArgs e)
        {
            if (logging_status)
            {
                LogSamples();
            }
            else
            {
                logging_timer.Stop();
                log_once_button.Enabled = true;
            }
        }
    }
}