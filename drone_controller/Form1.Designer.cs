namespace drone_controller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_standaard = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num_distance = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_angle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_speed = new System.Windows.Forms.TrackBar();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage_advanced = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage_standaard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage_standaard);
            this.tabControl.Controls.Add(this.tabPage_advanced);
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(796, 448);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_standaard
            // 
            this.tabPage_standaard.Controls.Add(this.label5);
            this.tabPage_standaard.Controls.Add(this.label6);
            this.tabPage_standaard.Controls.Add(this.num_distance);
            this.tabPage_standaard.Controls.Add(this.label4);
            this.tabPage_standaard.Controls.Add(this.label2);
            this.tabPage_standaard.Controls.Add(this.num_angle);
            this.tabPage_standaard.Controls.Add(this.label3);
            this.tabPage_standaard.Controls.Add(this.lbl_speed);
            this.tabPage_standaard.Controls.Add(this.label1);
            this.tabPage_standaard.Controls.Add(this.trackBar_speed);
            this.tabPage_standaard.Controls.Add(this.button9);
            this.tabPage_standaard.Controls.Add(this.button5);
            this.tabPage_standaard.Controls.Add(this.button6);
            this.tabPage_standaard.Controls.Add(this.button7);
            this.tabPage_standaard.Controls.Add(this.button8);
            this.tabPage_standaard.Controls.Add(this.button4);
            this.tabPage_standaard.Controls.Add(this.button3);
            this.tabPage_standaard.Controls.Add(this.button2);
            this.tabPage_standaard.Controls.Add(this.button1);
            this.tabPage_standaard.Location = new System.Drawing.Point(4, 25);
            this.tabPage_standaard.Name = "tabPage_standaard";
            this.tabPage_standaard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_standaard.Size = new System.Drawing.Size(788, 419);
            this.tabPage_standaard.TabIndex = 0;
            this.tabPage_standaard.Text = "standaard";
            this.tabPage_standaard.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "cm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "travel amount";
            // 
            // num_distance
            // 
            this.num_distance.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_distance.InterceptArrowKeys = false;
            this.num_distance.Location = new System.Drawing.Point(130, 50);
            this.num_distance.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_distance.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_distance.Name = "num_distance";
            this.num_distance.Size = new System.Drawing.Size(120, 22);
            this.num_distance.TabIndex = 16;
            this.num_distance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(753, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "rotate amuont:";
            // 
            // num_angle
            // 
            this.num_angle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_angle.InterceptArrowKeys = false;
            this.num_angle.Location = new System.Drawing.Point(627, 50);
            this.num_angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.num_angle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_angle.Name = "num_angle";
            this.num_angle.Size = new System.Drawing.Size(120, 22);
            this.num_angle.TabIndex = 13;
            this.num_angle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "stats";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(526, 256);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(21, 16);
            this.lbl_speed.TabIndex = 11;
            this.lbl_speed.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "speed:";
            // 
            // trackBar_speed
            // 
            this.trackBar_speed.Location = new System.Drawing.Point(224, 256);
            this.trackBar_speed.Maximum = 100;
            this.trackBar_speed.Minimum = 10;
            this.trackBar_speed.Name = "trackBar_speed";
            this.trackBar_speed.Size = new System.Drawing.Size(296, 56);
            this.trackBar_speed.TabIndex = 9;
            this.trackBar_speed.Value = 50;
            this.trackBar_speed.Scroll += new System.EventHandler(this.trackBar_speed_Scroll);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(309, 112);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 53);
            this.button9.TabIndex = 8;
            this.button9.Text = "takeoff/land\r\n(space)";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(526, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 53);
            this.button5.TabIndex = 7;
            this.button5.Tag = "up";
            this.button5.Text = "up\r\n(↑)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(619, 171);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 53);
            this.button6.TabIndex = 6;
            this.button6.Tag = "cw";
            this.button6.Text = "yaw right\r\n(→)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(526, 171);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 53);
            this.button7.TabIndex = 5;
            this.button7.Tag = "down";
            this.button7.Text = "down\r\n(↓)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(433, 171);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 53);
            this.button8.TabIndex = 4;
            this.button8.Tag = "ccw";
            this.button8.Text = "yaw left\r\n(←)\r\n";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(131, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 53);
            this.button4.TabIndex = 3;
            this.button4.Tag = "forward";
            this.button4.Text = "forward\r\n(W)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 53);
            this.button3.TabIndex = 2;
            this.button3.Tag = "right";
            this.button3.Text = "right\r\n(R)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 53);
            this.button2.TabIndex = 1;
            this.button2.Tag = "back";
            this.button2.Text = "backward\r\n(S)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 53);
            this.button1.TabIndex = 0;
            this.button1.Tag = "left";
            this.button1.Text = "left\r\n(A)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // tabPage_advanced
            // 
            this.tabPage_advanced.Location = new System.Drawing.Point(4, 25);
            this.tabPage_advanced.Name = "tabPage_advanced";
            this.tabPage_advanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_advanced.Size = new System.Drawing.Size(788, 419);
            this.tabPage_advanced.TabIndex = 1;
            this.tabPage_advanced.Text = "advanced";
            this.tabPage_advanced.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl.ResumeLayout(false);
            this.tabPage_standaard.ResumeLayout(false);
            this.tabPage_standaard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_standaard;
        private System.Windows.Forms.TabPage tabPage_advanced;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_speed;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_distance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_angle;
    }
}

