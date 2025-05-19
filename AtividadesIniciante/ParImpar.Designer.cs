namespace AtividadesWindowsForms.AtividadesIniciante
{
    partial class ParImpar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParImpar));
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_ParOuImpar = new System.Windows.Forms.Label();
            this.TxtB_Numero = new System.Windows.Forms.TextBox();
            this.Lbl_PrimeiroNumero = new System.Windows.Forms.Label();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Btn_Somar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(15, 12);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(82, 30);
            this.Btn_Voltar.TabIndex = 14;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Lbl_ParOuImpar
            // 
            this.Lbl_ParOuImpar.AutoSize = true;
            this.Lbl_ParOuImpar.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ParOuImpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_ParOuImpar.Location = new System.Drawing.Point(274, 40);
            this.Lbl_ParOuImpar.Name = "Lbl_ParOuImpar";
            this.Lbl_ParOuImpar.Size = new System.Drawing.Size(222, 40);
            this.Lbl_ParOuImpar.TabIndex = 13;
            this.Lbl_ParOuImpar.Text = "Par ou Ímpar";
            // 
            // TxtB_Numero
            // 
            this.TxtB_Numero.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.TxtB_Numero.Location = new System.Drawing.Point(281, 141);
            this.TxtB_Numero.Name = "TxtB_Numero";
            this.TxtB_Numero.Size = new System.Drawing.Size(215, 39);
            this.TxtB_Numero.TabIndex = 18;
            // 
            // Lbl_PrimeiroNumero
            // 
            this.Lbl_PrimeiroNumero.AutoSize = true;
            this.Lbl_PrimeiroNumero.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PrimeiroNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_PrimeiroNumero.Location = new System.Drawing.Point(317, 122);
            this.Lbl_PrimeiroNumero.Name = "Lbl_PrimeiroNumero";
            this.Lbl_PrimeiroNumero.Size = new System.Drawing.Size(140, 16);
            this.Lbl_PrimeiroNumero.TabIndex = 17;
            this.Lbl_PrimeiroNumero.Text = "Digite o número...";
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Resultado.Location = new System.Drawing.Point(308, 257);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 69);
            this.Lbl_Resultado.TabIndex = 16;
            this.Lbl_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Somar
            // 
            this.Btn_Somar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Somar.Location = new System.Drawing.Point(339, 204);
            this.Btn_Somar.Name = "Btn_Somar";
            this.Btn_Somar.Size = new System.Drawing.Size(101, 33);
            this.Btn_Somar.TabIndex = 15;
            this.Btn_Somar.Text = "Analisar";
            this.Btn_Somar.UseVisualStyleBackColor = true;
            this.Btn_Somar.Click += new System.EventHandler(this.Btn_Somar_Click);
            // 
            // ParImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.TxtB_Numero);
            this.Controls.Add(this.Lbl_PrimeiroNumero);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Btn_Somar);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_ParOuImpar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ParImpar";
            this.Text = "Par ou Ímpar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_ParOuImpar;
        private System.Windows.Forms.TextBox TxtB_Numero;
        private System.Windows.Forms.Label Lbl_PrimeiroNumero;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Button Btn_Somar;
    }
}