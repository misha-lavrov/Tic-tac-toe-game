namespace XO_Project
{
    partial class GameForm
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
            this.GamePnl = new System.Windows.Forms.Panel();
            this.ToMenuBtn = new System.Windows.Forms.Button();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.WinnerLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GamePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // GamePnl
            // 
            this.GamePnl.BackColor = System.Drawing.SystemColors.GrayText;
            this.GamePnl.Controls.Add(this.ToMenuBtn);
            this.GamePnl.Controls.Add(this.RestartBtn);
            this.GamePnl.Controls.Add(this.WinnerLbl);
            this.GamePnl.Controls.Add(this.panel4);
            this.GamePnl.Controls.Add(this.panel3);
            this.GamePnl.Controls.Add(this.panel2);
            this.GamePnl.Controls.Add(this.panel1);
            this.GamePnl.Location = new System.Drawing.Point(0, 0);
            this.GamePnl.Name = "GamePnl";
            this.GamePnl.Size = new System.Drawing.Size(300, 300);
            this.GamePnl.TabIndex = 11;
            // 
            // ToMenuBtn
            // 
            this.ToMenuBtn.Location = new System.Drawing.Point(84, 180);
            this.ToMenuBtn.Name = "ToMenuBtn";
            this.ToMenuBtn.Size = new System.Drawing.Size(132, 24);
            this.ToMenuBtn.TabIndex = 17;
            this.ToMenuBtn.Text = "Повернутися в меню";
            this.ToMenuBtn.UseVisualStyleBackColor = true;
            this.ToMenuBtn.Visible = false;
            this.ToMenuBtn.Click += new System.EventHandler(this.ToMenuBtn_Click);
            // 
            // RestartBtn
            // 
            this.RestartBtn.Location = new System.Drawing.Point(84, 143);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(132, 24);
            this.RestartBtn.TabIndex = 16;
            this.RestartBtn.Text = "Нова гра";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.Visible = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // WinnerLbl
            // 
            this.WinnerLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WinnerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinnerLbl.Location = new System.Drawing.Point(75, 79);
            this.WinnerLbl.Name = "WinnerLbl";
            this.WinnerLbl.Size = new System.Drawing.Size(150, 50);
            this.WinnerLbl.TabIndex = 15;
            this.WinnerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WinnerLbl.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(0, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 10);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(0, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 10);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(195, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 300);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(95, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 300);
            this.panel1.TabIndex = 11;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.GamePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "GameForm";
            this.Text = "Хрестики-Нулики";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.GamePnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel GamePnl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ToMenuBtn;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Label WinnerLbl;
    }
}