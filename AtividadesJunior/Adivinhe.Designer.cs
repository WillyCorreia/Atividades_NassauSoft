namespace AtividadesWindowsForms.AtividadesJunior
{
    partial class Adivinhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adivinhe));
            this.Lbl_NumeroSecreto = new System.Windows.Forms.Label();
            this.TxtB_Numero = new System.Windows.Forms.TextBox();
            this.Lbl_EscolhaNumero = new System.Windows.Forms.Label();
            this.Btn_Adivinhar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Adivinhe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_NumeroSecreto
            // 
            this.Lbl_NumeroSecreto.AutoSize = true;
            this.Lbl_NumeroSecreto.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NumeroSecreto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_NumeroSecreto.Location = new System.Drawing.Point(53, 240);
            this.Lbl_NumeroSecreto.Name = "Lbl_NumeroSecreto";
            this.Lbl_NumeroSecreto.Size = new System.Drawing.Size(0, 40);
            this.Lbl_NumeroSecreto.TabIndex = 30;
            this.Lbl_NumeroSecreto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtB_Numero
            // 
            this.TxtB_Numero.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.TxtB_Numero.Location = new System.Drawing.Point(281, 107);
            this.TxtB_Numero.Name = "TxtB_Numero";
            this.TxtB_Numero.Size = new System.Drawing.Size(215, 39);
            this.TxtB_Numero.TabIndex = 29;
            // 
            // Lbl_EscolhaNumero
            // 
            this.Lbl_EscolhaNumero.AutoSize = true;
            this.Lbl_EscolhaNumero.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EscolhaNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_EscolhaNumero.Location = new System.Drawing.Point(259, 88);
            this.Lbl_EscolhaNumero.Name = "Lbl_EscolhaNumero";
            this.Lbl_EscolhaNumero.Size = new System.Drawing.Size(259, 16);
            this.Lbl_EscolhaNumero.TabIndex = 28;
            this.Lbl_EscolhaNumero.Text = "Escolha um número de 1 até 100...";
            // 
            // Btn_Adivinhar
            // 
            this.Btn_Adivinhar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Adivinhar.Location = new System.Drawing.Point(330, 152);
            this.Btn_Adivinhar.Name = "Btn_Adivinhar";
            this.Btn_Adivinhar.Size = new System.Drawing.Size(116, 33);
            this.Btn_Adivinhar.TabIndex = 27;
            this.Btn_Adivinhar.Text = "Adivinhar";
            this.Btn_Adivinhar.UseVisualStyleBackColor = true;
            this.Btn_Adivinhar.Click += new System.EventHandler(this.Btn_Adivinhar_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(12, 12);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(82, 30);
            this.Btn_Voltar.TabIndex = 26;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Lbl_Adivinhe
            // 
            this.Lbl_Adivinhe.AutoSize = true;
            this.Lbl_Adivinhe.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Adivinhe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Adivinhe.Location = new System.Drawing.Point(302, 40);
            this.Lbl_Adivinhe.Name = "Lbl_Adivinhe";
            this.Lbl_Adivinhe.Size = new System.Drawing.Size(164, 40);
            this.Lbl_Adivinhe.TabIndex = 25;
            this.Lbl_Adivinhe.Text = "Adivinhe";
            // 
            // Adivinhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Lbl_NumeroSecreto);
            this.Controls.Add(this.TxtB_Numero);
            this.Controls.Add(this.Lbl_EscolhaNumero);
            this.Controls.Add(this.Btn_Adivinhar);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_Adivinhe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Adivinhe";
            this.Text = "Adivinhe o número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_NumeroSecreto;
        private System.Windows.Forms.TextBox TxtB_Numero;
        private System.Windows.Forms.Label Lbl_EscolhaNumero;
        private System.Windows.Forms.Button Btn_Adivinhar;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_Adivinhe;
    }
}