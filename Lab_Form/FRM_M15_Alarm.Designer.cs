namespace Lab_Form
{
    partial class FRM_M15_Alarm
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
            this.components = new System.ComponentModel.Container();
            this.Time_Now = new System.Windows.Forms.Timer(this.components);
            this.LAB_Time = new System.Windows.Forms.Label();
            this.NUD1 = new System.Windows.Forms.NumericUpDown();
            this.NUD2 = new System.Windows.Forms.NumericUpDown();
            this.NUD3 = new System.Windows.Forms.NumericUpDown();
            this.LAB_NowTime = new System.Windows.Forms.Label();
            this.BTN_Set = new System.Windows.Forms.Button();
            this.GP_Alarm = new System.Windows.Forms.GroupBox();
            this.LAB_Second = new System.Windows.Forms.Label();
            this.LAB_Minute = new System.Windows.Forms.Label();
            this.LAB_HOUR = new System.Windows.Forms.Label();
            this.Time_Alarm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NUD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD3)).BeginInit();
            this.GP_Alarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Time_Now
            // 
            this.Time_Now.Enabled = true;
            this.Time_Now.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LAB_Time
            // 
            this.LAB_Time.AutoSize = true;
            this.LAB_Time.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Time.Location = new System.Drawing.Point(297, 92);
            this.LAB_Time.Name = "LAB_Time";
            this.LAB_Time.Size = new System.Drawing.Size(68, 29);
            this.LAB_Time.TabIndex = 1;
            this.LAB_Time.Text = "Time";
            // 
            // NUD1
            // 
            this.NUD1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NUD1.Location = new System.Drawing.Point(77, 86);
            this.NUD1.Name = "NUD1";
            this.NUD1.Size = new System.Drawing.Size(64, 31);
            this.NUD1.TabIndex = 2;
            // 
            // NUD2
            // 
            this.NUD2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NUD2.Location = new System.Drawing.Point(166, 86);
            this.NUD2.Name = "NUD2";
            this.NUD2.Size = new System.Drawing.Size(64, 31);
            this.NUD2.TabIndex = 2;
            // 
            // NUD3
            // 
            this.NUD3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NUD3.Location = new System.Drawing.Point(254, 86);
            this.NUD3.Name = "NUD3";
            this.NUD3.Size = new System.Drawing.Size(64, 31);
            this.NUD3.TabIndex = 2;
            // 
            // LAB_NowTime
            // 
            this.LAB_NowTime.AutoSize = true;
            this.LAB_NowTime.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_NowTime.Location = new System.Drawing.Point(115, 92);
            this.LAB_NowTime.Name = "LAB_NowTime";
            this.LAB_NowTime.Size = new System.Drawing.Size(157, 28);
            this.LAB_NowTime.TabIndex = 3;
            this.LAB_NowTime.Text = "現在時間：";
            // 
            // BTN_Set
            // 
            this.BTN_Set.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Set.Location = new System.Drawing.Point(121, 154);
            this.BTN_Set.Name = "BTN_Set";
            this.BTN_Set.Size = new System.Drawing.Size(162, 49);
            this.BTN_Set.TabIndex = 4;
            this.BTN_Set.Text = "設置鬧鐘";
            this.BTN_Set.UseVisualStyleBackColor = true;
            this.BTN_Set.Click += new System.EventHandler(this.BTN_Set_Click);
            // 
            // GP_Alarm
            // 
            this.GP_Alarm.Controls.Add(this.LAB_Second);
            this.GP_Alarm.Controls.Add(this.LAB_Minute);
            this.GP_Alarm.Controls.Add(this.LAB_HOUR);
            this.GP_Alarm.Controls.Add(this.NUD1);
            this.GP_Alarm.Controls.Add(this.BTN_Set);
            this.GP_Alarm.Controls.Add(this.NUD2);
            this.GP_Alarm.Controls.Add(this.NUD3);
            this.GP_Alarm.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GP_Alarm.Location = new System.Drawing.Point(196, 176);
            this.GP_Alarm.Name = "GP_Alarm";
            this.GP_Alarm.Size = new System.Drawing.Size(394, 247);
            this.GP_Alarm.TabIndex = 5;
            this.GP_Alarm.TabStop = false;
            this.GP_Alarm.Text = "Alarm";
            // 
            // LAB_Second
            // 
            this.LAB_Second.AutoSize = true;
            this.LAB_Second.Cursor = System.Windows.Forms.Cursors.Default;
            this.LAB_Second.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Second.Location = new System.Drawing.Point(265, 45);
            this.LAB_Second.Name = "LAB_Second";
            this.LAB_Second.Size = new System.Drawing.Size(30, 20);
            this.LAB_Second.TabIndex = 5;
            this.LAB_Second.Text = "秒";
            // 
            // LAB_Minute
            // 
            this.LAB_Minute.AutoSize = true;
            this.LAB_Minute.Cursor = System.Windows.Forms.Cursors.Default;
            this.LAB_Minute.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Minute.Location = new System.Drawing.Point(175, 45);
            this.LAB_Minute.Name = "LAB_Minute";
            this.LAB_Minute.Size = new System.Drawing.Size(30, 20);
            this.LAB_Minute.TabIndex = 5;
            this.LAB_Minute.Text = "分";
            // 
            // LAB_HOUR
            // 
            this.LAB_HOUR.AutoSize = true;
            this.LAB_HOUR.Cursor = System.Windows.Forms.Cursors.Default;
            this.LAB_HOUR.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_HOUR.Location = new System.Drawing.Point(86, 45);
            this.LAB_HOUR.Name = "LAB_HOUR";
            this.LAB_HOUR.Size = new System.Drawing.Size(30, 20);
            this.LAB_HOUR.TabIndex = 5;
            this.LAB_HOUR.Text = "時";
            // 
            // Time_Alarm
            // 
            this.Time_Alarm.Tick += new System.EventHandler(this.Time_Alarm_Tick);
            // 
            // FRM_M15_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 529);
            this.Controls.Add(this.GP_Alarm);
            this.Controls.Add(this.LAB_NowTime);
            this.Controls.Add(this.LAB_Time);
            this.Name = "FRM_M15_Alarm";
            this.Text = "FRM_M15_Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.NUD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD3)).EndInit();
            this.GP_Alarm.ResumeLayout(false);
            this.GP_Alarm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Time_Now;
        private System.Windows.Forms.Label LAB_Time;
        private System.Windows.Forms.NumericUpDown NUD1;
        private System.Windows.Forms.NumericUpDown NUD2;
        private System.Windows.Forms.NumericUpDown NUD3;
        private System.Windows.Forms.Label LAB_NowTime;
        private System.Windows.Forms.Button BTN_Set;
        private System.Windows.Forms.GroupBox GP_Alarm;
        private System.Windows.Forms.Label LAB_Second;
        private System.Windows.Forms.Label LAB_Minute;
        private System.Windows.Forms.Label LAB_HOUR;
        private System.Windows.Forms.Timer Time_Alarm;
    }
}