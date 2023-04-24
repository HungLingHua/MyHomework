namespace Lab_Form
{
    partial class FRM_貸款金額計算
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
            this.LB_貸款金額 = new System.Windows.Forms.Label();
            this.LB_期限 = new System.Windows.Forms.Label();
            this.LB_利率 = new System.Windows.Forms.Label();
            this.LB_頭期款 = new System.Windows.Forms.Label();
            this.TXT_dai = new System.Windows.Forms.TextBox();
            this.TXT_qi = new System.Windows.Forms.TextBox();
            this.TXT_li = new System.Windows.Forms.TextBox();
            this.TXT_to = new System.Windows.Forms.TextBox();
            this.BTN_月付 = new System.Windows.Forms.Button();
            this.BTN_總付款 = new System.Windows.Forms.Button();
            this.BTN_REPORT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_貸款金額
            // 
            this.LB_貸款金額.AutoSize = true;
            this.LB_貸款金額.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_貸款金額.Location = new System.Drawing.Point(85, 69);
            this.LB_貸款金額.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_貸款金額.Name = "LB_貸款金額";
            this.LB_貸款金額.Size = new System.Drawing.Size(177, 40);
            this.LB_貸款金額.TabIndex = 0;
            this.LB_貸款金額.Text = "貸款金額";
            // 
            // LB_期限
            // 
            this.LB_期限.AutoSize = true;
            this.LB_期限.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_期限.Location = new System.Drawing.Point(90, 150);
            this.LB_期限.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_期限.Name = "LB_期限";
            this.LB_期限.Size = new System.Drawing.Size(163, 40);
            this.LB_期限.TabIndex = 0;
            this.LB_期限.Text = "期限(年)";
            // 
            // LB_利率
            // 
            this.LB_利率.AutoSize = true;
            this.LB_利率.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_利率.Location = new System.Drawing.Point(90, 242);
            this.LB_利率.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_利率.Name = "LB_利率";
            this.LB_利率.Size = new System.Drawing.Size(154, 40);
            this.LB_利率.TabIndex = 0;
            this.LB_利率.Text = "利率(%)";
            // 
            // LB_頭期款
            // 
            this.LB_頭期款.AutoSize = true;
            this.LB_頭期款.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_頭期款.Location = new System.Drawing.Point(90, 338);
            this.LB_頭期款.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_頭期款.Name = "LB_頭期款";
            this.LB_頭期款.Size = new System.Drawing.Size(137, 40);
            this.LB_頭期款.TabIndex = 0;
            this.LB_頭期款.Text = "頭期款";
            // 
            // TXT_dai
            // 
            this.TXT_dai.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXT_dai.Location = new System.Drawing.Point(318, 69);
            this.TXT_dai.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_dai.Name = "TXT_dai";
            this.TXT_dai.Size = new System.Drawing.Size(240, 43);
            this.TXT_dai.TabIndex = 1;
            this.TXT_dai.Text = "100000";
            // 
            // TXT_qi
            // 
            this.TXT_qi.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXT_qi.Location = new System.Drawing.Point(318, 150);
            this.TXT_qi.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_qi.Name = "TXT_qi";
            this.TXT_qi.Size = new System.Drawing.Size(240, 43);
            this.TXT_qi.TabIndex = 1;
            this.TXT_qi.Text = "2";
            // 
            // TXT_li
            // 
            this.TXT_li.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXT_li.Location = new System.Drawing.Point(318, 236);
            this.TXT_li.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_li.Name = "TXT_li";
            this.TXT_li.Size = new System.Drawing.Size(240, 43);
            this.TXT_li.TabIndex = 1;
            this.TXT_li.Text = "10";
            // 
            // TXT_to
            // 
            this.TXT_to.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXT_to.Location = new System.Drawing.Point(318, 333);
            this.TXT_to.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_to.Name = "TXT_to";
            this.TXT_to.Size = new System.Drawing.Size(240, 43);
            this.TXT_to.TabIndex = 1;
            this.TXT_to.Text = "0";
            // 
            // BTN_月付
            // 
            this.BTN_月付.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_月付.Location = new System.Drawing.Point(92, 429);
            this.BTN_月付.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_月付.Name = "BTN_月付";
            this.BTN_月付.Size = new System.Drawing.Size(161, 60);
            this.BTN_月付.TabIndex = 2;
            this.BTN_月付.Text = "PMT(月付)";
            this.BTN_月付.UseVisualStyleBackColor = true;
            this.BTN_月付.Click += new System.EventHandler(this.BTN_月付_Click);
            // 
            // BTN_總付款
            // 
            this.BTN_總付款.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_總付款.Location = new System.Drawing.Point(288, 429);
            this.BTN_總付款.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_總付款.Name = "BTN_總付款";
            this.BTN_總付款.Size = new System.Drawing.Size(129, 60);
            this.BTN_總付款.TabIndex = 2;
            this.BTN_總付款.Text = "總付款";
            this.BTN_總付款.UseVisualStyleBackColor = true;
            this.BTN_總付款.Click += new System.EventHandler(this.BTN_總付款_Click);
            // 
            // BTN_REPORT
            // 
            this.BTN_REPORT.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_REPORT.Location = new System.Drawing.Point(450, 429);
            this.BTN_REPORT.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_REPORT.Name = "BTN_REPORT";
            this.BTN_REPORT.Size = new System.Drawing.Size(129, 60);
            this.BTN_REPORT.TabIndex = 2;
            this.BTN_REPORT.Text = "Report";
            this.BTN_REPORT.UseVisualStyleBackColor = true;
            this.BTN_REPORT.Click += new System.EventHandler(this.BTN_REPORT_Click);
            // 
            // FRM_貸款金額計算
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 550);
            this.Controls.Add(this.BTN_REPORT);
            this.Controls.Add(this.BTN_總付款);
            this.Controls.Add(this.BTN_月付);
            this.Controls.Add(this.TXT_to);
            this.Controls.Add(this.TXT_li);
            this.Controls.Add(this.TXT_qi);
            this.Controls.Add(this.TXT_dai);
            this.Controls.Add(this.LB_頭期款);
            this.Controls.Add(this.LB_利率);
            this.Controls.Add(this.LB_期限);
            this.Controls.Add(this.LB_貸款金額);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_貸款金額計算";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_貸款金額;
        private System.Windows.Forms.Label LB_期限;
        private System.Windows.Forms.Label LB_利率;
        private System.Windows.Forms.Label LB_頭期款;
        private System.Windows.Forms.TextBox TXT_dai;
        private System.Windows.Forms.TextBox TXT_qi;
        private System.Windows.Forms.TextBox TXT_li;
        private System.Windows.Forms.TextBox TXT_to;
        private System.Windows.Forms.Button BTN_月付;
        private System.Windows.Forms.Button BTN_總付款;
        private System.Windows.Forms.Button BTN_REPORT;
    }
}