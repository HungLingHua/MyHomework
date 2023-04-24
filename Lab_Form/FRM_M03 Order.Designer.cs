namespace Lab_Form
{
    partial class FRM_M03_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_M03_Order));
            this.GB_MENU = new System.Windows.Forms.GroupBox();
            this.BTN_Wine = new System.Windows.Forms.Button();
            this.BTN_Whisky = new System.Windows.Forms.Button();
            this.BTN_Tequila = new System.Windows.Forms.Button();
            this.BTN_Beer = new System.Windows.Forms.Button();
            this.GB_Pay = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_CDC = new System.Windows.Forms.Button();
            this.BTN_Cash = new System.Windows.Forms.Button();
            this.GB_List = new System.Windows.Forms.GroupBox();
            this.LAB_List = new System.Windows.Forms.Label();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.GB_Price = new System.Windows.Forms.GroupBox();
            this.LAB_Price = new System.Windows.Forms.Label();
            this.GB_MENU.SuspendLayout();
            this.GB_Pay.SuspendLayout();
            this.GB_List.SuspendLayout();
            this.GB_Price.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_MENU
            // 
            this.GB_MENU.Controls.Add(this.BTN_Wine);
            this.GB_MENU.Controls.Add(this.BTN_Whisky);
            this.GB_MENU.Controls.Add(this.BTN_Tequila);
            this.GB_MENU.Controls.Add(this.BTN_Beer);
            this.GB_MENU.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GB_MENU.Location = new System.Drawing.Point(13, 47);
            this.GB_MENU.Margin = new System.Windows.Forms.Padding(4);
            this.GB_MENU.Name = "GB_MENU";
            this.GB_MENU.Padding = new System.Windows.Forms.Padding(4);
            this.GB_MENU.Size = new System.Drawing.Size(360, 455);
            this.GB_MENU.TabIndex = 0;
            this.GB_MENU.TabStop = false;
            this.GB_MENU.Text = "菜單 Menu";
            // 
            // BTN_Wine
            // 
            this.BTN_Wine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Wine.BackgroundImage")));
            this.BTN_Wine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Wine.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Wine.Location = new System.Drawing.Point(184, 255);
            this.BTN_Wine.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Wine.Name = "BTN_Wine";
            this.BTN_Wine.Size = new System.Drawing.Size(156, 182);
            this.BTN_Wine.TabIndex = 0;
            this.BTN_Wine.Text = "紅酒\r\nWine\r\nNT320";
            this.BTN_Wine.UseVisualStyleBackColor = true;
            this.BTN_Wine.Click += new System.EventHandler(this.BTN_Wine_Click);
            // 
            // BTN_Whisky
            // 
            this.BTN_Whisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Whisky.BackgroundImage")));
            this.BTN_Whisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Whisky.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Whisky.Location = new System.Drawing.Point(20, 255);
            this.BTN_Whisky.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Whisky.Name = "BTN_Whisky";
            this.BTN_Whisky.Size = new System.Drawing.Size(156, 182);
            this.BTN_Whisky.TabIndex = 0;
            this.BTN_Whisky.Text = "威士忌\r\nWhisky\r\nNT350";
            this.BTN_Whisky.UseVisualStyleBackColor = true;
            this.BTN_Whisky.Click += new System.EventHandler(this.BTN_Whisky_Click);
            // 
            // BTN_Tequila
            // 
            this.BTN_Tequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Tequila.BackgroundImage")));
            this.BTN_Tequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Tequila.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Tequila.Location = new System.Drawing.Point(184, 65);
            this.BTN_Tequila.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Tequila.Name = "BTN_Tequila";
            this.BTN_Tequila.Size = new System.Drawing.Size(156, 182);
            this.BTN_Tequila.TabIndex = 0;
            this.BTN_Tequila.Text = "龍舌蘭\r\nTequila\r\nNT180";
            this.BTN_Tequila.UseVisualStyleBackColor = true;
            this.BTN_Tequila.Click += new System.EventHandler(this.BTN_Tequila_Click);
            // 
            // BTN_Beer
            // 
            this.BTN_Beer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Beer.BackgroundImage")));
            this.BTN_Beer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Beer.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Beer.Location = new System.Drawing.Point(20, 65);
            this.BTN_Beer.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Beer.Name = "BTN_Beer";
            this.BTN_Beer.Size = new System.Drawing.Size(156, 182);
            this.BTN_Beer.TabIndex = 0;
            this.BTN_Beer.Text = "啤酒\r\nBeer\r\nNT120";
            this.BTN_Beer.UseVisualStyleBackColor = true;
            this.BTN_Beer.Click += new System.EventHandler(this.BTN_Beer_Click);
            // 
            // GB_Pay
            // 
            this.GB_Pay.Controls.Add(this.label1);
            this.GB_Pay.Controls.Add(this.BTN_CDC);
            this.GB_Pay.Controls.Add(this.BTN_Cash);
            this.GB_Pay.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.GB_Pay.Location = new System.Drawing.Point(381, 312);
            this.GB_Pay.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Pay.Name = "GB_Pay";
            this.GB_Pay.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Pay.Size = new System.Drawing.Size(251, 172);
            this.GB_Pay.TabIndex = 1;
            this.GB_Pay.TabStop = false;
            this.GB_Pay.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(106, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "信用卡享九折";
            // 
            // BTN_CDC
            // 
            this.BTN_CDC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_CDC.Location = new System.Drawing.Point(125, 57);
            this.BTN_CDC.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_CDC.Name = "BTN_CDC";
            this.BTN_CDC.Size = new System.Drawing.Size(107, 48);
            this.BTN_CDC.TabIndex = 0;
            this.BTN_CDC.Text = "信用卡";
            this.BTN_CDC.UseVisualStyleBackColor = true;
            this.BTN_CDC.Click += new System.EventHandler(this.BTN_CDC_Click);
            // 
            // BTN_Cash
            // 
            this.BTN_Cash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Cash.Location = new System.Drawing.Point(19, 57);
            this.BTN_Cash.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Cash.Name = "BTN_Cash";
            this.BTN_Cash.Size = new System.Drawing.Size(86, 48);
            this.BTN_Cash.TabIndex = 0;
            this.BTN_Cash.Text = "現金";
            this.BTN_Cash.UseVisualStyleBackColor = true;
            this.BTN_Cash.Click += new System.EventHandler(this.BTN_Cash_Click);
            // 
            // GB_List
            // 
            this.GB_List.Controls.Add(this.LAB_List);
            this.GB_List.Controls.Add(this.BTN_Delete);
            this.GB_List.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.GB_List.Location = new System.Drawing.Point(650, 68);
            this.GB_List.Margin = new System.Windows.Forms.Padding(4);
            this.GB_List.Name = "GB_List";
            this.GB_List.Padding = new System.Windows.Forms.Padding(4);
            this.GB_List.Size = new System.Drawing.Size(320, 434);
            this.GB_List.TabIndex = 2;
            this.GB_List.TabStop = false;
            this.GB_List.Text = "購物清單List";
            // 
            // LAB_List
            // 
            this.LAB_List.AutoSize = true;
            this.LAB_List.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LAB_List.Image = ((System.Drawing.Image)(resources.GetObject("LAB_List.Image")));
            this.LAB_List.Location = new System.Drawing.Point(23, 84);
            this.LAB_List.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_List.Name = "LAB_List";
            this.LAB_List.Size = new System.Drawing.Size(0, 25);
            this.LAB_List.TabIndex = 0;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Delete.Location = new System.Drawing.Point(84, 367);
            this.BTN_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(109, 49);
            this.BTN_Delete.TabIndex = 0;
            this.BTN_Delete.Text = "清除清單";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // GB_Price
            // 
            this.GB_Price.Controls.Add(this.LAB_Price);
            this.GB_Price.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.GB_Price.Location = new System.Drawing.Point(381, 68);
            this.GB_Price.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Price.Name = "GB_Price";
            this.GB_Price.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Price.Size = new System.Drawing.Size(251, 212);
            this.GB_Price.TabIndex = 3;
            this.GB_Price.TabStop = false;
            this.GB_Price.Text = "總金額 Total Price";
            // 
            // LAB_Price
            // 
            this.LAB_Price.AutoSize = true;
            this.LAB_Price.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LAB_Price.ForeColor = System.Drawing.Color.White;
            this.LAB_Price.Location = new System.Drawing.Point(41, 84);
            this.LAB_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_Price.Name = "LAB_Price";
            this.LAB_Price.Size = new System.Drawing.Size(84, 34);
            this.LAB_Price.TabIndex = 0;
            this.LAB_Price.Text = "NT$0";
            // 
            // FRM_M03_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 531);
            this.Controls.Add(this.GB_Price);
            this.Controls.Add(this.GB_List);
            this.Controls.Add(this.GB_Pay);
            this.Controls.Add(this.GB_MENU);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_M03_Order";
            this.Text = "FRM_M03_Order";
            this.GB_MENU.ResumeLayout(false);
            this.GB_Pay.ResumeLayout(false);
            this.GB_Pay.PerformLayout();
            this.GB_List.ResumeLayout(false);
            this.GB_List.PerformLayout();
            this.GB_Price.ResumeLayout(false);
            this.GB_Price.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_MENU;
        private System.Windows.Forms.Button BTN_Beer;
        private System.Windows.Forms.Button BTN_Wine;
        private System.Windows.Forms.Button BTN_Whisky;
        private System.Windows.Forms.Button BTN_Tequila;
        private System.Windows.Forms.GroupBox GB_Pay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_CDC;
        private System.Windows.Forms.Button BTN_Cash;
        private System.Windows.Forms.GroupBox GB_List;
        private System.Windows.Forms.Label LAB_List;
        private System.Windows.Forms.GroupBox GB_Price;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Label LAB_Price;
    }
}