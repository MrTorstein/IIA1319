namespace DAQ_Simulation_Application
{
    partial class main_window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_window));
            tab_control = new TabControl();
            logging_page = new TabPage();
            logging_filename_label = new Label();
            logging_filename_textbox = new TextBox();
            log_once_button = new Button();
            sample_once_button = new Button();
            sensor_value_label = new Label();
            next_logging_time_label = new Label();
            next_sampling_time_label = new Label();
            logging_button = new Button();
            sensor_value_textbox = new TextBox();
            next_logging_time_textbox = new TextBox();
            next_sampling_time_textbox = new TextBox();
            sample_button = new Button();
            sampling_timer = new System.Windows.Forms.Timer(components);
            logging_timer = new System.Windows.Forms.Timer(components);
            tab_control.SuspendLayout();
            logging_page.SuspendLayout();
            SuspendLayout();
            // 
            // tab_control
            // 
            tab_control.Controls.Add(logging_page);
            tab_control.Location = new Point(-2, -2);
            tab_control.Name = "tab_control";
            tab_control.SelectedIndex = 0;
            tab_control.Size = new Size(802, 454);
            tab_control.TabIndex = 0;
            // 
            // logging_page
            // 
            logging_page.Controls.Add(logging_filename_label);
            logging_page.Controls.Add(logging_filename_textbox);
            logging_page.Controls.Add(log_once_button);
            logging_page.Controls.Add(sample_once_button);
            logging_page.Controls.Add(sensor_value_label);
            logging_page.Controls.Add(next_logging_time_label);
            logging_page.Controls.Add(next_sampling_time_label);
            logging_page.Controls.Add(logging_button);
            logging_page.Controls.Add(sensor_value_textbox);
            logging_page.Controls.Add(next_logging_time_textbox);
            logging_page.Controls.Add(next_sampling_time_textbox);
            logging_page.Controls.Add(sample_button);
            logging_page.Location = new Point(4, 24);
            logging_page.Name = "logging_page";
            logging_page.Padding = new Padding(3);
            logging_page.Size = new Size(794, 426);
            logging_page.TabIndex = 0;
            logging_page.Text = "Logging";
            logging_page.UseVisualStyleBackColor = true;
            // 
            // logging_filename_label
            // 
            logging_filename_label.AutoSize = true;
            logging_filename_label.Location = new Point(29, 265);
            logging_filename_label.Name = "logging_filename_label";
            logging_filename_label.Size = new Size(102, 15);
            logging_filename_label.TabIndex = 11;
            logging_filename_label.Text = "Logging Filename";
            // 
            // logging_filename_textbox
            // 
            logging_filename_textbox.Location = new Point(29, 283);
            logging_filename_textbox.Name = "logging_filename_textbox";
            logging_filename_textbox.Size = new Size(311, 23);
            logging_filename_textbox.TabIndex = 10;
            // 
            // log_once_button
            // 
            log_once_button.Location = new Point(29, 173);
            log_once_button.Name = "log_once_button";
            log_once_button.Size = new Size(94, 23);
            log_once_button.TabIndex = 9;
            log_once_button.Text = "Log Once";
            log_once_button.UseVisualStyleBackColor = true;
            log_once_button.Click += LogOnceButtonClick;
            // 
            // sample_once_button
            // 
            sample_once_button.Location = new Point(29, 79);
            sample_once_button.Name = "sample_once_button";
            sample_once_button.Size = new Size(94, 23);
            sample_once_button.TabIndex = 8;
            sample_once_button.Text = "Sample Once";
            sample_once_button.UseVisualStyleBackColor = true;
            sample_once_button.Click += SampleOnceButtonClick;
            // 
            // sensor_value_label
            // 
            sensor_value_label.AutoSize = true;
            sensor_value_label.Location = new Point(394, 32);
            sensor_value_label.Name = "sensor_value_label";
            sensor_value_label.Size = new Size(78, 15);
            sensor_value_label.TabIndex = 7;
            sensor_value_label.Text = "Sensor Values";
            // 
            // next_logging_time_label
            // 
            next_logging_time_label.AutoSize = true;
            next_logging_time_label.Location = new Point(168, 144);
            next_logging_time_label.Name = "next_logging_time_label";
            next_logging_time_label.Size = new Size(108, 15);
            next_logging_time_label.TabIndex = 6;
            next_logging_time_label.Text = "Next Logging Time";
            // 
            // next_sampling_time_label
            // 
            next_sampling_time_label.AutoSize = true;
            next_sampling_time_label.Location = new Point(168, 50);
            next_sampling_time_label.Name = "next_sampling_time_label";
            next_sampling_time_label.Size = new Size(114, 15);
            next_sampling_time_label.TabIndex = 5;
            next_sampling_time_label.Text = "Next Sampling Time";
            // 
            // logging_button
            // 
            logging_button.Location = new Point(29, 144);
            logging_button.Name = "logging_button";
            logging_button.Size = new Size(94, 23);
            logging_button.TabIndex = 4;
            logging_button.Text = "Start Logging";
            logging_button.UseVisualStyleBackColor = true;
            logging_button.Click += LoggingButtonClick;
            // 
            // sensor_value_textbox
            // 
            sensor_value_textbox.Location = new Point(394, 50);
            sensor_value_textbox.Multiline = true;
            sensor_value_textbox.Name = "sensor_value_textbox";
            sensor_value_textbox.ReadOnly = true;
            sensor_value_textbox.Size = new Size(394, 370);
            sensor_value_textbox.TabIndex = 3;
            // 
            // next_logging_time_textbox
            // 
            next_logging_time_textbox.Location = new Point(168, 162);
            next_logging_time_textbox.Name = "next_logging_time_textbox";
            next_logging_time_textbox.ReadOnly = true;
            next_logging_time_textbox.Size = new Size(172, 23);
            next_logging_time_textbox.TabIndex = 2;
            // 
            // next_sampling_time_textbox
            // 
            next_sampling_time_textbox.Location = new Point(168, 68);
            next_sampling_time_textbox.Name = "next_sampling_time_textbox";
            next_sampling_time_textbox.ReadOnly = true;
            next_sampling_time_textbox.Size = new Size(172, 23);
            next_sampling_time_textbox.TabIndex = 1;
            // 
            // sample_button
            // 
            sample_button.Location = new Point(29, 50);
            sample_button.Name = "sample_button";
            sample_button.Size = new Size(94, 23);
            sample_button.TabIndex = 0;
            sample_button.Text = "Start Sampling";
            sample_button.UseVisualStyleBackColor = true;
            sample_button.Click += SampleButtonClick;
            // 
            // sampling_timer
            // 
            sampling_timer.Tick += SamplingTimerTick;
            // 
            // logging_timer
            // 
            logging_timer.Tick += LoggingTimerTick;
            // 
            // main_window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tab_control);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "main_window";
            Text = "DAQ Simulator";
            tab_control.ResumeLayout(false);
            logging_page.ResumeLayout(false);
            logging_page.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab_control;
        private TabPage logging_page;
        private TextBox next_sampling_time_textbox;
        private Button sample_button;
        private Button logging_button;
        private TextBox next_logging_time_textbox;
        private Label next_logging_time_label;
        private Label next_sampling_time_label;
        private Label sensor_value_label;
        private TextBox sensor_value_textbox;
        private Button log_once_button;
        private Button sample_once_button;
        private System.Windows.Forms.Timer sampling_timer;
        private System.Windows.Forms.Timer logging_timer;
        private Label logging_filename_label;
        private TextBox logging_filename_textbox;
    }
}
