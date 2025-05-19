namespace AtividadesWindowsForms.AtividadesIniciante
{
    partial class Soma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Soma));
            this.Lbl_Soma = new System.Windows.Forms.Label();
            this.Btn_Somar = new System.Windows.Forms.Button();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Lbl_PrimeiroNumero = new System.Windows.Forms.Label();
            this.Lbl_SegundoNumero = new System.Windows.Forms.Label();
            this.TxtB_PrimeiroNumero = new System.Windows.Forms.TextBox();
            this.TxtB_SegundoNumero = new System.Windows.Forms.TextBox();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Soma
            // 
            this.Lbl_Soma.AutoSize = true;
            this.Lbl_Soma.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Soma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Soma.Location = new System.Drawing.Point(169, 40);
            this.Lbl_Soma.Name = "Lbl_Soma";
            this.Lbl_Soma.Size = new System.Drawing.Size(438, 40);
            this.Lbl_Soma.TabIndex = 2;
            this.Lbl_Soma.Text = "Soma Entre Dois Números";
            // 
            // Btn_Somar
            // 
            this.Btn_Somar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Somar.Location = new System.Drawing.Point(341, 180);
            this.Btn_Somar.Name = "Btn_Somar";
            this.Btn_Somar.Size = new System.Drawing.Size(101, 33);
            this.Btn_Somar.TabIndex = 5;
            this.Btn_Somar.Text = "Somar";
            this.Btn_Somar.UseVisualStyleBackColor = true;
            this.Btn_Somar.Click += new System.EventHandler(this.Btn_Somar_Click);
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Resultado.Location = new System.Drawing.Point(310, 239);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 69);
            this.Lbl_Resultado.TabIndex = 6;
            this.Lbl_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Resultado.Click += new System.EventHandler(this.Lbl_Resultado_Click);
            // 
            // Lbl_PrimeiroNumero
            // 
            this.Lbl_PrimeiroNumero.AutoSize = true;
            this.Lbl_PrimeiroNumero.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PrimeiroNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_PrimeiroNumero.Location = new System.Drawing.Point(106, 104);
            this.Lbl_PrimeiroNumero.Name = "Lbl_PrimeiroNumero";
            this.Lbl_PrimeiroNumero.Size = new System.Drawing.Size(206, 16);
            this.Lbl_PrimeiroNumero.TabIndex = 7;
            this.Lbl_PrimeiroNumero.Text = "Digite o primeiro número...";
            this.Lbl_PrimeiroNumero.Click += new System.EventHandler(this.Lbl_PrimeiroNumero_Click);
            // 
            // Lbl_SegundoNumero
            // 
            this.Lbl_SegundoNumero.AutoSize = true;
            this.Lbl_SegundoNumero.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SegundoNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_SegundoNumero.Location = new System.Drawing.Point(467, 104);
            this.Lbl_SegundoNumero.Name = "Lbl_SegundoNumero";
            this.Lbl_SegundoNumero.Size = new System.Drawing.Size(205, 16);
            this.Lbl_SegundoNumero.TabIndex = 8;
            this.Lbl_SegundoNumero.Text = "Digite o segundo número...";
            // 
            // TxtB_PrimeiroNumero
            // 
            this.TxtB_PrimeiroNumero.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.TxtB_PrimeiroNumero.Location = new System.Drawing.Point(109, 123);
            this.TxtB_PrimeiroNumero.Name = "TxtB_PrimeiroNumero";
            this.TxtB_PrimeiroNumero.Size = new System.Drawing.Size(203, 39);
            this.TxtB_PrimeiroNumero.TabIndex = 11;
            this.TxtB_PrimeiroNumero.TextChanged += new System.EventHandler(this.TxtB_PrimeiroNumero_TextChanged);
            // 
            // TxtB_SegundoNumero
            // 
            this.TxtB_SegundoNumero.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.TxtB_SegundoNumero.Location = new System.Drawing.Point(470, 123);
            this.TxtB_SegundoNumero.Name = "TxtB_SegundoNumero";
            this.TxtB_SegundoNumero.Size = new System.Drawing.Size(202, 39);
            this.TxtB_SegundoNumero.TabIndex = 12;
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(15, 12);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(82, 30);
            this.Btn_Voltar.TabIndex = 13;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Soma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.TxtB_SegundoNumero);
            this.Controls.Add(this.TxtB_PrimeiroNumero);
            this.Controls.Add(this.Lbl_SegundoNumero);
            this.Controls.Add(this.Lbl_PrimeiroNumero);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Btn_Somar);
            this.Controls.Add(this.Lbl_Soma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Soma";
            this.Text = "Soma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Soma;
        private System.Windows.Forms.Button Btn_Somar;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Label Lbl_PrimeiroNumero;
        private System.Windows.Forms.Label Lbl_SegundoNumero;
        private System.Windows.Forms.TextBox TxtB_PrimeiroNumero;
        private System.Windows.Forms.TextBox TxtB_SegundoNumero;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}