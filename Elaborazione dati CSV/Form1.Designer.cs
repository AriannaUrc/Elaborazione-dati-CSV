﻿namespace Elaborazione_dati_CSV
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
            this.LunghezzaMax = new System.Windows.Forms.Button();
            this.Padding_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LunghezzaMax
            // 
            this.LunghezzaMax.Location = new System.Drawing.Point(132, 174);
            this.LunghezzaMax.Name = "LunghezzaMax";
            this.LunghezzaMax.Size = new System.Drawing.Size(94, 23);
            this.LunghezzaMax.TabIndex = 0;
            this.LunghezzaMax.Text = "LunghezzaMax";
            this.LunghezzaMax.UseVisualStyleBackColor = true;
            this.LunghezzaMax.Click += new System.EventHandler(this.LunghezzaMax_Click);
            // 
            // Padding_button
            // 
            this.Padding_button.Location = new System.Drawing.Point(305, 174);
            this.Padding_button.Name = "Padding_button";
            this.Padding_button.Size = new System.Drawing.Size(76, 23);
            this.Padding_button.TabIndex = 1;
            this.Padding_button.Text = "Padding";
            this.Padding_button.UseVisualStyleBackColor = true;
            this.Padding_button.Click += new System.EventHandler(this.Padding_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Padding_button);
            this.Controls.Add(this.LunghezzaMax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LunghezzaMax;
        private System.Windows.Forms.Button Padding_button;
    }
}

