namespace MultiForm01
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
            this.btnApriForm2 = new System.Windows.Forms.Button();
            this.btnApriForm2B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApriForm2
            // 
            this.btnApriForm2.Location = new System.Drawing.Point(13, 13);
            this.btnApriForm2.Name = "btnApriForm2";
            this.btnApriForm2.Size = new System.Drawing.Size(75, 23);
            this.btnApriForm2.TabIndex = 0;
            this.btnApriForm2.Text = "Apri form2";
            this.btnApriForm2.UseVisualStyleBackColor = true;
            this.btnApriForm2.Click += new System.EventHandler(this.btnApriForm2_Click);
            // 
            // btnApriForm2B
            // 
            this.btnApriForm2B.Location = new System.Drawing.Point(117, 12);
            this.btnApriForm2B.Name = "btnApriForm2B";
            this.btnApriForm2B.Size = new System.Drawing.Size(75, 23);
            this.btnApriForm2B.TabIndex = 1;
            this.btnApriForm2B.Text = "Apri form 2B";
            this.btnApriForm2B.UseVisualStyleBackColor = true;
            this.btnApriForm2B.Click += new System.EventHandler(this.btnApriForm2B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApriForm2B);
            this.Controls.Add(this.btnApriForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApriForm2;
        private System.Windows.Forms.Button btnApriForm2B;
    }
}

