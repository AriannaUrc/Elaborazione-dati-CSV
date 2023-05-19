namespace Elaborazione_dati_CSV
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
            this.Cerca_button = new System.Windows.Forms.Button();
            this.nome_textbox = new System.Windows.Forms.TextBox();
            this.CountFields = new System.Windows.Forms.Button();
            this.titolo_textbox = new System.Windows.Forms.TextBox();
            this.link_textbox = new System.Windows.Forms.TextBox();
            this.latitudine_textbox = new System.Windows.Forms.TextBox();
            this.longitudine_textbox = new System.Windows.Forms.TextBox();
            this.miovalore_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Append = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LunghezzaMax
            // 
            this.LunghezzaMax.Location = new System.Drawing.Point(132, 41);
            this.LunghezzaMax.Name = "LunghezzaMax";
            this.LunghezzaMax.Size = new System.Drawing.Size(94, 23);
            this.LunghezzaMax.TabIndex = 0;
            this.LunghezzaMax.Text = "LunghezzaMax";
            this.LunghezzaMax.UseVisualStyleBackColor = true;
            this.LunghezzaMax.Click += new System.EventHandler(this.LunghezzaMax_Click);
            // 
            // Padding_button
            // 
            this.Padding_button.Location = new System.Drawing.Point(305, 96);
            this.Padding_button.Name = "Padding_button";
            this.Padding_button.Size = new System.Drawing.Size(76, 23);
            this.Padding_button.TabIndex = 1;
            this.Padding_button.Text = "Padding";
            this.Padding_button.UseVisualStyleBackColor = true;
            this.Padding_button.Click += new System.EventHandler(this.Padding_button_Click);
            // 
            // Cerca_button
            // 
            this.Cerca_button.Location = new System.Drawing.Point(305, 174);
            this.Cerca_button.Name = "Cerca_button";
            this.Cerca_button.Size = new System.Drawing.Size(76, 23);
            this.Cerca_button.TabIndex = 2;
            this.Cerca_button.Text = "Cerca";
            this.Cerca_button.UseVisualStyleBackColor = true;
            this.Cerca_button.Click += new System.EventHandler(this.Cerca_button_Click);
            // 
            // nome_textbox
            // 
            this.nome_textbox.Location = new System.Drawing.Point(132, 177);
            this.nome_textbox.Name = "nome_textbox";
            this.nome_textbox.Size = new System.Drawing.Size(100, 20);
            this.nome_textbox.TabIndex = 3;
            // 
            // CountFields
            // 
            this.CountFields.Location = new System.Drawing.Point(305, 41);
            this.CountFields.Name = "CountFields";
            this.CountFields.Size = new System.Drawing.Size(76, 23);
            this.CountFields.TabIndex = 4;
            this.CountFields.Text = "N. Campi";
            this.CountFields.UseVisualStyleBackColor = true;
            this.CountFields.Click += new System.EventHandler(this.CountFields_Click);
            // 
            // titolo_textbox
            // 
            this.titolo_textbox.Location = new System.Drawing.Point(135, 307);
            this.titolo_textbox.Name = "titolo_textbox";
            this.titolo_textbox.Size = new System.Drawing.Size(70, 20);
            this.titolo_textbox.TabIndex = 5;
            // 
            // link_textbox
            // 
            this.link_textbox.Location = new System.Drawing.Point(228, 307);
            this.link_textbox.Name = "link_textbox";
            this.link_textbox.Size = new System.Drawing.Size(70, 20);
            this.link_textbox.TabIndex = 6;
            // 
            // latitudine_textbox
            // 
            this.latitudine_textbox.Location = new System.Drawing.Point(314, 307);
            this.latitudine_textbox.Name = "latitudine_textbox";
            this.latitudine_textbox.Size = new System.Drawing.Size(70, 20);
            this.latitudine_textbox.TabIndex = 7;
            // 
            // longitudine_textbox
            // 
            this.longitudine_textbox.Location = new System.Drawing.Point(403, 307);
            this.longitudine_textbox.Name = "longitudine_textbox";
            this.longitudine_textbox.Size = new System.Drawing.Size(70, 20);
            this.longitudine_textbox.TabIndex = 8;
            // 
            // miovalore_textbox
            // 
            this.miovalore_textbox.Location = new System.Drawing.Point(491, 307);
            this.miovalore_textbox.Name = "miovalore_textbox";
            this.miovalore_textbox.Size = new System.Drawing.Size(70, 20);
            this.miovalore_textbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Titolo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Latitudine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Longitudine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Miovalore";
            // 
            // Append
            // 
            this.Append.Location = new System.Drawing.Point(597, 304);
            this.Append.Name = "Append";
            this.Append.Size = new System.Drawing.Size(76, 23);
            this.Append.TabIndex = 15;
            this.Append.Text = "Aggiungi";
            this.Append.UseVisualStyleBackColor = true;
            this.Append.Click += new System.EventHandler(this.Append_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Append);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.miovalore_textbox);
            this.Controls.Add(this.longitudine_textbox);
            this.Controls.Add(this.latitudine_textbox);
            this.Controls.Add(this.link_textbox);
            this.Controls.Add(this.titolo_textbox);
            this.Controls.Add(this.CountFields);
            this.Controls.Add(this.nome_textbox);
            this.Controls.Add(this.Cerca_button);
            this.Controls.Add(this.Padding_button);
            this.Controls.Add(this.LunghezzaMax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LunghezzaMax;
        private System.Windows.Forms.Button Padding_button;
        private System.Windows.Forms.Button Cerca_button;
        private System.Windows.Forms.TextBox nome_textbox;
        private System.Windows.Forms.Button CountFields;
        private System.Windows.Forms.TextBox titolo_textbox;
        private System.Windows.Forms.TextBox link_textbox;
        private System.Windows.Forms.TextBox latitudine_textbox;
        private System.Windows.Forms.TextBox longitudine_textbox;
        private System.Windows.Forms.TextBox miovalore_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Append;
    }
}

