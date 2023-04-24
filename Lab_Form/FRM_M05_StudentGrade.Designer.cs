namespace Lab_Form
{
    partial class FRM_M05_StudentGrade
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
            this.TXT_Math = new System.Windows.Forms.TextBox();
            this.TXT_English = new System.Windows.Forms.TextBox();
            this.TXT_Chinese = new System.Windows.Forms.TextBox();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.LAB_Math = new System.Windows.Forms.Label();
            this.LAB_English = new System.Windows.Forms.Label();
            this.LAB_Chinese = new System.Windows.Forms.Label();
            this.LAB_Name = new System.Windows.Forms.Label();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Rand = new System.Windows.Forms.Button();
            this.BTN_Total = new System.Windows.Forms.Button();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.BTN_Rand20 = new System.Windows.Forms.Button();
            this.LSV_Est = new System.Windows.Forms.ListView();
            this.LSV_Score = new System.Windows.Forms.ListView();
            this.姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.國文 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.英文 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.數學 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.總分 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.平均 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.最低 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.最高 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // TXT_Math
            // 
            this.TXT_Math.Location = new System.Drawing.Point(82, 174);
            this.TXT_Math.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Math.Name = "TXT_Math";
            this.TXT_Math.Size = new System.Drawing.Size(93, 25);
            this.TXT_Math.TabIndex = 6;
            this.TXT_Math.Text = "0";
            this.TXT_Math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_English
            // 
            this.TXT_English.Location = new System.Drawing.Point(82, 130);
            this.TXT_English.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_English.Name = "TXT_English";
            this.TXT_English.Size = new System.Drawing.Size(93, 25);
            this.TXT_English.TabIndex = 7;
            this.TXT_English.Text = "0";
            this.TXT_English.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_Chinese
            // 
            this.TXT_Chinese.Location = new System.Drawing.Point(82, 85);
            this.TXT_Chinese.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Chinese.Name = "TXT_Chinese";
            this.TXT_Chinese.Size = new System.Drawing.Size(93, 25);
            this.TXT_Chinese.TabIndex = 8;
            this.TXT_Chinese.Text = "0";
            this.TXT_Chinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_Name
            // 
            this.TXT_Name.Location = new System.Drawing.Point(82, 42);
            this.TXT_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(93, 25);
            this.TXT_Name.TabIndex = 9;
            this.TXT_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LAB_Math
            // 
            this.LAB_Math.AutoSize = true;
            this.LAB_Math.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Math.Location = new System.Drawing.Point(13, 174);
            this.LAB_Math.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_Math.Name = "LAB_Math";
            this.LAB_Math.Size = new System.Drawing.Size(72, 25);
            this.LAB_Math.TabIndex = 2;
            this.LAB_Math.Text = "數學：";
            // 
            // LAB_English
            // 
            this.LAB_English.AutoSize = true;
            this.LAB_English.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_English.Location = new System.Drawing.Point(13, 130);
            this.LAB_English.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_English.Name = "LAB_English";
            this.LAB_English.Size = new System.Drawing.Size(72, 25);
            this.LAB_English.TabIndex = 3;
            this.LAB_English.Text = "英文：";
            // 
            // LAB_Chinese
            // 
            this.LAB_Chinese.AutoSize = true;
            this.LAB_Chinese.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Chinese.Location = new System.Drawing.Point(13, 85);
            this.LAB_Chinese.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_Chinese.Name = "LAB_Chinese";
            this.LAB_Chinese.Size = new System.Drawing.Size(72, 25);
            this.LAB_Chinese.TabIndex = 4;
            this.LAB_Chinese.Text = "國文：";
            // 
            // LAB_Name
            // 
            this.LAB_Name.AutoSize = true;
            this.LAB_Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Name.Location = new System.Drawing.Point(13, 42);
            this.LAB_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_Name.Name = "LAB_Name";
            this.LAB_Name.Size = new System.Drawing.Size(72, 25);
            this.LAB_Name.TabIndex = 5;
            this.LAB_Name.Text = "姓名：";
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(18, 235);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(140, 29);
            this.BTN_Add.TabIndex = 10;
            this.BTN_Add.Text = "加入學生資料";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_Rand
            // 
            this.BTN_Rand.Location = new System.Drawing.Point(18, 285);
            this.BTN_Rand.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Rand.Name = "BTN_Rand";
            this.BTN_Rand.Size = new System.Drawing.Size(140, 29);
            this.BTN_Rand.TabIndex = 10;
            this.BTN_Rand.Text = "隨機儲存資料";
            this.BTN_Rand.UseVisualStyleBackColor = true;
            this.BTN_Rand.Click += new System.EventHandler(this.BTN_Rand_Click);
            // 
            // BTN_Total
            // 
            this.BTN_Total.Enabled = false;
            this.BTN_Total.Location = new System.Drawing.Point(18, 335);
            this.BTN_Total.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Total.Name = "BTN_Total";
            this.BTN_Total.Size = new System.Drawing.Size(140, 29);
            this.BTN_Total.TabIndex = 10;
            this.BTN_Total.Text = "各科統計";
            this.BTN_Total.UseVisualStyleBackColor = true;
            this.BTN_Total.Click += new System.EventHandler(this.BTN_Total_Click);
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.Location = new System.Drawing.Point(18, 456);
            this.BTN_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(140, 29);
            this.BTN_Reset.TabIndex = 10;
            this.BTN_Reset.Text = "重設所有資料";
            this.BTN_Reset.UseVisualStyleBackColor = true;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // BTN_Rand20
            // 
            this.BTN_Rand20.Location = new System.Drawing.Point(18, 505);
            this.BTN_Rand20.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Rand20.Name = "BTN_Rand20";
            this.BTN_Rand20.Size = new System.Drawing.Size(140, 29);
            this.BTN_Rand20.TabIndex = 10;
            this.BTN_Rand20.Text = "隨機加入20筆";
            this.BTN_Rand20.UseVisualStyleBackColor = true;
            this.BTN_Rand20.Click += new System.EventHandler(this.BTN_Rand20_Click);
            // 
            // LSV_Est
            // 
            this.LSV_Est.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LSV_Est.HideSelection = false;
            this.LSV_Est.Location = new System.Drawing.Point(192, 349);
            this.LSV_Est.Name = "LSV_Est";
            this.LSV_Est.Size = new System.Drawing.Size(655, 237);
            this.LSV_Est.TabIndex = 12;
            this.LSV_Est.UseCompatibleStateImageBehavior = false;
            this.LSV_Est.View = System.Windows.Forms.View.Details;
            // 
            // LSV_Score
            // 
            this.LSV_Score.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.姓名,
            this.國文,
            this.英文,
            this.數學,
            this.總分,
            this.平均,
            this.最低,
            this.最高});
            this.LSV_Score.HideSelection = false;
            this.LSV_Score.Location = new System.Drawing.Point(192, 34);
            this.LSV_Score.Name = "LSV_Score";
            this.LSV_Score.Size = new System.Drawing.Size(655, 280);
            this.LSV_Score.TabIndex = 13;
            this.LSV_Score.UseCompatibleStateImageBehavior = false;
            this.LSV_Score.View = System.Windows.Forms.View.Details;
            // 
            // 姓名
            // 
            this.姓名.Text = "姓名";
            // 
            // 國文
            // 
            this.國文.Text = "國文";
            // 
            // 英文
            // 
            this.英文.Text = "英文";
            // 
            // 數學
            // 
            this.數學.Text = "數學";
            // 
            // 總分
            // 
            this.總分.Text = "總分";
            // 
            // 平均
            // 
            this.平均.Text = "平均";
            // 
            // 最低
            // 
            this.最低.Text = "最高";
            // 
            // 最高
            // 
            this.最高.Text = "最低";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "項目";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "國文";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "英文";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "數學";
            // 
            // FRM_M05_StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 611);
            this.Controls.Add(this.LSV_Score);
            this.Controls.Add(this.LSV_Est);
            this.Controls.Add(this.BTN_Rand20);
            this.Controls.Add(this.BTN_Reset);
            this.Controls.Add(this.BTN_Total);
            this.Controls.Add(this.BTN_Rand);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.TXT_Math);
            this.Controls.Add(this.TXT_English);
            this.Controls.Add(this.TXT_Chinese);
            this.Controls.Add(this.TXT_Name);
            this.Controls.Add(this.LAB_Math);
            this.Controls.Add(this.LAB_English);
            this.Controls.Add(this.LAB_Chinese);
            this.Controls.Add(this.LAB_Name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_M05_StudentGrade";
            this.Text = "FRM_M05_StudentGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Math;
        private System.Windows.Forms.TextBox TXT_English;
        private System.Windows.Forms.TextBox TXT_Chinese;
        private System.Windows.Forms.TextBox TXT_Name;
        private System.Windows.Forms.Label LAB_Math;
        private System.Windows.Forms.Label LAB_English;
        private System.Windows.Forms.Label LAB_Chinese;
        private System.Windows.Forms.Label LAB_Name;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Rand;
        private System.Windows.Forms.Button BTN_Total;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.Button BTN_Rand20;
        private System.Windows.Forms.ListView LSV_Est;
        private System.Windows.Forms.ListView LSV_Score;
        public System.Windows.Forms.ColumnHeader 姓名;
        public System.Windows.Forms.ColumnHeader 國文;
        public System.Windows.Forms.ColumnHeader 英文;
        public System.Windows.Forms.ColumnHeader 數學;
        public System.Windows.Forms.ColumnHeader 總分;
        public System.Windows.Forms.ColumnHeader 平均;
        public System.Windows.Forms.ColumnHeader 最低;
        public System.Windows.Forms.ColumnHeader 最高;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}