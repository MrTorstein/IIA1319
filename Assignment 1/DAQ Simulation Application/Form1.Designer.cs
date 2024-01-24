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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_window));
            tab_control = new TabControl();
            logging_page = new TabPage();
            sensor_value_label = new Label();
            next_logging_time_label = new Label();
            next_sampling_time_label = new Label();
            logging_button = new Button();
            sensor_value_textbox = new TextBox();
            next_logging_time_textbox = new TextBox();
            next_sampling_time_textbox = new TextBox();
            sample_button = new Button();
            help_page = new TabPage();
            help_textbox = new TextBox();
            tab_control.SuspendLayout();
            logging_page.SuspendLayout();
            help_page.SuspendLayout();
            SuspendLayout();
            // 
            // tab_control
            // 
            tab_control.Controls.Add(logging_page);
            tab_control.Controls.Add(help_page);
            tab_control.Location = new Point(-2, -2);
            tab_control.Name = "tab_control";
            tab_control.SelectedIndex = 0;
            tab_control.Size = new Size(802, 454);
            tab_control.TabIndex = 0;
            // 
            // logging_page
            // 
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
            // sensor_value_label
            // 
            sensor_value_label.AutoSize = true;
            sensor_value_label.Location = new Point(394, 32);
            sensor_value_label.Name = "sensor_value_label";
            sensor_value_label.Size = new Size(78, 15);
            sensor_value_label.TabIndex = 7;
            sensor_value_label.Text = "Sensor Values";
            sensor_value_label.Click += label3_Click;
            // 
            // next_logging_time_label
            // 
            next_logging_time_label.AutoSize = true;
            next_logging_time_label.Location = new Point(168, 126);
            next_logging_time_label.Name = "next_logging_time_label";
            next_logging_time_label.Size = new Size(108, 15);
            next_logging_time_label.TabIndex = 6;
            next_logging_time_label.Text = "Next Logging Time";
            // 
            // next_sampling_time_label
            // 
            next_sampling_time_label.AutoSize = true;
            next_sampling_time_label.Location = new Point(168, 32);
            next_sampling_time_label.Name = "next_sampling_time_label";
            next_sampling_time_label.Size = new Size(114, 15);
            next_sampling_time_label.TabIndex = 5;
            next_sampling_time_label.Text = "Next Sampling Time";
            // 
            // logging_button
            // 
            logging_button.Location = new Point(48, 144);
            logging_button.Name = "logging_button";
            logging_button.Size = new Size(75, 23);
            logging_button.TabIndex = 4;
            logging_button.Text = "Log";
            logging_button.UseVisualStyleBackColor = true;
            logging_button.Click += button2_Click;
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
            next_logging_time_textbox.Location = new Point(168, 144);
            next_logging_time_textbox.Name = "next_logging_time_textbox";
            next_logging_time_textbox.ReadOnly = true;
            next_logging_time_textbox.Size = new Size(172, 23);
            next_logging_time_textbox.TabIndex = 2;
            // 
            // next_sampling_time_textbox
            // 
            next_sampling_time_textbox.Location = new Point(168, 50);
            next_sampling_time_textbox.Name = "next_sampling_time_textbox";
            next_sampling_time_textbox.ReadOnly = true;
            next_sampling_time_textbox.Size = new Size(172, 23);
            next_sampling_time_textbox.TabIndex = 1;
            // 
            // sample_button
            // 
            sample_button.Location = new Point(48, 50);
            sample_button.Name = "sample_button";
            sample_button.Size = new Size(75, 23);
            sample_button.TabIndex = 0;
            sample_button.Text = "Sample";
            sample_button.UseVisualStyleBackColor = true;
            sample_button.Click += button1_Click;
            // 
            // help_page
            // 
            help_page.Controls.Add(help_textbox);
            help_page.Location = new Point(4, 24);
            help_page.Name = "help_page";
            help_page.Padding = new Padding(3);
            help_page.Size = new Size(794, 426);
            help_page.TabIndex = 1;
            help_page.Text = "Help";
            help_page.UseVisualStyleBackColor = true;
            // 
            // help_textbox
            // 
            help_textbox.Location = new Point(6, 6);
            help_textbox.Multiline = true;
            help_textbox.Name = "help_textbox";
            help_textbox.Size = new Size(780, 414);
            help_textbox.TabIndex = 4;
            help_textbox.Text = "This is where help message is written.";
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
            help_page.ResumeLayout(false);
            help_page.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab_control;
        private TabPage logging_page;
        private TabPage help_page;
        private TextBox next_sampling_time_textbox;
        private Button sample_button;
        private Button logging_button;
        private TextBox sensor_value_textbox;
        private TextBox next_logging_time_textbox;
        private Label next_logging_time_label;
        private Label next_sampling_time_label;
        private Label sensor_value_label;
        private TextBox help_textbox;
    }
}
