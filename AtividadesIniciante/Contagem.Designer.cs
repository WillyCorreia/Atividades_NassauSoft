namespace AtividadesWindowsForms.AtividadesIniciante
{
    partial class Contagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contagem));
            this.TxtB_Contador = new System.Windows.Forms.TextBox();
            this.Lbl_PrimeiroNumero = new System.Windows.Forms.Label();
            this.Btn_IniciarContagem = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Contagem = new System.Windows.Forms.Label();
            this.Lbl_Contando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtB_Contador
            // 
            this.TxtB_Contador.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.TxtB_Contador.Location = new System.Drawing.Point(15, 109);
            this.TxtB_Contador.Name = "TxtB_Contador";
            this.TxtB_Contador.Size = new System.Drawing.Size(215, 39);
            this.TxtB_Contador.TabIndex = 23;
            // 
            // Lbl_PrimeiroNumero
            // 
            this.Lbl_PrimeiroNumero.AutoSize = true;
            this.Lbl_PrimeiroNumero.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PrimeiroNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_PrimeiroNumero.Location = new System.Drawing.Point(51, 90);
            this.Lbl_PrimeiroNumero.Name = "Lbl_PrimeiroNumero";
            this.Lbl_PrimeiroNumero.Size = new System.Drawing.Size(149, 16);
            this.Lbl_PrimeiroNumero.TabIndex = 22;
            this.Lbl_PrimeiroNumero.Text = "Digite o contador...";
            // 
            // Btn_IniciarContagem
            // 
            this.Btn_IniciarContagem.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IniciarContagem.Location = new System.Drawing.Point(236, 115);
            this.Btn_IniciarContagem.Name = "Btn_IniciarContagem";
            this.Btn_IniciarContagem.Size = new System.Drawing.Size(204, 33);
            this.Btn_IniciarContagem.TabIndex = 21;
            this.Btn_IniciarContagem.Text = "Iniciar Contagem";
            this.Btn_IniciarContagem.UseVisualStyleBackColor = true;
            this.Btn_IniciarContagem.Click += new System.EventHandler(this.Btn_IniciarContagem_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(15, 12);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(82, 30);
            this.Btn_Voltar.TabIndex = 20;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Lbl_Contagem
            // 
            this.Lbl_Contagem.AutoSize = true;
            this.Lbl_Contagem.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contagem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Contagem.Location = new System.Drawing.Point(305, 40);
            this.Lbl_Contagem.Name = "Lbl_Contagem";
            this.Lbl_Contagem.Size = new System.Drawing.Size(178, 40);
            this.Lbl_Contagem.TabIndex = 19;
            this.Lbl_Contagem.Text = "Contagem";
            // 
            // Lbl_Contando
            // 
            this.Lbl_Contando.AutoSize = true;
            this.Lbl_Contando.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contando.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Contando.Location = new System.Drawing.Point(300, 220);
            this.Lbl_Contando.Name = "Lbl_Contando";
            this.Lbl_Contando.Size = new System.Drawing.Size(0, 69);
            this.Lbl_Contando.TabIndex = 24;
            this.Lbl_Contando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Contagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Lbl_Contando);
            this.Controls.Add(this.TxtB_Contador);
            this.Controls.Add(this.Lbl_PrimeiroNumero);
            this.Controls.Add(this.Btn_IniciarContagem);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_Contagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Contagem";
            this.Text = "Contagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtB_Contador;
        private System.Windows.Forms.Label Lbl_PrimeiroNumero;
        private System.Windows.Forms.Button Btn_IniciarContagem;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_Contagem;
        private System.Windows.Forms.Label Lbl_Contando;
    }
}