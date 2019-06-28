namespace XO_Project
{
    partial class AboutForm
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
            this.AboutLbl = new System.Windows.Forms.Label();
            this.AboutPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutPnl
            // 
            this.AboutPnl.BackColor = System.Drawing.SystemColors.GrayText;
            this.AboutPnl.Controls.Add(this.ToMenuBtn);
            this.AboutPnl.Controls.Add(this.AboutLbl);
            this.AboutPnl.Location = new System.Drawing.Point(0, 0);
            this.AboutPnl.Name = "AboutPnl";
            this.AboutPnl.Size = new System.Drawing.Size(300, 300);
            this.AboutPnl.TabIndex = 5;
            // 
            // ToMenuBtn
            // 
            this.ToMenuBtn.Location = new System.Drawing.Point(84, 168);
            this.ToMenuBtn.Name = "ToMenuBtn";
            this.ToMenuBtn.Size = new System.Drawing.Size(132, 24);
            this.ToMenuBtn.TabIndex = 8;
            this.ToMenuBtn.Text = "Повернутися в меню";
            this.ToMenuBtn.UseVisualStyleBackColor = true;
            this.ToMenuBtn.Click += new System.EventHandler(this.ToMenuBtn_Click);
            // 
            // AboutLbl
            // 
            this.AboutLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AboutLbl.Location = new System.Drawing.Point(62, 70);
            this.AboutLbl.Name = "AboutLbl";
            this.AboutLbl.Size = new System.Drawing.Size(174, 85);
            this.AboutLbl.TabIndex = 6;
            this.AboutLbl.Text = "Гра Хрестики Нулики створена\r\nдля розвитку логічного мислення.\r\nРозробленна для у" +
    "досконалення \r\nнавичок тактики.";
            this.AboutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 300);
            this.Controls.Add(this.AboutPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AboutForm";
            this.Text = "Хрестики-Нулики";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AboutForm_FormClosed);
            this.AboutPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AboutPnl;
        private System.Windows.Forms.Button ToMenuBtn;
        private System.Windows.Forms.Label AboutLbl;
    }
}