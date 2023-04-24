namespace Lab_Form
{
    partial class FRM_M07_Clac
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
            this.LAB_Num1 = new System.Windows.Forms.Label();
            this.LAB_Num2 = new System.Windows.Forms.Label();
            this.TXT_Num1 = new System.Windows.Forms.TextBox();
            this.TXT_Num2 = new System.Windows.Forms.TextBox();
            this.BTN_Plus = new System.Windows.Forms.Button();
            this.BTN_Subtract = new System.Windows.Forms.Button();
            this.BTN_Multiply = new System.Windows.Forms.Button();
            this.BTN_Divided = new System.Windows.Forms.Button();
            this.LAB_Answer = new System.Windows.Forms.Label();
            this.TXT_Answer = new System.Windows.Forms.TextBox();
            this.line = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LAB_Num1
            // 
            this.LAB_Num1.AutoSize = true;
            this.LAB_Num1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Num1.Location = new System.Drawing.Point(77, 91);
            this.LAB_Num1.Name = "LAB_Num1";
            this.LAB_Num1.Size = new System.Drawing.Size(80, 29);
            this.LAB_Num1.TabIndex = 0;
            this.LAB_Num1.Text = "Num1";
            // 
            // LAB_Num2
            // 
            this.LAB_Num2.AutoSize = true;
            this.LAB_Num2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Num2.Location = new System.Drawing.Point(77, 159);
            this.LAB_Num2.Name = "LAB_Num2";
            this.LAB_Num2.Size = new System.Drawing.Size(80, 29);
            this.LAB_Num2.TabIndex = 0;
            this.LAB_Num2.Text = "Num2";
            // 
            // TXT_Num1
            // 
            this.TXT_Num1.AllowDrop = true;
            this.TXT_Num1.Location = new System.Drawing.Point(171, 93);
            this.TXT_Num1.Name = "TXT_Num1";
            this.TXT_Num1.Size = new System.Drawing.Size(94, 25);
            this.TXT_Num1.TabIndex = 1;
            // 
            // TXT_Num2
            // 
            this.TXT_Num2.AllowDrop = true;
            this.TXT_Num2.Location = new System.Drawing.Point(171, 159);
            this.TXT_Num2.Name = "TXT_Num2";
            this.TXT_Num2.Size = new System.Drawing.Size(94, 25);
            this.TXT_Num2.TabIndex = 1;
            // 
            // BTN_Plus
            // 
            this.BTN_Plus.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Plus.Location = new System.Drawing.Point(311, 64);
            this.BTN_Plus.Name = "BTN_Plus";
            this.BTN_Plus.Size = new System.Drawing.Size(55, 54);
            this.BTN_Plus.TabIndex = 2;
            this.BTN_Plus.Text = "+";
            this.BTN_Plus.UseVisualStyleBackColor = true;
            this.BTN_Plus.Click += new System.EventHandler(this.BTN_Plus_Click);
            // 
            // BTN_Subtract
            // 
            this.BTN_Subtract.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Subtract.Location = new System.Drawing.Point(396, 64);
            this.BTN_Subtract.Name = "BTN_Subtract";
            this.BTN_Subtract.Size = new System.Drawing.Size(55, 54);
            this.BTN_Subtract.TabIndex = 2;
            this.BTN_Subtract.Text = "-";
            this.BTN_Subtract.UseVisualStyleBackColor = true;
            this.BTN_Subtract.Click += new System.EventHandler(this.BTN_Subtract_Click);
            // 
            // BTN_Multiply
            // 
            this.BTN_Multiply.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Multiply.Location = new System.Drawing.Point(311, 134);
            this.BTN_Multiply.Name = "BTN_Multiply";
            this.BTN_Multiply.Size = new System.Drawing.Size(55, 54);
            this.BTN_Multiply.TabIndex = 2;
            this.BTN_Multiply.Text = "×";
            this.BTN_Multiply.UseVisualStyleBackColor = true;
            this.BTN_Multiply.Click += new System.EventHandler(this.BTN_Multiply_Click);
            // 
            // BTN_Divided
            // 
            this.BTN_Divided.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Divided.Location = new System.Drawing.Point(396, 134);
            this.BTN_Divided.Name = "BTN_Divided";
            this.BTN_Divided.Size = new System.Drawing.Size(55, 54);
            this.BTN_Divided.TabIndex = 2;
            this.BTN_Divided.Text = "÷";
            this.BTN_Divided.UseVisualStyleBackColor = true;
            this.BTN_Divided.Click += new System.EventHandler(this.BTN_Divided_Click);
            // 
            // LAB_Answer
            // 
            this.LAB_Answer.AutoSize = true;
            this.LAB_Answer.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Answer.Location = new System.Drawing.Point(77, 264);
            this.LAB_Answer.Name = "LAB_Answer";
            this.LAB_Answer.Size = new System.Drawing.Size(93, 29);
            this.LAB_Answer.TabIndex = 0;
            this.LAB_Answer.Text = "Answer";
            // 
            // TXT_Answer
            // 
            this.TXT_Answer.AllowDrop = true;
            this.TXT_Answer.Location = new System.Drawing.Point(171, 264);
            this.TXT_Answer.Name = "TXT_Answer";
            this.TXT_Answer.Size = new System.Drawing.Size(94, 25);
            this.TXT_Answer.TabIndex = 1;
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.line.Location = new System.Drawing.Point(37, 205);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(472, 29);
            this.line.TabIndex = 0;
            this.line.Text = "===========================";
            // 
            // FRM_M07_Clac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 366);
            this.Controls.Add(this.BTN_Divided);
            this.Controls.Add(this.BTN_Multiply);
            this.Controls.Add(this.BTN_Subtract);
            this.Controls.Add(this.BTN_Plus);
            this.Controls.Add(this.TXT_Answer);
            this.Controls.Add(this.TXT_Num2);
            this.Controls.Add(this.TXT_Num1);
            this.Controls.Add(this.LAB_Answer);
            this.Controls.Add(this.line);
            this.Controls.Add(this.LAB_Num2);
            this.Controls.Add(this.LAB_Num1);
            this.Name = "FRM_M07_Clac";
            this.Text = "FRM_M07_Clac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAB_Num1;
        private System.Windows.Forms.Label LAB_Num2;
        private System.Windows.Forms.TextBox TXT_Num1;
        private System.Windows.Forms.TextBox TXT_Num2;
        private System.Windows.Forms.Button BTN_Plus;
        private System.Windows.Forms.Button BTN_Subtract;
        private System.Windows.Forms.Button BTN_Multiply;
        private System.Windows.Forms.Button BTN_Divided;
        private System.Windows.Forms.Label LAB_Answer;
        private System.Windows.Forms.TextBox TXT_Answer;
        private System.Windows.Forms.Label line;
    }
}