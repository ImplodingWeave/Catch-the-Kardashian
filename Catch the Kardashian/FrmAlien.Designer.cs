namespace Catch_the_Kardashian
{
    partial class FrmAlien
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
            this.components = new System.ComponentModel.Container();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.TmrAlien = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.TmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Silver;
            this.PnlGame.Location = new System.Drawing.Point(10, 160);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(300, 300);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            this.PnlGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlGame_MouseDown);
            // 
            // TmrAlien
            // 
            this.TmrAlien.Tick += new System.EventHandler(this.TmrAlien_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Katch the Kardashian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score";
            // 
            // LblScore
            // 
            this.LblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblScore.Location = new System.Drawing.Point(360, 210);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(60, 30);
            this.LblScore.TabIndex = 3;
            this.LblScore.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStart,
            this.MnuQuit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuStart
            // 
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(43, 20);
            this.MnuStart.Text = "Start";
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // MnuQuit
            // 
            this.MnuQuit.Name = "MnuQuit";
            this.MnuQuit.Size = new System.Drawing.Size(42, 20);
            this.MnuQuit.Text = "Quit";
            this.MnuQuit.Click += new System.EventHandler(this.MnuQuit_Click);
            // 
            // TmrCountdown
            // 
            this.TmrCountdown.Enabled = true;
            this.TmrCountdown.Interval = 1000;
            this.TmrCountdown.Tick += new System.EventHandler(this.TmrCountdown_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time Left";
            // 
            // LblTime
            // 
            this.LblTime.BackColor = System.Drawing.Color.Gainsboro;
            this.LblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTime.Location = new System.Drawing.Point(13, 104);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(60, 30);
            this.LblTime.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(93, 134);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 8;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // FrmAlien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAlien";
            this.Text = "Catch the Alien";
            this.Load += new System.EventHandler(this.FrmAlien_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAlien_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrAlien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuStart;
        private System.Windows.Forms.ToolStripMenuItem MnuQuit;
        private System.Windows.Forms.Timer TmrCountdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtName;
    }
}

