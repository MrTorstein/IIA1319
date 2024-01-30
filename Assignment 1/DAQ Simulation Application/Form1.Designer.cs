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
            sampling_timer = new System.Windows.Forms.Timer(components);
            logging_timer = new System.Windows.Forms.Timer(components);
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
            menuStrip1 = new MenuStrip();
            loggingToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sampling_timer
            // 
            sampling_timer.Tick += SamplingTimerTick;
            // 
            // logging_timer
            // 
            logging_timer.Tick += LoggingTimerTick;
            // 
            // logging_filename_label
            // 
            logging_filename_label.AutoSize = true;
            logging_filename_label.Location = new Point(21, 264);
            logging_filename_label.Name = "logging_filename_label";
            logging_filename_label.Size = new Size(102, 15);
            logging_filename_label.TabIndex = 23;
            logging_filename_label.Text = "Logging Filename";
            // 
            // logging_filename_textbox
            // 
            logging_filename_textbox.Location = new Point(21, 282);
            logging_filename_textbox.Name = "logging_filename_textbox";
            logging_filename_textbox.Size = new Size(311, 23);
            logging_filename_textbox.TabIndex = 22;
            // 
            // log_once_button
            // 
            log_once_button.Location = new Point(21, 172);
            log_once_button.Name = "log_once_button";
            log_once_button.Size = new Size(94, 23);
            log_once_button.TabIndex = 21;
            log_once_button.Text = "Log Once";
            log_once_button.UseVisualStyleBackColor = true;
            // 
            // sample_once_button
            // 
            sample_once_button.Location = new Point(21, 78);
            sample_once_button.Name = "sample_once_button";
            sample_once_button.Size = new Size(94, 23);
            sample_once_button.TabIndex = 20;
            sample_once_button.Text = "Sample Once";
            sample_once_button.UseVisualStyleBackColor = true;
            // 
            // sensor_value_label
            // 
            sensor_value_label.AutoSize = true;
            sensor_value_label.Location = new Point(386, 31);
            sensor_value_label.Name = "sensor_value_label";
            sensor_value_label.Size = new Size(78, 15);
            sensor_value_label.TabIndex = 19;
            sensor_value_label.Text = "Sensor Values";
            // 
            // next_logging_time_label
            // 
            next_logging_time_label.AutoSize = true;
            next_logging_time_label.Location = new Point(160, 143);
            next_logging_time_label.Name = "next_logging_time_label";
            next_logging_time_label.Size = new Size(108, 15);
            next_logging_time_label.TabIndex = 18;
            next_logging_time_label.Text = "Next Logging Time";
            // 
            // next_sampling_time_label
            // 
            next_sampling_time_label.AutoSize = true;
            next_sampling_time_label.Location = new Point(160, 49);
            next_sampling_time_label.Name = "next_sampling_time_label";
            next_sampling_time_label.Size = new Size(114, 15);
            next_sampling_time_label.TabIndex = 17;
            next_sampling_time_label.Text = "Next Sampling Time";
            // 
            // logging_button
            // 
            logging_button.Location = new Point(21, 143);
            logging_button.Name = "logging_button";
            logging_button.Size = new Size(94, 23);
            logging_button.TabIndex = 16;
            logging_button.Text = "Start Logging";
            logging_button.UseVisualStyleBackColor = true;
            // 
            // sensor_value_textbox
            // 
            sensor_value_textbox.Location = new Point(386, 49);
            sensor_value_textbox.Multiline = true;
            sensor_value_textbox.Name = "sensor_value_textbox";
            sensor_value_textbox.ReadOnly = true;
            sensor_value_textbox.ScrollBars = ScrollBars.Vertical;
            sensor_value_textbox.Size = new Size(394, 370);
            sensor_value_textbox.TabIndex = 15;
            // 
            // next_logging_time_textbox
            // 
            next_logging_time_textbox.Location = new Point(160, 161);
            next_logging_time_textbox.Name = "next_logging_time_textbox";
            next_logging_time_textbox.ReadOnly = true;
            next_logging_time_textbox.Size = new Size(172, 23);
            next_logging_time_textbox.TabIndex = 14;
            // 
            // next_sampling_time_textbox
            // 
            next_sampling_time_textbox.Location = new Point(160, 67);
            next_sampling_time_textbox.Name = "next_sampling_time_textbox";
            next_sampling_time_textbox.ReadOnly = true;
            next_sampling_time_textbox.Size = new Size(172, 23);
            next_sampling_time_textbox.TabIndex = 13;
            // 
            // sample_button
            // 
            sample_button.Location = new Point(21, 49);
            sample_button.Name = "sample_button";
            sample_button.Size = new Size(94, 23);
            sample_button.TabIndex = 12;
            sample_button.Text = "Start Sampling";
            sample_button.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { loggingToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // loggingToolStripMenuItem
            // 
            loggingToolStripMenuItem.Name = "loggingToolStripMenuItem";
            loggingToolStripMenuItem.Size = new Size(63, 20);
            loggingToolStripMenuItem.Text = "Logging";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += HelpToolStripMenuItemClick;
            // 
            // main_window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logging_filename_label);
            Controls.Add(logging_filename_textbox);
            Controls.Add(log_once_button);
            Controls.Add(sample_once_button);
            Controls.Add(sensor_value_label);
            Controls.Add(next_logging_time_label);
            Controls.Add(next_sampling_time_label);
            Controls.Add(logging_button);
            Controls.Add(sensor_value_textbox);
            Controls.Add(next_logging_time_textbox);
            Controls.Add(next_sampling_time_textbox);
            Controls.Add(sample_button);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "main_window";
            Text = "DAQ Simulator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer sampling_timer;
        private System.Windows.Forms.Timer logging_timer;
        private Label logging_filename_label;
        private TextBox logging_filename_textbox;
        private Button log_once_button;
        private Button sample_once_button;
        private Label sensor_value_label;
        private Label next_logging_time_label;
        private Label next_sampling_time_label;
        private Button logging_button;
        private TextBox sensor_value_textbox;
        private TextBox next_logging_time_textbox;
        private TextBox next_sampling_time_textbox;
        private Button sample_button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loggingToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}
