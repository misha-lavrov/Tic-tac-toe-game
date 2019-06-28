namespace XO_Project
{
    partial class MenuForm
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
            this.MenuPnl = new System.Windows.Forms.Panel();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.MenuLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.MenuPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPnl
            // 
            this.MenuPnl.BackColor = System.Drawing.SystemColors.GrayText;
            this.MenuPnl.Controls.Add(this.InfoBtn);
            this.MenuPnl.Controls.Add(this.AboutBtn);
            this.MenuPnl.Controls.Add(this.MenuLbl);
            this.MenuPnl.Controls.Add(this.ExitBtn);
            this.MenuPnl.Controls.Add(this.StartBtn);
            this.MenuPnl.Location = new System.Drawing.Point(1, 0);
            this.MenuPnl.Name = "MenuPnl";
            this.MenuPnl.Size = new System.Drawing.Size(300, 300);
            this.MenuPnl.TabIndex = 5;
            // 
            // InfoBtn
            // 
            this.InfoBtn.Location = new System.Drawing.Point(82, 164);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(117, 34);
            this.InfoBtn.TabIndex = 4;
            this.InfoBtn.Text = "Інфо\r\n";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.Location = new System.Drawing.Point(82, 110);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(117, 34);
            this.AboutBtn.TabIndex = 3;
            this.AboutBtn.Text = "Про гру";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // MenuLbl
            // 
            this.MenuLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuLbl.Location = new System.Drawing.Point(70, 19);
            this.MenuLbl.Name = "MenuLbl";
            this.MenuLbl.Size = new System.Drawing.Size(142, 26);
            this.MenuLbl.TabIndex = 2;
            this.MenuLbl.Text = "Головне меню";
            this.MenuLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(82, 215);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(117, 34);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Вихід";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(82, 61);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(117, 34);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Старт Гри ";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 299);
            this.Controls.Add(this.MenuPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "MenuForm";
            this.Text = "Хрестики-Нулики";
            this.MenuPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPnl;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Label MenuLbl;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button StartBtn;
    }
}