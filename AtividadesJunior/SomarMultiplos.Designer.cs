namespace AtividadesWindowsForms.AtividadesJunior
{
    partial class SomarMultiplos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomarMultiplos));
            this.Lbl_Multiplos = new System.Windows.Forms.Label();
            this.TxtB_Numero = new System.Windows.Forms.TextBox();
            this.Lbl_EscolhaNumero = new System.Windows.Forms.Label();
            this.Btn_Somar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_SomarMultiplos = new System.Windows.Forms.Label();
            this.Lbl_Soma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Multiplos
            // 
            this.Lbl_Multiplos.AutoSize = true;
            this.Lbl_Multiplos.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Multiplos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Multiplos.Location = new System.Drawing.Point(8, 197);
            this.Lbl_Multiplos.Name = "Lbl_Multiplos";
            this.Lbl_Multiplos.Size = new System.Drawing.Size(0, 20);
            this.Lbl_Multiplos.TabIndex = 36;
            this.Lbl_Multiplos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtB_Numero
            // 
            this.TxtB_Numero.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.TxtB_Numero.Location = new System.Drawing.Point(281, 107);
            this.TxtB_Numero.Name = "TxtB_Numero";
            this.TxtB_Numero.Size = new System.Drawing.Size(215, 39);
            this.TxtB_Numero.TabIndex = 35;
            // 
            // Lbl_EscolhaNumero
            // 
            this.Lbl_EscolhaNumero.AutoSize = true;
            this.Lbl_EscolhaNumero.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EscolhaNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_EscolhaNumero.Location = new System.Drawing.Point(258, 88);
            this.Lbl_EscolhaNumero.Name = "Lbl_EscolhaNumero";
            this.Lbl_EscolhaNumero.Size = new System.Drawing.Size(259, 16);
            this.Lbl_EscolhaNumero.TabIndex = 34;
            this.Lbl_EscolhaNumero.Text = "Escolha um número de 0 até 100...";
            // 
            // Btn_Somar
            // 
            this.Btn_Somar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Somar.Location = new System.Drawing.Point(348, 152);
            this.Btn_Somar.Name = "Btn_Somar";
            this.Btn_Somar.Size = new System.Drawing.Size(79, 33);
            this.Btn_Somar.TabIndex = 33;
            this.Btn_Somar.Text = "Somar";
            this.Btn_Somar.UseVisualStyleBackColor = true;
            this.Btn_Somar.Click += new System.EventHandler(this.Btn_Somar_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(12, 12);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(82, 30);
            this.Btn_Voltar.TabIndex = 32;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Lbl_SomarMultiplos
            // 
            this.Lbl_SomarMultiplos.AutoSize = true;
            this.Lbl_SomarMultiplos.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SomarMultiplos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_SomarMultiplos.Location = new System.Drawing.Point(134, 40);
            this.Lbl_SomarMultiplos.Name = "Lbl_SomarMultiplos";
            this.Lbl_SomarMultiplos.Size = new System.Drawing.Size(527, 40);
            this.Lbl_SomarMultiplos.TabIndex = 31;
            this.Lbl_SomarMultiplos.Text = "Soma de multiplos entre 0 e 100";
            // 
            // Lbl_Soma
            // 
            this.Lbl_Soma.AutoSize = true;
            this.Lbl_Soma.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Soma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Soma.Location = new System.Drawing.Point(274, 312);
            this.Lbl_Soma.Name = "Lbl_Soma";
            this.Lbl_Soma.Size = new System.Drawing.Size(0, 40);
            this.Lbl_Soma.TabIndex = 37;
            this.Lbl_Soma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SomarMultiplos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Lbl_Soma);
            this.Controls.Add(this.Lbl_Multiplos);
            this.Controls.Add(this.TxtB_Numero);
            this.Controls.Add(this.Lbl_EscolhaNumero);
            this.Controls.Add(this.Btn_Somar);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_SomarMultiplos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SomarMultiplos";
            this.Text = "Somar Multiplos entre 0 e 100";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Multiplos;
        private System.Windows.Forms.TextBox TxtB_Numero;
        private System.Windows.Forms.Label Lbl_EscolhaNumero;
        private System.Windows.Forms.Button Btn_Somar;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_SomarMultiplos;
        private System.Windows.Forms.Label Lbl_Soma;
    }
}