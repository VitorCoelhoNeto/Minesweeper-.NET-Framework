namespace Minesweeper
{
    partial class Facil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facil));
            this.pictureBoxGameButton = new System.Windows.Forms.PictureBox();
            this.menuStripFacil = new System.Windows.Forms.MenuStrip();
            this.leaderboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerFacil = new System.Windows.Forms.Timer(this.components);
            this.labelMinasFacil = new System.Windows.Forms.Label();
            this.labelTempoFacil = new System.Windows.Forms.Label();
            this.labelTimerFacil = new System.Windows.Forms.Label();
            this.labelNumMinasFacil = new System.Windows.Forms.Label();
            this.pictureBoxSound = new System.Windows.Forms.PictureBox();
            this.panelFacil = new System.Windows.Forms.Panel();
            this.labelUserFacil = new System.Windows.Forms.Label();
            this.labelUserFF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameButton)).BeginInit();
            this.menuStripFacil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGameButton
            // 
            this.pictureBoxGameButton.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGameButton.Image")));
            this.pictureBoxGameButton.Location = new System.Drawing.Point(183, 27);
            this.pictureBoxGameButton.Name = "pictureBoxGameButton";
            this.pictureBoxGameButton.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxGameButton.TabIndex = 163;
            this.pictureBoxGameButton.TabStop = false;
            this.pictureBoxGameButton.Click += new System.EventHandler(this.pictureBoxGameButton_Click_1);
            // 
            // menuStripFacil
            // 
            this.menuStripFacil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leaderboardsToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStripFacil.Location = new System.Drawing.Point(0, 0);
            this.menuStripFacil.Name = "menuStripFacil";
            this.menuStripFacil.Size = new System.Drawing.Size(394, 24);
            this.menuStripFacil.TabIndex = 164;
            this.menuStripFacil.Text = "menuStrip1";
            // 
            // leaderboardsToolStripMenuItem
            // 
            this.leaderboardsToolStripMenuItem.Name = "leaderboardsToolStripMenuItem";
            this.leaderboardsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.leaderboardsToolStripMenuItem.Text = "Ajuda";
            this.leaderboardsToolStripMenuItem.Click += new System.EventHandler(this.leaderboardsToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // timerFacil
            // 
            this.timerFacil.Interval = 1000;
            this.timerFacil.Tick += new System.EventHandler(this.timerFacil_Tick);
            // 
            // labelMinasFacil
            // 
            this.labelMinasFacil.AutoSize = true;
            this.labelMinasFacil.Location = new System.Drawing.Point(12, 44);
            this.labelMinasFacil.Name = "labelMinasFacil";
            this.labelMinasFacil.Size = new System.Drawing.Size(38, 13);
            this.labelMinasFacil.TabIndex = 165;
            this.labelMinasFacil.Text = "Minas:";
            // 
            // labelTempoFacil
            // 
            this.labelTempoFacil.AutoSize = true;
            this.labelTempoFacil.Location = new System.Drawing.Point(257, 44);
            this.labelTempoFacil.Name = "labelTempoFacil";
            this.labelTempoFacil.Size = new System.Drawing.Size(57, 13);
            this.labelTempoFacil.TabIndex = 166;
            this.labelTempoFacil.Text = "Tempo (s):";
            // 
            // labelTimerFacil
            // 
            this.labelTimerFacil.AutoSize = true;
            this.labelTimerFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerFacil.Location = new System.Drawing.Point(320, 39);
            this.labelTimerFacil.Name = "labelTimerFacil";
            this.labelTimerFacil.Size = new System.Drawing.Size(18, 20);
            this.labelTimerFacil.TabIndex = 167;
            this.labelTimerFacil.Text = "0";
            // 
            // labelNumMinasFacil
            // 
            this.labelNumMinasFacil.AutoSize = true;
            this.labelNumMinasFacil.Location = new System.Drawing.Point(56, 44);
            this.labelNumMinasFacil.Name = "labelNumMinasFacil";
            this.labelNumMinasFacil.Size = new System.Drawing.Size(19, 13);
            this.labelNumMinasFacil.TabIndex = 168;
            this.labelNumMinasFacil.Text = "10";
            // 
            // pictureBoxSound
            // 
            this.pictureBoxSound.Image = global::Minesweeper.Properties.Resources.nosound;
            this.pictureBoxSound.Location = new System.Drawing.Point(12, 319);
            this.pictureBoxSound.Name = "pictureBoxSound";
            this.pictureBoxSound.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxSound.TabIndex = 169;
            this.pictureBoxSound.TabStop = false;
            this.pictureBoxSound.Click += new System.EventHandler(this.pictureBoxSound_Click);
            // 
            // panelFacil
            // 
            this.panelFacil.Location = new System.Drawing.Point(69, 73);
            this.panelFacil.Name = "panelFacil";
            this.panelFacil.Size = new System.Drawing.Size(245, 246);
            this.panelFacil.TabIndex = 170;
            // 
            // labelUserFacil
            // 
            this.labelUserFacil.AutoSize = true;
            this.labelUserFacil.Location = new System.Drawing.Point(220, 329);
            this.labelUserFacil.Name = "labelUserFacil";
            this.labelUserFacil.Size = new System.Drawing.Size(75, 13);
            this.labelUserFacil.TabIndex = 172;
            this.labelUserFacil.Text = "Logado como:";
            // 
            // labelUserFF
            // 
            this.labelUserFF.AutoSize = true;
            this.labelUserFF.Location = new System.Drawing.Point(301, 329);
            this.labelUserFF.Name = "labelUserFF";
            this.labelUserFF.Size = new System.Drawing.Size(0, 13);
            this.labelUserFF.TabIndex = 173;
            // 
            // Facil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 351);
            this.Controls.Add(this.labelUserFF);
            this.Controls.Add(this.labelUserFacil);
            this.Controls.Add(this.panelFacil);
            this.Controls.Add(this.pictureBoxSound);
            this.Controls.Add(this.labelNumMinasFacil);
            this.Controls.Add(this.labelTimerFacil);
            this.Controls.Add(this.labelTempoFacil);
            this.Controls.Add(this.labelMinasFacil);
            this.Controls.Add(this.pictureBoxGameButton);
            this.Controls.Add(this.menuStripFacil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripFacil;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 390);
            this.MinimumSize = new System.Drawing.Size(410, 390);
            this.Name = "Facil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fácil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Facil_FormClosed);
            this.Load += new System.EventHandler(this.Facil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameButton)).EndInit();
            this.menuStripFacil.ResumeLayout(false);
            this.menuStripFacil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGameButton;
        private System.Windows.Forms.MenuStrip menuStripFacil;
        private System.Windows.Forms.ToolStripMenuItem leaderboardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer timerFacil;
        private System.Windows.Forms.Label labelMinasFacil;
        private System.Windows.Forms.Label labelTempoFacil;
        private System.Windows.Forms.Label labelTimerFacil;
        private System.Windows.Forms.Label labelNumMinasFacil;
        private System.Windows.Forms.PictureBox pictureBoxSound;
        private System.Windows.Forms.Panel panelFacil;
        private System.Windows.Forms.Label labelUserFacil;
        private System.Windows.Forms.Label labelUserFF;
    }
}