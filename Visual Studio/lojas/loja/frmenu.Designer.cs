namespace loja
{
    partial class frmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.levantamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webusersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionaStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDaAPlicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.levantamentoToolStripMenuItem,
            this.verStockToolStripMenuItem,
            this.webusersToolStripMenuItem,
            this.adicionaStockToolStripMenuItem,
            this.sairDaAPlicaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Menu
            // 
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(51, 20);
            this.Menu.Text = "Venda";
            this.Menu.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // levantamentoToolStripMenuItem
            // 
            this.levantamentoToolStripMenuItem.Name = "levantamentoToolStripMenuItem";
            this.levantamentoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.levantamentoToolStripMenuItem.Text = "Levantamento";
            this.levantamentoToolStripMenuItem.Click += new System.EventHandler(this.levantamentoToolStripMenuItem_Click);
            // 
            // verStockToolStripMenuItem
            // 
            this.verStockToolStripMenuItem.Name = "verStockToolStripMenuItem";
            this.verStockToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.verStockToolStripMenuItem.Text = "Ver Stock";
            this.verStockToolStripMenuItem.Click += new System.EventHandler(this.verStockToolStripMenuItem_Click);
            // 
            // webusersToolStripMenuItem
            // 
            this.webusersToolStripMenuItem.Name = "webusersToolStripMenuItem";
            this.webusersToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.webusersToolStripMenuItem.Text = "Webusers";
            this.webusersToolStripMenuItem.Click += new System.EventHandler(this.webusersToolStripMenuItem_Click);
            // 
            // adicionaStockToolStripMenuItem
            // 
            this.adicionaStockToolStripMenuItem.Name = "adicionaStockToolStripMenuItem";
            this.adicionaStockToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.adicionaStockToolStripMenuItem.Text = "AdicionaStock";
            this.adicionaStockToolStripMenuItem.Click += new System.EventHandler(this.adicionaStockToolStripMenuItem_Click);
            // 
            // sairDaAPlicaçãoToolStripMenuItem
            // 
            this.sairDaAPlicaçãoToolStripMenuItem.Name = "sairDaAPlicaçãoToolStripMenuItem";
            this.sairDaAPlicaçãoToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.sairDaAPlicaçãoToolStripMenuItem.Text = "Sair da Aplicação";
            this.sairDaAPlicaçãoToolStripMenuItem.Click += new System.EventHandler(this.sairDaAPlicaçãoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 198);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(147, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(497, 293);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem levantamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDaAPlicaçãoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem webusersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionaStockToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

