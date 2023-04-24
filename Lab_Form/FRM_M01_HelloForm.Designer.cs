namespace Lab_Form
{
    partial class FRM_M01_HelloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_M01_HelloForm));
            this.BTN_HI = new System.Windows.Forms.Button();
            this.BTN_HELLO = new System.Windows.Forms.Button();
            this.LAB_NAME = new System.Windows.Forms.Label();
            this.LAB_ENGNAME = new System.Windows.Forms.Label();
            this.LAB_SEX = new System.Windows.Forms.Label();
            this.LAB_SIGN = new System.Windows.Forms.Label();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.TXT_ENGNAME = new System.Windows.Forms.TextBox();
            this.TXT_SEX = new System.Windows.Forms.TextBox();
            this.TXT_SIGN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_HI
            // 
            this.BTN_HI.Location = new System.Drawing.Point(223, 491);
            this.BTN_HI.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_HI.Name = "BTN_HI";
            this.BTN_HI.Size = new System.Drawing.Size(139, 31);
            this.BTN_HI.TabIndex = 0;
            this.BTN_HI.Text = "SAY HI~~";
            this.BTN_HI.UseVisualStyleBackColor = true;
            this.BTN_HI.Click += new System.EventHandler(this.BTN_HI_Click);
            // 
            // BTN_HELLO
            // 
            this.BTN_HELLO.Location = new System.Drawing.Point(223, 417);
            this.BTN_HELLO.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_HELLO.Name = "BTN_HELLO";
            this.BTN_HELLO.Size = new System.Drawing.Size(139, 31);
            this.BTN_HELLO.TabIndex = 1;
            this.BTN_HELLO.Text = "SAY HELLO!!";
            this.BTN_HELLO.UseVisualStyleBackColor = true;
            this.BTN_HELLO.Click += new System.EventHandler(this.BTN_HELLO_Click);
            // 
            // LAB_NAME
            // 
            this.LAB_NAME.AutoSize = true;
            this.LAB_NAME.Location = new System.Drawing.Point(168, 60);
            this.LAB_NAME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_NAME.Name = "LAB_NAME";
            this.LAB_NAME.Size = new System.Drawing.Size(54, 19);
            this.LAB_NAME.TabIndex = 2;
            this.LAB_NAME.Text = "姓名：";
            // 
            // LAB_ENGNAME
            // 
            this.LAB_ENGNAME.AutoSize = true;
            this.LAB_ENGNAME.Location = new System.Drawing.Point(168, 149);
            this.LAB_ENGNAME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_ENGNAME.Name = "LAB_ENGNAME";
            this.LAB_ENGNAME.Size = new System.Drawing.Size(122, 19);
            this.LAB_ENGNAME.TabIndex = 3;
            this.LAB_ENGNAME.Text = "English Name：";
            // 
            // LAB_SEX
            // 
            this.LAB_SEX.AutoSize = true;
            this.LAB_SEX.Location = new System.Drawing.Point(168, 240);
            this.LAB_SEX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_SEX.Name = "LAB_SEX";
            this.LAB_SEX.Size = new System.Drawing.Size(54, 19);
            this.LAB_SEX.TabIndex = 4;
            this.LAB_SEX.Text = "性別：";
            // 
            // LAB_SIGN
            // 
            this.LAB_SIGN.AutoSize = true;
            this.LAB_SIGN.Location = new System.Drawing.Point(168, 335);
            this.LAB_SIGN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_SIGN.Name = "LAB_SIGN";
            this.LAB_SIGN.Size = new System.Drawing.Size(54, 19);
            this.LAB_SIGN.TabIndex = 5;
            this.LAB_SIGN.Text = "星座：";
            this.LAB_SIGN.Click += new System.EventHandler(this.LAB_SIGN_Click);
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Location = new System.Drawing.Point(269, 56);
            this.TXT_NAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(116, 27);
            this.TXT_NAME.TabIndex = 6;
            // 
            // TXT_ENGNAME
            // 
            this.TXT_ENGNAME.Location = new System.Drawing.Point(270, 145);
            this.TXT_ENGNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ENGNAME.Name = "TXT_ENGNAME";
            this.TXT_ENGNAME.Size = new System.Drawing.Size(116, 27);
            this.TXT_ENGNAME.TabIndex = 7;
            // 
            // TXT_SEX
            // 
            this.TXT_SEX.Location = new System.Drawing.Point(270, 240);
            this.TXT_SEX.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SEX.Name = "TXT_SEX";
            this.TXT_SEX.Size = new System.Drawing.Size(116, 27);
            this.TXT_SEX.TabIndex = 8;
            // 
            // TXT_SIGN
            // 
            this.TXT_SIGN.Location = new System.Drawing.Point(269, 321);
            this.TXT_SIGN.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SIGN.Name = "TXT_SIGN";
            this.TXT_SIGN.Size = new System.Drawing.Size(116, 27);
            this.TXT_SIGN.TabIndex = 9;
            // 
            // FRM_M01_HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(387, 706);
            this.Controls.Add(this.TXT_SIGN);
            this.Controls.Add(this.TXT_SEX);
            this.Controls.Add(this.TXT_ENGNAME);
            this.Controls.Add(this.TXT_NAME);
            this.Controls.Add(this.LAB_SIGN);
            this.Controls.Add(this.LAB_SEX);
            this.Controls.Add(this.LAB_ENGNAME);
            this.Controls.Add(this.LAB_NAME);
            this.Controls.Add(this.BTN_HELLO);
            this.Controls.Add(this.BTN_HI);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_M01_HelloForm";
            this.Text = "FRM_HELLO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_HI;
        private System.Windows.Forms.Button BTN_HELLO;
        private System.Windows.Forms.Label LAB_NAME;
        private System.Windows.Forms.Label LAB_ENGNAME;
        private System.Windows.Forms.Label LAB_SEX;
        private System.Windows.Forms.Label LAB_SIGN;
        private System.Windows.Forms.TextBox TXT_NAME;
        private System.Windows.Forms.TextBox TXT_ENGNAME;
        private System.Windows.Forms.TextBox TXT_SEX;
        private System.Windows.Forms.TextBox TXT_SIGN;
    }
}

