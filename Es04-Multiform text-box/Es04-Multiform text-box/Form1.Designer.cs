namespace Es04_Multiform_text_box
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSecondariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFigliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDescrizione = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEtà = new System.Windows.Forms.Label();
            this.txtNomePrinc = new System.Windows.Forms.TextBox();
            this.txtEtàPrinc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModifica = new System.Windows.Forms.TextBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.newMDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSecondariaToolStripMenuItem,
            this.newFigliaToolStripMenuItem,
            this.newMDIToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newSecondariaToolStripMenuItem
            // 
            this.newSecondariaToolStripMenuItem.Name = "newSecondariaToolStripMenuItem";
            this.newSecondariaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newSecondariaToolStripMenuItem.Text = "New secondaria";
            this.newSecondariaToolStripMenuItem.Click += new System.EventHandler(this.newSecondariaToolStripMenuItem_Click);
            // 
            // newFigliaToolStripMenuItem
            // 
            this.newFigliaToolStripMenuItem.Name = "newFigliaToolStripMenuItem";
            this.newFigliaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newFigliaToolStripMenuItem.Text = "New figlia";
            this.newFigliaToolStripMenuItem.Click += new System.EventHandler(this.newFigliaToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDescrizione});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDescrizione
            // 
            this.toolStripDescrizione.Name = "toolStripDescrizione";
            this.toolStripDescrizione.Size = new System.Drawing.Size(52, 17);
            this.toolStripDescrizione.Text = "Iniziamo";
            this.toolStripDescrizione.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nome: ";
            // 
            // lblEtà
            // 
            this.lblEtà.AutoSize = true;
            this.lblEtà.Location = new System.Drawing.Point(12, 114);
            this.lblEtà.Name = "lblEtà";
            this.lblEtà.Size = new System.Drawing.Size(29, 13);
            this.lblEtà.TabIndex = 4;
            this.lblEtà.Text = "Età: ";
            // 
            // txtNomePrinc
            // 
            this.txtNomePrinc.Location = new System.Drawing.Point(61, 61);
            this.txtNomePrinc.Name = "txtNomePrinc";
            this.txtNomePrinc.ReadOnly = true;
            this.txtNomePrinc.Size = new System.Drawing.Size(100, 20);
            this.txtNomePrinc.TabIndex = 5;
            // 
            // txtEtàPrinc
            // 
            this.txtEtàPrinc.Location = new System.Drawing.Point(61, 111);
            this.txtEtàPrinc.Name = "txtEtàPrinc";
            this.txtEtàPrinc.ReadOnly = true;
            this.txtEtàPrinc.Size = new System.Drawing.Size(100, 20);
            this.txtEtàPrinc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Modifica";
            // 
            // txtModifica
            // 
            this.txtModifica.Location = new System.Drawing.Point(346, 80);
            this.txtModifica.Name = "txtModifica";
            this.txtModifica.Size = new System.Drawing.Size(100, 20);
            this.txtModifica.TabIndex = 8;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(359, 104);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 9;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // newMDIToolStripMenuItem
            // 
            this.newMDIToolStripMenuItem.Name = "newMDIToolStripMenuItem";
            this.newMDIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newMDIToolStripMenuItem.Text = "New MDI";
            this.newMDIToolStripMenuItem.Click += new System.EventHandler(this.newMDIToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.txtModifica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEtàPrinc);
            this.Controls.Add(this.txtNomePrinc);
            this.Controls.Add(this.lblEtà);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSecondariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDescrizione;
        private System.Windows.Forms.ToolStripMenuItem newFigliaToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEtà;
        private System.Windows.Forms.TextBox txtNomePrinc;
        private System.Windows.Forms.TextBox txtEtàPrinc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModifica;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.ToolStripMenuItem newMDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

