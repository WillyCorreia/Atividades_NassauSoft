namespace AtividadesWindowsForms.AtividadesJunior
{
    partial class Primos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Primos));
            this.TxtB_Numero = new System.Windows.Forms.TextBox();
            this.Lbl_EscolhaNumero = new System.Windows.Forms.Label();
            this.Btn_Analisar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Primo = new System.Windows.Forms.Label();
            this.Lbl_EPrimo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtB_Numero
            // 
            this.TxtB_Numero.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.TxtB_Numero.Location = new System.Drawing.Point(281, 107);
            this.TxtB_Numero.Name = "TxtB_Numero";
            this.TxtB_Numero.Size = new System.Drawing.Size(215, 39);
            this.TxtB_Numero.TabIndex = 40;
            // 
            // Lbl_EscolhaNumero
            // 
            this.Lbl_EscolhaNumero.AutoSize = true;
            this.Lbl_EscolhaNumero.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EscolhaNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_EscolhaNumero.Location = new System.Drawing.Point(303, 88);
            this.Lbl_EscolhaNumero.Name = "Lbl_EscolhaNumero";
            this.Lbl_EscolhaNumero.Size = new System.Drawing.Size(170, 16);
            this.Lbl_EscolhaNumero.TabIndex = 39;
            this.Lbl_EscolhaNumero.Text = "Escolha um número ...";
            // 
            // Btn_Analisar
            // 
            this.Btn_Analisar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Analisar.Location = new System.Drawing.Point(336, 152);
            this.Btn_Analisar.Name = "Btn_Analisar";
            this.Btn_Analisar.Size = new System.Drawing.Size(101, 33);
            this.Btn_Analisar.TabIndex = 38;
            this.Btn_Analisar.Text = "Analisar";
            this.Btn_Analisar.UseVisualStyleBackColor = true;
            this.Btn_Analisar.Click += new System.EventHandler(this.Btn_Analisar_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(12, 12);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(82, 30);
            this.Btn_Voltar.TabIndex = 37;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Lbl_Primo
            // 
            this.Lbl_Primo.AutoSize = true;
            this.Lbl_Primo.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Primo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Primo.Location = new System.Drawing.Point(311, 40);
            this.Lbl_Primo.Name = "Lbl_Primo";
            this.Lbl_Primo.Size = new System.Drawing.Size(162, 40);
            this.Lbl_Primo.TabIndex = 36;
            this.Lbl_Primo.Text = "É primo?";
            // 
            // Lbl_EPrimo
            // 
            this.Lbl_EPrimo.AutoSize = true;
            this.Lbl_EPrimo.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EPrimo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_EPrimo.Location = new System.Drawing.Point(274, 257);
            this.Lbl_EPrimo.Name = "Lbl_EPrimo";
            this.Lbl_EPrimo.Size = new System.Drawing.Size(0, 40);
            this.Lbl_EPrimo.TabIndex = 41;
            this.Lbl_EPrimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Primos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Lbl_EPrimo);
            this.Controls.Add(this.TxtB_Numero);
            this.Controls.Add(this.Lbl_EscolhaNumero);
            this.Controls.Add(this.Btn_Analisar);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_Primo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Primos";
            this.Text = "Números Primos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtB_Numero;
        private System.Windows.Forms.Label Lbl_EscolhaNumero;
        private System.Windows.Forms.Button Btn_Analisar;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_Primo;
        private System.Windows.Forms.Label Lbl_EPrimo;
    }
}