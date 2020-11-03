namespace Es04_Multiform_text_box
{
    partial class FormFiglia
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
            this.btnModificaFiglia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModificaFiglia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnModificaFiglia
            // 
            this.btnModificaFiglia.Location = new System.Drawing.Point(15, 83);
            this.btnModificaFiglia.Name = "btnModificaFiglia";
            this.btnModificaFiglia.Size = new System.Drawing.Size(141, 23);
            this.btnModificaFiglia.TabIndex = 0;
            this.btnModificaFiglia.Text = "INVIA";
            this.btnModificaFiglia.UseVisualStyleBackColor = true;
            this.btnModificaFiglia.Click += new System.EventHandler(this.btnModificaFiglia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci il testo da modificare";
            // 
            // txtModificaFiglia
            // 
            this.txtModificaFiglia.Location = new System.Drawing.Point(15, 44);
            this.txtModificaFiglia.Name = "txtModificaFiglia";
            this.txtModificaFiglia.Size = new System.Drawing.Size(141, 20);
            this.txtModificaFiglia.TabIndex = 2;
            this.txtModificaFiglia.TextChanged += new System.EventHandler(this.txtModificaFiglia_TextChanged);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 131);
            this.Controls.Add(this.txtModificaFiglia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificaFiglia);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.Load += new System.EventHandler(this.FormFiglia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificaFiglia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModificaFiglia;
    }
}