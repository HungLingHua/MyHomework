namespace Lab_Form
{
    partial class FRM_M14_Guess
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
            this.LAB_String = new System.Windows.Forms.Label();
            this.BTN_Guess = new System.Windows.Forms.Button();
            this.BTN_Show = new System.Windows.Forms.Button();
            this.LAB_Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LAB_String
            // 
            this.LAB_String.AutoSize = true;
            this.LAB_String.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_String.Location = new System.Drawing.Point(74, 106);
            this.LAB_String.Name = "LAB_String";
            this.LAB_String.Size = new System.Drawing.Size(637, 38);
            this.LAB_String.TabIndex = 0;
            this.LAB_String.Text = "Please Select A Number Between 1 to 100!";
            // 
            // BTN_Guess
            // 
            this.BTN_Guess.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Guess.Location = new System.Drawing.Point(170, 246);
            this.BTN_Guess.Name = "BTN_Guess";
            this.BTN_Guess.Size = new System.Drawing.Size(147, 65);
            this.BTN_Guess.TabIndex = 1;
            this.BTN_Guess.Text = "Guess";
            this.BTN_Guess.UseVisualStyleBackColor = true;
            this.BTN_Guess.Click += new System.EventHandler(this.BTN_Guess_Click);
            // 
            // BTN_Show
            // 
            this.BTN_Show.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Show.Location = new System.Drawing.Point(358, 246);
            this.BTN_Show.Name = "BTN_Show";
            this.BTN_Show.Size = new System.Drawing.Size(259, 65);
            this.BTN_Show.TabIndex = 1;
            this.BTN_Show.Text = "Show Answer";
            this.BTN_Show.UseVisualStyleBackColor = true;
            this.BTN_Show.Click += new System.EventHandler(this.BTN_Show_Click);
            // 
            // LAB_Answer
            // 
            this.LAB_Answer.AutoSize = true;
            this.LAB_Answer.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_Answer.Location = new System.Drawing.Point(335, 53);
            this.LAB_Answer.Name = "LAB_Answer";
            this.LAB_Answer.Size = new System.Drawing.Size(53, 20);
            this.LAB_Answer.TabIndex = 2;
            this.LAB_Answer.Text = "label1";
            // 
            // FRM_M14_Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LAB_Answer);
            this.Controls.Add(this.BTN_Show);
            this.Controls.Add(this.BTN_Guess);
            this.Controls.Add(this.LAB_String);
            this.Name = "FRM_M14_Guess";
            this.Text = "FRM_M14_Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAB_String;
        private System.Windows.Forms.Button BTN_Guess;
        private System.Windows.Forms.Button BTN_Show;
        private System.Windows.Forms.Label LAB_Answer;
    }
}