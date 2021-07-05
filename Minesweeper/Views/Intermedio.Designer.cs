namespace Minesweeper
{
    partial class Intermedio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intermedio));
            this.pictureBoxGameButtonMedio = new System.Windows.Forms.PictureBox();
            this.menuStripMedio = new System.Windows.Forms.MenuStrip();
            this.leaderboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMinasFacil = new System.Windows.Forms.Label();
            this.labelTempoMedio = new System.Windows.Forms.Label();
            this.timerMedio = new System.Windows.Forms.Timer(this.components);
            this.labelTimeMedio = new System.Windows.Forms.Label();
            this.labelNumMinasMedio = new System.Windows.Forms.Label();
            this.pictureBox257 = new System.Windows.Forms.PictureBox();
            this.panelMedio = new System.Windows.Forms.Panel();
            this.labelLogadoComoMedio = new System.Windows.Forms.Label();
            this.labelUserMedio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameButtonMedio)).BeginInit();
            this.menuStripMedio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox257)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGameButtonMedio
            // 
            this.pictureBoxGameButtonMedio.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGameButtonMedio.Image")));
            this.pictureBoxGameButtonMedio.Location = new System.Drawing.Point(290, 27);
            this.pictureBoxGameButtonMedio.Name = "pictureBoxGameButtonMedio";
            this.pictureBoxGameButtonMedio.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxGameButtonMedio.TabIndex = 419;
            this.pictureBoxGameButtonMedio.TabStop = false;
            this.pictureBoxGameButtonMedio.Click += new System.EventHandler(this.pictureBoxGameButtonMedio_Click);
            // 
            // menuStripMedio
            // 
            this.menuStripMedio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leaderboardsToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStripMedio.Location = new System.Drawing.Point(0, 0);
            this.menuStripMedio.Name = "menuStripMedio";
            this.menuStripMedio.Size = new System.Drawing.Size(605, 24);
            this.menuStripMedio.TabIndex = 420;
            this.menuStripMedio.Text = "menuStrip1";
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
            // labelMinasFacil
            // 
            this.labelMinasFacil.AutoSize = true;
            this.labelMinasFacil.Location = new System.Drawing.Point(12, 43);
            this.labelMinasFacil.Name = "labelMinasFacil";
            this.labelMinasFacil.Size = new System.Drawing.Size(38, 13);
            this.labelMinasFacil.TabIndex = 421;
            this.labelMinasFacil.Text = "Minas:";
            // 
            // labelTempoMedio
            // 
            this.labelTempoMedio.AutoSize = true;
            this.labelTempoMedio.Location = new System.Drawing.Point(484, 43);
            this.labelTempoMedio.Name = "labelTempoMedio";
            this.labelTempoMedio.Size = new System.Drawing.Size(43, 13);
            this.labelTempoMedio.TabIndex = 422;
            this.labelTempoMedio.Text = "Tempo:";
            // 
            // timerMedio
            // 
            this.timerMedio.Interval = 1000;
            this.timerMedio.Tick += new System.EventHandler(this.timerMedio_Tick);
            // 
            // labelTimeMedio
            // 
            this.labelTimeMedio.AutoSize = true;
            this.labelTimeMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeMedio.Location = new System.Drawing.Point(533, 38);
            this.labelTimeMedio.Name = "labelTimeMedio";
            this.labelTimeMedio.Size = new System.Drawing.Size(18, 20);
            this.labelTimeMedio.TabIndex = 423;
            this.labelTimeMedio.Text = "0";
            // 
            // labelNumMinasMedio
            // 
            this.labelNumMinasMedio.AutoSize = true;
            this.labelNumMinasMedio.Location = new System.Drawing.Point(56, 43);
            this.labelNumMinasMedio.Name = "labelNumMinasMedio";
            this.labelNumMinasMedio.Size = new System.Drawing.Size(19, 13);
            this.labelNumMinasMedio.TabIndex = 424;
            this.labelNumMinasMedio.Text = "40";
            // 
            // pictureBox257
            // 
            this.pictureBox257.Image = global::Minesweeper.Properties.Resources.nosound;
            this.pictureBox257.Location = new System.Drawing.Point(12, 536);
            this.pictureBox257.Name = "pictureBox257";
            this.pictureBox257.Size = new System.Drawing.Size(20, 20);
            this.pictureBox257.TabIndex = 425;
            this.pictureBox257.TabStop = false;
            this.pictureBox257.Click += new System.EventHandler(this.pictureBox257_Click);
            // 
            // panelMedio
            // 
            this.panelMedio.Location = new System.Drawing.Point(86, 74);
            this.panelMedio.Name = "panelMedio";
            this.panelMedio.Size = new System.Drawing.Size(441, 442);
            this.panelMedio.TabIndex = 426;
            // 
            // labelLogadoComoMedio
            // 
            this.labelLogadoComoMedio.AutoSize = true;
            this.labelLogadoComoMedio.Location = new System.Drawing.Point(437, 546);
            this.labelLogadoComoMedio.Name = "labelLogadoComoMedio";
            this.labelLogadoComoMedio.Size = new System.Drawing.Size(75, 13);
            this.labelLogadoComoMedio.TabIndex = 427;
            this.labelLogadoComoMedio.Text = "Logado como:";
            // 
            // labelUserMedio
            // 
            this.labelUserMedio.AutoSize = true;
            this.labelUserMedio.Location = new System.Drawing.Point(518, 546);
            this.labelUserMedio.Name = "labelUserMedio";
            this.labelUserMedio.Size = new System.Drawing.Size(0, 13);
            this.labelUserMedio.TabIndex = 428;
            // 
            // Intermedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 568);
            this.Controls.Add(this.labelUserMedio);
            this.Controls.Add(this.labelLogadoComoMedio);
            this.Controls.Add(this.panelMedio);
            this.Controls.Add(this.pictureBox257);
            this.Controls.Add(this.labelNumMinasMedio);
            this.Controls.Add(this.labelTimeMedio);
            this.Controls.Add(this.labelTempoMedio);
            this.Controls.Add(this.labelMinasFacil);
            this.Controls.Add(this.pictureBoxGameButtonMedio);
            this.Controls.Add(this.menuStripMedio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMedio;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(621, 607);
            this.Name = "Intermedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intermedio";
            this.Load += new System.EventHandler(this.Intermedio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameButtonMedio)).EndInit();
            this.menuStripMedio.ResumeLayout(false);
            this.menuStripMedio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox257)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxGameButtonMedio;
        private System.Windows.Forms.MenuStrip menuStripMedio;
        private System.Windows.Forms.ToolStripMenuItem leaderboardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label labelMinasFacil;
        private System.Windows.Forms.Label labelTempoMedio;
        private System.Windows.Forms.Timer timerMedio;
        private System.Windows.Forms.Label labelTimeMedio;
        private System.Windows.Forms.Label labelNumMinasMedio;
        private System.Windows.Forms.PictureBox pictureBox257;
        private System.Windows.Forms.Panel panelMedio;
        private System.Windows.Forms.Label labelLogadoComoMedio;
        private System.Windows.Forms.Label labelUserMedio;
    }
}