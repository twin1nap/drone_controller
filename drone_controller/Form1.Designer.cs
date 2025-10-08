namespace drone_controller
{
    partial class drone_controller
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
            this.BtnSaveFlightPath = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnOpenFlightPath = new System.Windows.Forms.Button();
            this.RtbFlightPath = new System.Windows.Forms.RichTextBox();
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
            this.button_fly_land = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.button_yaw_right = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_yaw_left = new System.Windows.Forms.Button();
            this.button_forward = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.tabPage_advanced = new System.Windows.Forms.TabPage();
            this.openFlightPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFlightPathDialog = new System.Windows.Forms.SaveFileDialog();
            this.label7 = new System.Windows.Forms.Label();
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
            this.tabControl.Size = new System.Drawing.Size(796, 740);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_standaard
            // 
            this.tabPage_standaard.Controls.Add(this.label7);
            this.tabPage_standaard.Controls.Add(this.BtnSaveFlightPath);
            this.tabPage_standaard.Controls.Add(this.button1);
            this.tabPage_standaard.Controls.Add(this.BtnOpenFlightPath);
            this.tabPage_standaard.Controls.Add(this.RtbFlightPath);
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
            this.tabPage_standaard.Controls.Add(this.button_fly_land);
            this.tabPage_standaard.Controls.Add(this.button_up);
            this.tabPage_standaard.Controls.Add(this.button_yaw_right);
            this.tabPage_standaard.Controls.Add(this.button_down);
            this.tabPage_standaard.Controls.Add(this.button_yaw_left);
            this.tabPage_standaard.Controls.Add(this.button_forward);
            this.tabPage_standaard.Controls.Add(this.button_right);
            this.tabPage_standaard.Controls.Add(this.button_back);
            this.tabPage_standaard.Controls.Add(this.button_left);
            this.tabPage_standaard.Location = new System.Drawing.Point(4, 25);
            this.tabPage_standaard.Name = "tabPage_standaard";
            this.tabPage_standaard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_standaard.Size = new System.Drawing.Size(788, 711);
            this.tabPage_standaard.TabIndex = 0;
            this.tabPage_standaard.Text = "standaard";
            this.tabPage_standaard.UseVisualStyleBackColor = true;
            // 
            // BtnSaveFlightPath
            // 
            this.BtnSaveFlightPath.Location = new System.Drawing.Point(521, 417);
            this.BtnSaveFlightPath.Name = "BtnSaveFlightPath";
            this.BtnSaveFlightPath.Size = new System.Drawing.Size(127, 34);
            this.BtnSaveFlightPath.TabIndex = 22;
            this.BtnSaveFlightPath.Text = "save flight plan";
            this.BtnSaveFlightPath.UseVisualStyleBackColor = true;
            this.BtnSaveFlightPath.Click += new System.EventHandler(this.BtnSaveFlightPath_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "run flight plan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnOpenFlightPath
            // 
            this.BtnOpenFlightPath.Location = new System.Drawing.Point(10, 417);
            this.BtnOpenFlightPath.Name = "BtnOpenFlightPath";
            this.BtnOpenFlightPath.Size = new System.Drawing.Size(127, 34);
            this.BtnOpenFlightPath.TabIndex = 20;
            this.BtnOpenFlightPath.Text = "open flight plan";
            this.BtnOpenFlightPath.UseVisualStyleBackColor = true;
            this.BtnOpenFlightPath.Click += new System.EventHandler(this.BtnOpenFlightPath_Click);
            // 
            // RtbFlightPath
            // 
            this.RtbFlightPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RtbFlightPath.Location = new System.Drawing.Point(10, 457);
            this.RtbFlightPath.Name = "RtbFlightPath";
            this.RtbFlightPath.Size = new System.Drawing.Size(771, 229);
            this.RtbFlightPath.TabIndex = 19;
            this.RtbFlightPath.Text = "";
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
            // button_fly_land
            // 
            this.button_fly_land.Location = new System.Drawing.Point(310, 112);
            this.button_fly_land.Name = "button_fly_land";
            this.button_fly_land.Size = new System.Drawing.Size(124, 53);
            this.button_fly_land.TabIndex = 8;
            this.button_fly_land.Text = "takeoff/land\r\n(space)";
            this.button_fly_land.UseVisualStyleBackColor = true;
            this.button_fly_land.Click += new System.EventHandler(this.button_fly_land_Click);
            // 
            // button_up
            // 
            this.button_up.Location = new System.Drawing.Point(526, 112);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(87, 53);
            this.button_up.TabIndex = 7;
            this.button_up.Tag = "up";
            this.button_up.Text = "up\r\n(↑)";
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.button_Click);
            // 
            // button_yaw_right
            // 
            this.button_yaw_right.Location = new System.Drawing.Point(619, 171);
            this.button_yaw_right.Name = "button_yaw_right";
            this.button_yaw_right.Size = new System.Drawing.Size(87, 53);
            this.button_yaw_right.TabIndex = 6;
            this.button_yaw_right.Tag = "cw";
            this.button_yaw_right.Text = "yaw right\r\n(→)";
            this.button_yaw_right.UseVisualStyleBackColor = true;
            this.button_yaw_right.Click += new System.EventHandler(this.button_Click);
            // 
            // button_down
            // 
            this.button_down.Location = new System.Drawing.Point(526, 171);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(87, 53);
            this.button_down.TabIndex = 5;
            this.button_down.Tag = "down";
            this.button_down.Text = "down\r\n(↓)";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.button_Click);
            // 
            // button_yaw_left
            // 
            this.button_yaw_left.Location = new System.Drawing.Point(433, 171);
            this.button_yaw_left.Name = "button_yaw_left";
            this.button_yaw_left.Size = new System.Drawing.Size(87, 53);
            this.button_yaw_left.TabIndex = 4;
            this.button_yaw_left.Tag = "ccw";
            this.button_yaw_left.Text = "yaw left\r\n(←)\r\n";
            this.button_yaw_left.UseVisualStyleBackColor = true;
            this.button_yaw_left.Click += new System.EventHandler(this.button_Click);
            // 
            // button_forward
            // 
            this.button_forward.Location = new System.Drawing.Point(131, 112);
            this.button_forward.Name = "button_forward";
            this.button_forward.Size = new System.Drawing.Size(87, 53);
            this.button_forward.TabIndex = 3;
            this.button_forward.Tag = "forward";
            this.button_forward.Text = "forward\r\n(W)";
            this.button_forward.UseVisualStyleBackColor = true;
            this.button_forward.Click += new System.EventHandler(this.button_Click);
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(224, 171);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(87, 53);
            this.button_right.TabIndex = 2;
            this.button_right.Tag = "right";
            this.button_right.Text = "right\r\n(R)";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(131, 171);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(87, 53);
            this.button_back.TabIndex = 1;
            this.button_back.Tag = "back";
            this.button_back.Text = "backward\r\n(S)";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_Click);
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(38, 171);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(87, 53);
            this.button_left.TabIndex = 0;
            this.button_left.Tag = "left";
            this.button_left.Text = "left\r\n(A)";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_Click);
            // 
            // tabPage_advanced
            // 
            this.tabPage_advanced.Location = new System.Drawing.Point(4, 25);
            this.tabPage_advanced.Name = "tabPage_advanced";
            this.tabPage_advanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_advanced.Size = new System.Drawing.Size(788, 674);
            this.tabPage_advanced.TabIndex = 1;
            this.tabPage_advanced.Text = "advanced";
            this.tabPage_advanced.UseVisualStyleBackColor = true;
            // 
            // openFlightPathDialog
            // 
            this.openFlightPathDialog.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 690);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(591, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Use only directional commands because rc command wont work because it can\'t remem" +
    "ber timing.";
            // 
            // drone_controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 742);
            this.Controls.Add(this.tabControl);
            this.KeyPreview = true;
            this.Name = "drone_controller";
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
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_speed;
        private System.Windows.Forms.Button button_fly_land;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_yaw_right;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_yaw_left;
        private System.Windows.Forms.Button button_forward;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_distance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_angle;
        private System.Windows.Forms.Button BtnOpenFlightPath;
        private System.Windows.Forms.RichTextBox RtbFlightPath;
        private System.Windows.Forms.OpenFileDialog openFlightPathDialog;
        private System.Windows.Forms.Button BtnSaveFlightPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFlightPathDialog;
        private System.Windows.Forms.Label label7;
    }
}

