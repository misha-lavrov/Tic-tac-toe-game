namespace XO_Project
{
    partial class InfoForm
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
            this.AboutPnl = new System.Windows.Forms.Panel();
            this.ToMenuBtn = new System.Windows.Forms.Button();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.AboutPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutPnl
            // 
            this.AboutPnl.BackColor = System.Drawing.SystemColors.GrayText;
            this.AboutPnl.Controls.Add(this.ToMenuBtn);
            this.AboutPnl.Controls.Add(this.InfoLbl);
            this.AboutPnl.Location = new System.Drawing.Point(2, 1);
            this.AboutPnl.Name = "AboutPnl";
            this.AboutPnl.Size = new System.Drawing.Size(300, 300);
            this.AboutPnl.TabIndex = 4;
            // 
            // ToMenuBtn
            // 
            this.ToMenuBtn.Location = new System.Drawing.Point(84, 171);
            this.ToMenuBtn.Name = "ToMenuBtn";
            this.ToMenuBtn.Size = new System.Drawing.Size(132, 24);
            this.ToMenuBtn.TabIndex = 8;
            this.ToMenuBtn.Text = "Повернутися в меню";
            this.ToMenuBtn.UseVisualStyleBackColor = true;
            this.ToMenuBtn.Click += new System.EventHandler(this.ToMenuBtn_Click);
            // 
            // InfoLbl
            // 
            this.InfoLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoLbl.Location = new System.Drawing.Point(63, 70);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(174, 86);
            this.InfoLbl.TabIndex = 7;
            this.InfoLbl.Text = "Програма розроблена \r\nстуденткою групи 2ІСТ-17Б\r\nЗа допомогою середовища \r\nVisual" +
    " Studio 2017\r\nНа мові C#";
            this.InfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 303);
            this.Controls.Add(this.AboutPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "InfoForm";
            this.Text = "Хрестики-Нулики";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoForm_FormClosed);
            this.AboutPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AboutPnl;
        private System.Windows.Forms.Button ToMenuBtn;
        private System.Windows.Forms.Label InfoLbl;
    }
}