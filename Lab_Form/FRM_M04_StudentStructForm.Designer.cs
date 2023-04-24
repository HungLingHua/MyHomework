namespace Lab_Form
{
    partial class FRM_M04_StudentStructForm
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
            this.LAB_Name = new System.Windows.Forms.Label();
            this.LAB_Chinese = new System.Windows.Forms.Label();
            this.LAB_English = new System.Windows.Forms.Label();
            this.LAB_Math = new System.Windows.Forms.Label();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.TXT_Chinese = new System.Windows.Forms.TextBox();
            this.TXT_English = new System.Windows.Forms.TextBox();
            this.TXT_Math = new System.Windows.Forms.TextBox();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Show = new System.Windows.Forms.Button();
            this.GB_Grade = new System.Windows.Forms.GroupBox();
            this.TXT_Show = new System.Windows.Forms.TextBox();
            this.LSB_Score = new System.Windows.Forms.ListBox();
            this.BTN_EST = new System.Windows.Forms.Button();
            this.GB_Grade.SuspendLayout();
            this.SuspendLayout();
            // 
            // LAB_Name
            // 
            this.LAB_Name.AutoSize = true;
            this.LAB_Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Name.Location = new System.Drawing.Point(35, 92);
            this.LAB_Name.Name = "LAB_Name";
            this.LAB_Name.Size = new System.Drawing.Size(72, 25);
            this.LAB_Name.TabIndex = 0;
            this.LAB_Name.Text = "姓名：";
            // 
            // LAB_Chinese
            // 
            this.LAB_Chinese.AutoSize = true;
            this.LAB_Chinese.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Chinese.Location = new System.Drawing.Point(35, 154);
            this.LAB_Chinese.Name = "LAB_Chinese";
            this.LAB_Chinese.Size = new System.Drawing.Size(72, 25);
            this.LAB_Chinese.TabIndex = 0;
            this.LAB_Chinese.Text = "國文：";
            // 
            // LAB_English
            // 
            this.LAB_English.AutoSize = true;
            this.LAB_English.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_English.Location = new System.Drawing.Point(35, 215);
            this.LAB_English.Name = "LAB_English";
            this.LAB_English.Size = new System.Drawing.Size(72, 25);
            this.LAB_English.TabIndex = 0;
            this.LAB_English.Text = "英文：";
            // 
            // LAB_Math
            // 
            this.LAB_Math.AutoSize = true;
            this.LAB_Math.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Math.Location = new System.Drawing.Point(35, 282);
            this.LAB_Math.Name = "LAB_Math";
            this.LAB_Math.Size = new System.Drawing.Size(72, 25);
            this.LAB_Math.TabIndex = 0;
            this.LAB_Math.Text = "數學：";
            // 
            // TXT_Name
            // 
            this.TXT_Name.Location = new System.Drawing.Point(123, 92);
            this.TXT_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(112, 27);
            this.TXT_Name.TabIndex = 1;
            this.TXT_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_Chinese
            // 
            this.TXT_Chinese.Location = new System.Drawing.Point(123, 154);
            this.TXT_Chinese.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_Chinese.Name = "TXT_Chinese";
            this.TXT_Chinese.Size = new System.Drawing.Size(112, 27);
            this.TXT_Chinese.TabIndex = 1;
            this.TXT_Chinese.Text = "0";
            this.TXT_Chinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_English
            // 
            this.TXT_English.Location = new System.Drawing.Point(123, 215);
            this.TXT_English.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_English.Name = "TXT_English";
            this.TXT_English.Size = new System.Drawing.Size(112, 27);
            this.TXT_English.TabIndex = 1;
            this.TXT_English.Text = "0";
            this.TXT_English.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_Math
            // 
            this.TXT_Math.Location = new System.Drawing.Point(123, 282);
            this.TXT_Math.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_Math.Name = "TXT_Math";
            this.TXT_Math.Size = new System.Drawing.Size(112, 27);
            this.TXT_Math.TabIndex = 1;
            this.TXT_Math.Text = "0";
            this.TXT_Math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(27, 380);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(102, 47);
            this.BTN_Save.TabIndex = 2;
            this.BTN_Save.Text = "儲存";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Show
            // 
            this.BTN_Show.Location = new System.Drawing.Point(151, 380);
            this.BTN_Show.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_Show.Name = "BTN_Show";
            this.BTN_Show.Size = new System.Drawing.Size(123, 47);
            this.BTN_Show.TabIndex = 2;
            this.BTN_Show.Text = "顯示儲存內容";
            this.BTN_Show.UseVisualStyleBackColor = true;
            this.BTN_Show.Click += new System.EventHandler(this.BTN_Show_Click);
            // 
            // GB_Grade
            // 
            this.GB_Grade.Controls.Add(this.TXT_Show);
            this.GB_Grade.Controls.Add(this.LSB_Score);
            this.GB_Grade.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GB_Grade.Location = new System.Drawing.Point(295, 27);
            this.GB_Grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB_Grade.Name = "GB_Grade";
            this.GB_Grade.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB_Grade.Size = new System.Drawing.Size(358, 418);
            this.GB_Grade.TabIndex = 3;
            this.GB_Grade.TabStop = false;
            this.GB_Grade.Text = "成績";
            // 
            // TXT_Show
            // 
            this.TXT_Show.Location = new System.Drawing.Point(16, 233);
            this.TXT_Show.Multiline = true;
            this.TXT_Show.Name = "TXT_Show";
            this.TXT_Show.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_Show.Size = new System.Drawing.Size(331, 178);
            this.TXT_Show.TabIndex = 2;
            // 
            // LSB_Score
            // 
            this.LSB_Score.FormattingEnabled = true;
            this.LSB_Score.ItemHeight = 20;
            this.LSB_Score.Location = new System.Drawing.Point(16, 31);
            this.LSB_Score.Name = "LSB_Score";
            this.LSB_Score.Size = new System.Drawing.Size(331, 184);
            this.LSB_Score.TabIndex = 1;
            // 
            // BTN_EST
            // 
            this.BTN_EST.Location = new System.Drawing.Point(458, 466);
            this.BTN_EST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_EST.Name = "BTN_EST";
            this.BTN_EST.Size = new System.Drawing.Size(184, 47);
            this.BTN_EST.TabIndex = 2;
            this.BTN_EST.Text = "最高分/最低分項目";
            this.BTN_EST.UseVisualStyleBackColor = true;
            this.BTN_EST.Click += new System.EventHandler(this.BTN_EST_Click);
            // 
            // FRM_M04_StudentStructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 528);
            this.Controls.Add(this.GB_Grade);
            this.Controls.Add(this.BTN_EST);
            this.Controls.Add(this.BTN_Show);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.TXT_Math);
            this.Controls.Add(this.TXT_English);
            this.Controls.Add(this.TXT_Chinese);
            this.Controls.Add(this.TXT_Name);
            this.Controls.Add(this.LAB_Math);
            this.Controls.Add(this.LAB_English);
            this.Controls.Add(this.LAB_Chinese);
            this.Controls.Add(this.LAB_Name);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FRM_M04_StudentStructForm";
            this.Text = "FRM_M04_StudentStructForm";
            this.GB_Grade.ResumeLayout(false);
            this.GB_Grade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAB_Name;
        private System.Windows.Forms.Label LAB_Chinese;
        private System.Windows.Forms.Label LAB_English;
        private System.Windows.Forms.Label LAB_Math;
        private System.Windows.Forms.TextBox TXT_Name;
        private System.Windows.Forms.TextBox TXT_Chinese;
        private System.Windows.Forms.TextBox TXT_English;
        private System.Windows.Forms.TextBox TXT_Math;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Show;
        private System.Windows.Forms.GroupBox GB_Grade;
        private System.Windows.Forms.Button BTN_EST;
        private System.Windows.Forms.ListBox LSB_Score;
        private System.Windows.Forms.TextBox TXT_Show;
    }
}