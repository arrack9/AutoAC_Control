namespace AutoAC_Control
{
    partial class Form_ACControl
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Lbl_Comport = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_LDR1 = new System.Windows.Forms.Button();
            this.Btn_LDR2 = new System.Windows.Forms.Button();
            this.Btn_LDR3 = new System.Windows.Forms.Button();
            this.Btn_LDR4 = new System.Windows.Forms.Button();
            this.Btn_ACON = new System.Windows.Forms.Button();
            this.Btn_ACOFF = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_SaveTextFile = new System.Windows.Forms.Button();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Lbl_millseconds = new System.Windows.Forms.Label();
            this.Lbl_minutes = new System.Windows.Forms.Label();
            this.Lbl_seconds = new System.Windows.Forms.Label();
            this.TBox_DecDelyTime = new System.Windows.Forms.TextBox();
            this.TBox_RepeatTime = new System.Windows.Forms.TextBox();
            this.TBox_DelayTime = new System.Windows.Forms.TextBox();
            this.Lbl_DecDelayTime = new System.Windows.Forms.Label();
            this.Lbl_RepeatTime = new System.Windows.Forms.Label();
            this.Lbl_DelayTime = new System.Windows.Forms.Label();
            this.Lbl_LDR1 = new System.Windows.Forms.Label();
            this.LBl_LDR3 = new System.Windows.Forms.Label();
            this.Lbl_LDR2 = new System.Windows.Forms.Label();
            this.Lbl_LDR4 = new System.Windows.Forms.Label();
            this.SendDataTimer = new System.Windows.Forms.Timer(this.components);
            this.DescDelayTimer = new System.Windows.Forms.Timer(this.components);
            this.TBOX_Info = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Comport
            // 
            this.Lbl_Comport.AutoSize = true;
            this.Lbl_Comport.Location = new System.Drawing.Point(33, 20);
            this.Lbl_Comport.Name = "Lbl_Comport";
            this.Lbl_Comport.Size = new System.Drawing.Size(47, 12);
            this.Lbl_Comport.TabIndex = 0;
            this.Lbl_Comport.Text = "Comport";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Btn_LDR1
            // 
            this.Btn_LDR1.Location = new System.Drawing.Point(25, 50);
            this.Btn_LDR1.Name = "Btn_LDR1";
            this.Btn_LDR1.Size = new System.Drawing.Size(75, 23);
            this.Btn_LDR1.TabIndex = 2;
            this.Btn_LDR1.Text = "LDR1";
            this.Btn_LDR1.UseVisualStyleBackColor = true;
            this.Btn_LDR1.Click += new System.EventHandler(this.Btn_LDR1_Click);
            // 
            // Btn_LDR2
            // 
            this.Btn_LDR2.Location = new System.Drawing.Point(219, 50);
            this.Btn_LDR2.Name = "Btn_LDR2";
            this.Btn_LDR2.Size = new System.Drawing.Size(75, 23);
            this.Btn_LDR2.TabIndex = 3;
            this.Btn_LDR2.Text = "LDR2";
            this.Btn_LDR2.UseVisualStyleBackColor = true;
            this.Btn_LDR2.Click += new System.EventHandler(this.Btn_LDR2_Click);
            // 
            // Btn_LDR3
            // 
            this.Btn_LDR3.Location = new System.Drawing.Point(25, 80);
            this.Btn_LDR3.Name = "Btn_LDR3";
            this.Btn_LDR3.Size = new System.Drawing.Size(75, 23);
            this.Btn_LDR3.TabIndex = 4;
            this.Btn_LDR3.Text = "LDR3";
            this.Btn_LDR3.UseVisualStyleBackColor = true;
            // 
            // Btn_LDR4
            // 
            this.Btn_LDR4.Location = new System.Drawing.Point(219, 80);
            this.Btn_LDR4.Name = "Btn_LDR4";
            this.Btn_LDR4.Size = new System.Drawing.Size(75, 23);
            this.Btn_LDR4.TabIndex = 5;
            this.Btn_LDR4.Text = "LDR4";
            this.Btn_LDR4.UseVisualStyleBackColor = true;
            // 
            // Btn_ACON
            // 
            this.Btn_ACON.Location = new System.Drawing.Point(25, 110);
            this.Btn_ACON.Name = "Btn_ACON";
            this.Btn_ACON.Size = new System.Drawing.Size(75, 23);
            this.Btn_ACON.TabIndex = 6;
            this.Btn_ACON.Text = "AC ON";
            this.Btn_ACON.UseVisualStyleBackColor = true;
            this.Btn_ACON.Click += new System.EventHandler(this.Btn_ACON_Click);
            // 
            // Btn_ACOFF
            // 
            this.Btn_ACOFF.Location = new System.Drawing.Point(219, 110);
            this.Btn_ACOFF.Name = "Btn_ACOFF";
            this.Btn_ACOFF.Size = new System.Drawing.Size(75, 23);
            this.Btn_ACOFF.TabIndex = 7;
            this.Btn_ACOFF.Text = "AC OFF";
            this.Btn_ACOFF.UseVisualStyleBackColor = true;
            this.Btn_ACOFF.Click += new System.EventHandler(this.Btn_ACOFF_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBOX_Info);
            this.groupBox1.Controls.Add(this.Btn_SaveTextFile);
            this.groupBox1.Controls.Add(this.Btn_Start);
            this.groupBox1.Controls.Add(this.Lbl_millseconds);
            this.groupBox1.Controls.Add(this.Lbl_minutes);
            this.groupBox1.Controls.Add(this.Lbl_seconds);
            this.groupBox1.Controls.Add(this.TBox_DecDelyTime);
            this.groupBox1.Controls.Add(this.TBox_RepeatTime);
            this.groupBox1.Controls.Add(this.TBox_DelayTime);
            this.groupBox1.Controls.Add(this.Lbl_DecDelayTime);
            this.groupBox1.Controls.Add(this.Lbl_RepeatTime);
            this.groupBox1.Controls.Add(this.Lbl_DelayTime);
            this.groupBox1.Location = new System.Drawing.Point(25, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 280);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto AC Off/On";
            // 
            // Btn_SaveTextFile
            // 
            this.Btn_SaveTextFile.Location = new System.Drawing.Point(283, 255);
            this.Btn_SaveTextFile.Name = "Btn_SaveTextFile";
            this.Btn_SaveTextFile.Size = new System.Drawing.Size(75, 23);
            this.Btn_SaveTextFile.TabIndex = 14;
            this.Btn_SaveTextFile.Text = "Save As";
            this.Btn_SaveTextFile.UseVisualStyleBackColor = true;
            this.Btn_SaveTextFile.Click += new System.EventHandler(this.Btn_SaveTextFile_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(196, 39);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 55);
            this.Btn_Start.TabIndex = 12;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Lbl_millseconds
            // 
            this.Lbl_millseconds.AutoSize = true;
            this.Lbl_millseconds.Location = new System.Drawing.Point(164, 91);
            this.Lbl_millseconds.Name = "Lbl_millseconds";
            this.Lbl_millseconds.Size = new System.Drawing.Size(18, 12);
            this.Lbl_millseconds.TabIndex = 8;
            this.Lbl_millseconds.Text = "ms";
            // 
            // Lbl_minutes
            // 
            this.Lbl_minutes.AutoSize = true;
            this.Lbl_minutes.Location = new System.Drawing.Point(164, 32);
            this.Lbl_minutes.Name = "Lbl_minutes";
            this.Lbl_minutes.Size = new System.Drawing.Size(8, 12);
            this.Lbl_minutes.TabIndex = 7;
            this.Lbl_minutes.Text = "t";
            // 
            // Lbl_seconds
            // 
            this.Lbl_seconds.AutoSize = true;
            this.Lbl_seconds.Location = new System.Drawing.Point(164, 65);
            this.Lbl_seconds.Name = "Lbl_seconds";
            this.Lbl_seconds.Size = new System.Drawing.Size(9, 12);
            this.Lbl_seconds.TabIndex = 6;
            this.Lbl_seconds.Text = "s";
            // 
            // TBox_DecDelyTime
            // 
            this.TBox_DecDelyTime.Location = new System.Drawing.Point(120, 88);
            this.TBox_DecDelyTime.Name = "TBox_DecDelyTime";
            this.TBox_DecDelyTime.Size = new System.Drawing.Size(37, 22);
            this.TBox_DecDelyTime.TabIndex = 5;
            this.TBox_DecDelyTime.Text = "100";
            // 
            // TBox_RepeatTime
            // 
            this.TBox_RepeatTime.Location = new System.Drawing.Point(120, 28);
            this.TBox_RepeatTime.Name = "TBox_RepeatTime";
            this.TBox_RepeatTime.Size = new System.Drawing.Size(37, 22);
            this.TBox_RepeatTime.TabIndex = 4;
            this.TBox_RepeatTime.Text = "10";
            // 
            // TBox_DelayTime
            // 
            this.TBox_DelayTime.Location = new System.Drawing.Point(120, 61);
            this.TBox_DelayTime.Name = "TBox_DelayTime";
            this.TBox_DelayTime.Size = new System.Drawing.Size(37, 22);
            this.TBox_DelayTime.TabIndex = 3;
            this.TBox_DelayTime.Text = "10";
            // 
            // Lbl_DecDelayTime
            // 
            this.Lbl_DecDelayTime.AutoSize = true;
            this.Lbl_DecDelayTime.Location = new System.Drawing.Point(6, 92);
            this.Lbl_DecDelayTime.Name = "Lbl_DecDelayTime";
            this.Lbl_DecDelayTime.Size = new System.Drawing.Size(103, 12);
            this.Lbl_DecDelayTime.TabIndex = 2;
            this.Lbl_DecDelayTime.Text = "Decrease Delay Time";
            // 
            // Lbl_RepeatTime
            // 
            this.Lbl_RepeatTime.AutoSize = true;
            this.Lbl_RepeatTime.Location = new System.Drawing.Point(8, 31);
            this.Lbl_RepeatTime.Name = "Lbl_RepeatTime";
            this.Lbl_RepeatTime.Size = new System.Drawing.Size(81, 12);
            this.Lbl_RepeatTime.TabIndex = 1;
            this.Lbl_RepeatTime.Text = "Set Repeat Time";
            // 
            // Lbl_DelayTime
            // 
            this.Lbl_DelayTime.AutoSize = true;
            this.Lbl_DelayTime.Location = new System.Drawing.Point(8, 64);
            this.Lbl_DelayTime.Name = "Lbl_DelayTime";
            this.Lbl_DelayTime.Size = new System.Drawing.Size(76, 12);
            this.Lbl_DelayTime.TabIndex = 0;
            this.Lbl_DelayTime.Text = "Set Delay Time";
            // 
            // Lbl_LDR1
            // 
            this.Lbl_LDR1.AutoSize = true;
            this.Lbl_LDR1.Location = new System.Drawing.Point(121, 55);
            this.Lbl_LDR1.Name = "Lbl_LDR1";
            this.Lbl_LDR1.Size = new System.Drawing.Size(11, 12);
            this.Lbl_LDR1.TabIndex = 9;
            this.Lbl_LDR1.Text = "0";
            // 
            // LBl_LDR3
            // 
            this.LBl_LDR3.AutoSize = true;
            this.LBl_LDR3.Location = new System.Drawing.Point(121, 85);
            this.LBl_LDR3.Name = "LBl_LDR3";
            this.LBl_LDR3.Size = new System.Drawing.Size(11, 12);
            this.LBl_LDR3.TabIndex = 10;
            this.LBl_LDR3.Text = "0";
            // 
            // Lbl_LDR2
            // 
            this.Lbl_LDR2.AutoSize = true;
            this.Lbl_LDR2.Location = new System.Drawing.Point(320, 55);
            this.Lbl_LDR2.Name = "Lbl_LDR2";
            this.Lbl_LDR2.Size = new System.Drawing.Size(11, 12);
            this.Lbl_LDR2.TabIndex = 11;
            this.Lbl_LDR2.Text = "0";
            // 
            // Lbl_LDR4
            // 
            this.Lbl_LDR4.AutoSize = true;
            this.Lbl_LDR4.Location = new System.Drawing.Point(320, 85);
            this.Lbl_LDR4.Name = "Lbl_LDR4";
            this.Lbl_LDR4.Size = new System.Drawing.Size(11, 12);
            this.Lbl_LDR4.TabIndex = 12;
            this.Lbl_LDR4.Text = "0";
            // 
            // SendDataTimer
            // 
            this.SendDataTimer.Interval = 1000;
            // 
            // TBOX_Info
            // 
            this.TBOX_Info.AllowDrop = true;
            this.TBOX_Info.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBOX_Info.Location = new System.Drawing.Point(9, 118);
            this.TBOX_Info.Multiline = true;
            this.TBOX_Info.Name = "TBOX_Info";
            this.TBOX_Info.Size = new System.Drawing.Size(349, 131);
            this.TBOX_Info.TabIndex = 15;
            // 
            // Form_ACControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 423);
            this.Controls.Add(this.Lbl_LDR4);
            this.Controls.Add(this.Lbl_LDR2);
            this.Controls.Add(this.LBl_LDR3);
            this.Controls.Add(this.Lbl_LDR1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_ACOFF);
            this.Controls.Add(this.Btn_ACON);
            this.Controls.Add(this.Btn_LDR4);
            this.Controls.Add(this.Btn_LDR3);
            this.Controls.Add(this.Btn_LDR2);
            this.Controls.Add(this.Btn_LDR1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Lbl_Comport);
            this.Name = "Form_ACControl";
            this.Text = "AC Control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Comport;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_LDR1;
        private System.Windows.Forms.Button Btn_LDR2;
        private System.Windows.Forms.Button Btn_LDR3;
        private System.Windows.Forms.Button Btn_LDR4;
        private System.Windows.Forms.Button Btn_ACON;
        private System.Windows.Forms.Button Btn_ACOFF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_SaveTextFile;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Label Lbl_millseconds;
        private System.Windows.Forms.Label Lbl_minutes;
        private System.Windows.Forms.Label Lbl_seconds;
        private System.Windows.Forms.TextBox TBox_DecDelyTime;
        private System.Windows.Forms.TextBox TBox_RepeatTime;
        private System.Windows.Forms.TextBox TBox_DelayTime;
        private System.Windows.Forms.Label Lbl_DecDelayTime;
        private System.Windows.Forms.Label Lbl_RepeatTime;
        private System.Windows.Forms.Label Lbl_DelayTime;
        private System.Windows.Forms.Label Lbl_LDR1;
        private System.Windows.Forms.Label LBl_LDR3;
        private System.Windows.Forms.Label Lbl_LDR2;
        private System.Windows.Forms.Label Lbl_LDR4;
        private System.Windows.Forms.Timer SendDataTimer;
        private System.Windows.Forms.Timer DescDelayTimer;
        private System.Windows.Forms.TextBox TBOX_Info;
    }
}

