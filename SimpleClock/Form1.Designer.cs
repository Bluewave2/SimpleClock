namespace SimpleClock
{
    partial class Form1
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
            lblTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            trackBar1 = new TrackBar();
            lblInterval = new Label();
            label1 = new Label();
            btnPause = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblCulture = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(108, 132);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(585, 128);
            lblTime.TabIndex = 0;
            lblTime.Text = "22:08:57:999";
            lblTime.Click += lblTime_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(108, 373);
            trackBar1.Maximum = 1000;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(585, 45);
            trackBar1.SmallChange = 10;
            trackBar1.TabIndex = 10;
            trackBar1.TickFrequency = 10;
            trackBar1.Value = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // lblInterval
            // 
            lblInterval.AutoSize = true;
            lblInterval.Location = new Point(378, 426);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(44, 15);
            lblInterval.TabIndex = 2;
            lblInterval.Text = "100 ms";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 355);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 3;
            label1.Text = "Refresh interval";
            // 
            // btnPause
            // 
            btnPause.Location = new Point(713, 373);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(75, 65);
            btnPause.TabIndex = 11;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 245);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 12;
            label2.Text = "hours";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 245);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 12;
            label3.Text = "minutes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 245);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 12;
            label4.Text = "seconds";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 245);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 12;
            label5.Text = "milliseconds";
            // 
            // lblCulture
            // 
            lblCulture.AutoSize = true;
            lblCulture.Location = new Point(12, 426);
            lblCulture.Name = "lblCulture";
            lblCulture.Size = new Size(49, 15);
            lblCulture.TabIndex = 13;
            lblCulture.Text = "Culture:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(713, 33);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(57, 21);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Github";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(lblCulture);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnPause);
            Controls.Add(label1);
            Controls.Add(lblInterval);
            Controls.Add(trackBar1);
            Controls.Add(lblTime);
            MaximizeBox = false;
            Name = "Form1";
            Text = "SimpleClock";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private TrackBar trackBar1;
        private Label lblInterval;
        private Label label1;
        private Button btnPause;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblCulture;
        private LinkLabel linkLabel1;
    }
}
