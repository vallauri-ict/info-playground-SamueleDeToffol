﻿namespace MultiForm01
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
            this.btnFigliaChi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFigliaChi
            // 
            this.btnFigliaChi.Location = new System.Drawing.Point(13, 13);
            this.btnFigliaChi.Name = "btnFigliaChi";
            this.btnFigliaChi.Size = new System.Drawing.Size(128, 23);
            this.btnFigliaChi.TabIndex = 0;
            this.btnFigliaChi.Text = "Di chi sono figlia?";
            this.btnFigliaChi.UseVisualStyleBackColor = true;
            this.btnFigliaChi.Click += new System.EventHandler(this.btnFigliaChi_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 348);
            this.Controls.Add(this.btnFigliaChi);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFigliaChi;
    }
}