namespace AtividadesWindowsForms.AtividadesJunior
{
    partial class Fatorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatorial));
            this.Lbl_Fatoracao = new System.Windows.Forms.Label();
            this.TxtB_Numero = new System.Windows.Forms.TextBox();
            this.Lbl_EscolhaNumero = new System.Windows.Forms.Label();
            this.Btn_Fatorar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Fatorial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Fatoracao
            // 
            this.Lbl_Fatoracao.AutoSize = true;
            this.Lbl_Fatoracao.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fatoracao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Fatoracao.Location = new System.Drawing.Point(129, 241);
            this.Lbl_Fatoracao.Name = "Lbl_Fatoracao";
            this.Lbl_Fatoracao.Size = new System.Drawing.Size(0, 40);
            this.Lbl_Fatoracao.TabIndex = 44;
            this.Lbl_Fatoracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtB_Numero
            // 
            this.TxtB_Numero.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.TxtB_Numero.Location = new System.Drawing.Point(281, 107);
            this.TxtB_Numero.Name = "TxtB_Numero";
            this.TxtB_Numero.Size = new System.Drawing.Size(215, 39);
            this.TxtB_Numero.TabIndex = 42;
            // 
            // Lbl_EscolhaNumero
            // 
            this.Lbl_EscolhaNumero.AutoSize = true;
            this.Lbl_EscolhaNumero.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EscolhaNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_EscolhaNumero.Location = new System.Drawing.Point(263, 88);
            this.Lbl_EscolhaNumero.Name = "Lbl_EscolhaNumero";
            this.Lbl_EscolhaNumero.Size = new System.Drawing.Size(250, 16);
            this.Lbl_EscolhaNumero.TabIndex = 41;
            this.Lbl_EscolhaNumero.Text = "Escolha um número de 0 até 20...";
            // 
            // Btn_Fatorar
            // 
            this.Btn_Fatorar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fatorar.Location = new System.Drawing.Point(342, 152);
            this.Btn_Fatorar.Name = "Btn_Fatorar";
            this.Btn_Fatorar.Size = new System.Drawing.Size(88, 33);
            this.Btn_Fatorar.TabIndex = 40;
            this.Btn_Fatorar.Text = "Fatorar";
            this.Btn_Fatorar.UseVisualStyleBackColor = true;
            this.Btn_Fatorar.Click += new System.EventHandler(this.Btn_Fatorar_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(12, 12);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(82, 30);
            this.Btn_Voltar.TabIndex = 39;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Lbl_Fatorial
            // 
            this.Lbl_Fatorial.AutoSize = true;
            this.Lbl_Fatorial.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fatorial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Fatorial.Location = new System.Drawing.Point(200, 40);
            this.Lbl_Fatorial.Name = "Lbl_Fatorial";
            this.Lbl_Fatorial.Size = new System.Drawing.Size(376, 40);
            this.Lbl_Fatorial.TabIndex = 38;
            this.Lbl_Fatorial.Text = "Fatorial de um número";
            // 
            // Fatorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Lbl_Fatoracao);
            this.Controls.Add(this.TxtB_Numero);
            this.Controls.Add(this.Lbl_EscolhaNumero);
            this.Controls.Add(this.Btn_Fatorar);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_Fatorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fatorial";
            this.Text = "Fatorial de um número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Fatoracao;
        private System.Windows.Forms.TextBox TxtB_Numero;
        private System.Windows.Forms.Label Lbl_EscolhaNumero;
        private System.Windows.Forms.Button Btn_Fatorar;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_Fatorial;
    }
}