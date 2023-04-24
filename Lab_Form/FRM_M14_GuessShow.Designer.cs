namespace Lab_Form
{
    partial class FRM_M14_GuessShow
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
            this.LAB_Input = new System.Windows.Forms.Label();
            this.TXT_Number = new System.Windows.Forms.TextBox();
            this.BTN_Enter = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAB_Input
            // 
            this.LAB_Input.AutoSize = true;
            this.LAB_Input.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Input.Location = new System.Drawing.Point(57, 71);
            this.LAB_Input.Name = "LAB_Input";
            this.LAB_Input.Size = new System.Drawing.Size(350, 38);
            this.LAB_Input.TabIndex = 0;
            this.LAB_Input.Text = "Please input a number.";
            // 
            // TXT_Number
            // 
            this.TXT_Number.Location = new System.Drawing.Point(40, 162);
            this.TXT_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_Number.Name = "TXT_Number";
            this.TXT_Number.Size = new System.Drawing.Size(499, 25);
            this.TXT_Number.TabIndex = 1;
            // 
            // BTN_Enter
            // 
            this.BTN_Enter.Location = new System.Drawing.Point(428, 38);
            this.BTN_Enter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Enter.Name = "BTN_Enter";
            this.BTN_Enter.Size = new System.Drawing.Size(111, 42);
            this.BTN_Enter.TabIndex = 2;
            this.BTN_Enter.Text = "Enter";
            this.BTN_Enter.UseVisualStyleBackColor = true;
            this.BTN_Enter.Click += new System.EventHandler(this.BTN_Enter_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(428, 98);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(111, 42);
            this.BTN_Cancel.TabIndex = 2;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // FRM_M14_GuessShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 209);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Enter);
            this.Controls.Add(this.TXT_Number);
            this.Controls.Add(this.LAB_Input);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRM_M14_GuessShow";
            this.Text = "Guess";
            this.Load += new System.EventHandler(this.FRM_M14_GuessShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAB_Input;
        private System.Windows.Forms.TextBox TXT_Number;
        private System.Windows.Forms.Button BTN_Enter;
        private System.Windows.Forms.Button BTN_Cancel;
    }
}