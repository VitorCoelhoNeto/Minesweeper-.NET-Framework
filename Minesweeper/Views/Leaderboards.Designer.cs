namespace Minesweeper
{
    partial class Leaderboards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboards));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTopOff = new System.Windows.Forms.Label();
            this.labelTopOn = new System.Windows.Forms.Label();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.labelFacilTitulo = new System.Windows.Forms.Label();
            this.labelMedioTitulo = new System.Windows.Forms.Label();
            this.textBoxTopFacilLocal = new System.Windows.Forms.TextBox();
            this.textBoxTopMedioLocal = new System.Windows.Forms.TextBox();
            this.pictureBoxTop = new System.Windows.Forms.PictureBox();
            this.pictureBoxCup = new System.Windows.Forms.PictureBox();
            this.panelMedio = new System.Windows.Forms.Panel();
            this.panelFacil = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCup)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // labelTopOff
            // 
            this.labelTopOff.AutoSize = true;
            this.labelTopOff.Location = new System.Drawing.Point(12, 366);
            this.labelTopOff.Name = "labelTopOff";
            this.labelTopOff.Size = new System.Drawing.Size(203, 13);
            this.labelTopOff.TabIndex = 1;
            this.labelTopOff.Text = "Melhores Tempos Locais ( em segundos):";
            // 
            // labelTopOn
            // 
            this.labelTopOn.AutoSize = true;
            this.labelTopOn.Location = new System.Drawing.Point(12, 52);
            this.labelTopOn.Name = "labelTopOn";
            this.labelTopOn.Size = new System.Drawing.Size(92, 13);
            this.labelTopOn.TabIndex = 2;
            this.labelTopOn.Text = "Top 10 (Servidor):";
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(226, 334);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(122, 29);
            this.buttonAtualizar.TabIndex = 5;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // labelFacilTitulo
            // 
            this.labelFacilTitulo.AutoSize = true;
            this.labelFacilTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacilTitulo.Location = new System.Drawing.Point(90, 36);
            this.labelFacilTitulo.Name = "labelFacilTitulo";
            this.labelFacilTitulo.Size = new System.Drawing.Size(37, 16);
            this.labelFacilTitulo.TabIndex = 8;
            this.labelFacilTitulo.Text = "Fácil";
            // 
            // labelMedioTitulo
            // 
            this.labelMedioTitulo.AutoSize = true;
            this.labelMedioTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedioTitulo.Location = new System.Drawing.Point(418, 36);
            this.labelMedioTitulo.Name = "labelMedioTitulo";
            this.labelMedioTitulo.Size = new System.Drawing.Size(46, 16);
            this.labelMedioTitulo.TabIndex = 9;
            this.labelMedioTitulo.Text = "Médio";
            // 
            // textBoxTopFacilLocal
            // 
            this.textBoxTopFacilLocal.Location = new System.Drawing.Point(12, 382);
            this.textBoxTopFacilLocal.Name = "textBoxTopFacilLocal";
            this.textBoxTopFacilLocal.ReadOnly = true;
            this.textBoxTopFacilLocal.Size = new System.Drawing.Size(250, 20);
            this.textBoxTopFacilLocal.TabIndex = 10;
            this.textBoxTopFacilLocal.Text = "999999";
            this.textBoxTopFacilLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTopMedioLocal
            // 
            this.textBoxTopMedioLocal.Location = new System.Drawing.Point(306, 382);
            this.textBoxTopMedioLocal.Name = "textBoxTopMedioLocal";
            this.textBoxTopMedioLocal.ReadOnly = true;
            this.textBoxTopMedioLocal.Size = new System.Drawing.Size(250, 20);
            this.textBoxTopMedioLocal.TabIndex = 11;
            this.textBoxTopMedioLocal.Text = "999999";
            this.textBoxTopMedioLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxTop
            // 
            this.pictureBoxTop.InitialImage = null;
            this.pictureBoxTop.Location = new System.Drawing.Point(266, 78);
            this.pictureBoxTop.Name = "pictureBoxTop";
            this.pictureBoxTop.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxTop.TabIndex = 13;
            this.pictureBoxTop.TabStop = false;
            // 
            // pictureBoxCup
            // 
            this.pictureBoxCup.InitialImage = null;
            this.pictureBoxCup.Location = new System.Drawing.Point(266, 36);
            this.pictureBoxCup.Name = "pictureBoxCup";
            this.pictureBoxCup.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxCup.TabIndex = 14;
            this.pictureBoxCup.TabStop = false;
            // 
            // panelMedio
            // 
            this.panelMedio.Location = new System.Drawing.Point(308, 78);
            this.panelMedio.Name = "panelMedio";
            this.panelMedio.Size = new System.Drawing.Size(248, 250);
            this.panelMedio.TabIndex = 15;
            // 
            // panelFacil
            // 
            this.panelFacil.Location = new System.Drawing.Point(10, 78);
            this.panelFacil.Name = "panelFacil";
            this.panelFacil.Size = new System.Drawing.Size(250, 250);
            this.panelFacil.TabIndex = 16;
            // 
            // Leaderboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 439);
            this.Controls.Add(this.panelMedio);
            this.Controls.Add(this.panelFacil);
            this.Controls.Add(this.pictureBoxCup);
            this.Controls.Add(this.pictureBoxTop);
            this.Controls.Add(this.textBoxTopMedioLocal);
            this.Controls.Add(this.textBoxTopFacilLocal);
            this.Controls.Add(this.labelMedioTitulo);
            this.Controls.Add(this.labelFacilTitulo);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.labelTopOn);
            this.Controls.Add(this.labelTopOff);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Leaderboards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboards";
            this.Load += new System.EventHandler(this.Leaderboards_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label labelTopOff;
        private System.Windows.Forms.Label labelTopOn;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Label labelFacilTitulo;
        private System.Windows.Forms.Label labelMedioTitulo;
        private System.Windows.Forms.TextBox textBoxTopFacilLocal;
        private System.Windows.Forms.TextBox textBoxTopMedioLocal;
        private System.Windows.Forms.PictureBox pictureBoxTop;
        private System.Windows.Forms.PictureBox pictureBoxCup;
        private System.Windows.Forms.Panel panelMedio;
        private System.Windows.Forms.Panel panelFacil;
    }
}