namespace Minesweeper
{
    partial class Tab
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.leaderboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxModosJogo = new System.Windows.Forms.ComboBox();
            this.labelDificuldade = new System.Windows.Forms.Label();
            this.buttonJogar = new System.Windows.Forms.Button();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.pictureBoxCreditos = new System.Windows.Forms.PictureBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxSom = new System.Windows.Forms.PictureBox();
            this.labelLogadoComoMenu = new System.Windows.Forms.Label();
            this.labelUserMenu = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCreditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSom)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leaderboardsToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.verPerfilToolStripMenuItem,
            this.reiniciarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 82;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // leaderboardsToolStripMenuItem
            // 
            this.leaderboardsToolStripMenuItem.Name = "leaderboardsToolStripMenuItem";
            this.leaderboardsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.leaderboardsToolStripMenuItem.Text = "Leaderboards";
            this.leaderboardsToolStripMenuItem.Click += new System.EventHandler(this.leaderboardsToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // verPerfilToolStripMenuItem
            // 
            this.verPerfilToolStripMenuItem.Name = "verPerfilToolStripMenuItem";
            this.verPerfilToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.verPerfilToolStripMenuItem.Text = "Ver Perfil";
            this.verPerfilToolStripMenuItem.Click += new System.EventHandler(this.verPerfilToolStripMenuItem_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.reiniciarToolStripMenuItem.Text = "Sair";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // comboBoxModosJogo
            // 
            this.comboBoxModosJogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModosJogo.FormattingEnabled = true;
            this.comboBoxModosJogo.Items.AddRange(new object[] {
            "Facil",
            "Intermedio",
            "Custom Facil",
            "Custom Intermedio"});
            this.comboBoxModosJogo.Location = new System.Drawing.Point(138, 200);
            this.comboBoxModosJogo.Name = "comboBoxModosJogo";
            this.comboBoxModosJogo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModosJogo.TabIndex = 83;
            // 
            // labelDificuldade
            // 
            this.labelDificuldade.AutoSize = true;
            this.labelDificuldade.Location = new System.Drawing.Point(69, 203);
            this.labelDificuldade.Name = "labelDificuldade";
            this.labelDificuldade.Size = new System.Drawing.Size(63, 13);
            this.labelDificuldade.TabIndex = 84;
            this.labelDificuldade.Text = "Dificuldade:";
            // 
            // buttonJogar
            // 
            this.buttonJogar.Location = new System.Drawing.Point(162, 227);
            this.buttonJogar.Name = "buttonJogar";
            this.buttonJogar.Size = new System.Drawing.Size(75, 23);
            this.buttonJogar.TabIndex = 85;
            this.buttonJogar.Text = "Jogar";
            this.buttonJogar.UseVisualStyleBackColor = true;
            this.buttonJogar.Click += new System.EventHandler(this.buttonJogar_Click);
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTitulo.Image")));
            this.pictureBoxTitulo.Location = new System.Drawing.Point(12, 27);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(370, 76);
            this.pictureBoxTitulo.TabIndex = 86;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // pictureBoxCreditos
            // 
            this.pictureBoxCreditos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCreditos.Image")));
            this.pictureBoxCreditos.Location = new System.Drawing.Point(162, 321);
            this.pictureBoxCreditos.Name = "pictureBoxCreditos";
            this.pictureBoxCreditos.Size = new System.Drawing.Size(220, 18);
            this.pictureBoxCreditos.TabIndex = 87;
            this.pictureBoxCreditos.TabStop = false;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(162, 109);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(62, 62);
            this.pictureBoxIcon.TabIndex = 88;
            this.pictureBoxIcon.TabStop = false;
            // 
            // pictureBoxSom
            // 
            this.pictureBoxSom.Location = new System.Drawing.Point(12, 314);
            this.pictureBoxSom.Name = "pictureBoxSom";
            this.pictureBoxSom.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxSom.TabIndex = 89;
            this.pictureBoxSom.TabStop = false;
            this.pictureBoxSom.Click += new System.EventHandler(this.pictureBoxSom_Click);
            // 
            // labelLogadoComoMenu
            // 
            this.labelLogadoComoMenu.AutoSize = true;
            this.labelLogadoComoMenu.Location = new System.Drawing.Point(38, 284);
            this.labelLogadoComoMenu.Name = "labelLogadoComoMenu";
            this.labelLogadoComoMenu.Size = new System.Drawing.Size(75, 13);
            this.labelLogadoComoMenu.TabIndex = 90;
            this.labelLogadoComoMenu.Text = "Logado como:";
            // 
            // labelUserMenu
            // 
            this.labelUserMenu.AutoSize = true;
            this.labelUserMenu.Location = new System.Drawing.Point(38, 297);
            this.labelUserMenu.Name = "labelUserMenu";
            this.labelUserMenu.Size = new System.Drawing.Size(0, 13);
            this.labelUserMenu.TabIndex = 91;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(38, 314);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(51, 21);
            this.buttonLogout.TabIndex = 92;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 351);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelUserMenu);
            this.Controls.Add(this.labelLogadoComoMenu);
            this.Controls.Add(this.pictureBoxSom);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.pictureBoxCreditos);
            this.Controls.Add(this.pictureBoxTitulo);
            this.Controls.Add(this.buttonJogar);
            this.Controls.Add(this.labelDificuldade);
            this.Controls.Add(this.comboBoxModosJogo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 390);
            this.MinimumSize = new System.Drawing.Size(410, 390);
            this.Name = "Tab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCreditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaderboardsToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxModosJogo;
        private System.Windows.Forms.Label labelDificuldade;
        private System.Windows.Forms.Button buttonJogar;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.PictureBox pictureBoxCreditos;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxSom;
        private System.Windows.Forms.Label labelLogadoComoMenu;
        private System.Windows.Forms.Label labelUserMenu;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ToolStripMenuItem verPerfilToolStripMenuItem;
    }
}

