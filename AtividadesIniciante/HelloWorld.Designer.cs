namespace AtividadesWindowsForms.AtividadesIniciante
{
    partial class HelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloWorld));
            this.Lbl_AtividadesIniciantes = new System.Windows.Forms.Label();
            this.Tb_Texto = new System.Windows.Forms.TextBox();
            this.Lbl_DigiteAlgo = new System.Windows.Forms.Label();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_AtividadesIniciantes
            // 
            this.Lbl_AtividadesIniciantes.AutoSize = true;
            this.Lbl_AtividadesIniciantes.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AtividadesIniciantes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_AtividadesIniciantes.Location = new System.Drawing.Point(220, 40);
            this.Lbl_AtividadesIniciantes.Name = "Lbl_AtividadesIniciantes";
            this.Lbl_AtividadesIniciantes.Size = new System.Drawing.Size(349, 40);
            this.Lbl_AtividadesIniciantes.TabIndex = 2;
            this.Lbl_AtividadesIniciantes.Text = "Atividades Iniciantes";
            // 
            // Tb_Texto
            // 
            this.Tb_Texto.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Texto.Location = new System.Drawing.Point(208, 273);
            this.Tb_Texto.Name = "Tb_Texto";
            this.Tb_Texto.Size = new System.Drawing.Size(388, 32);
            this.Tb_Texto.TabIndex = 3;
            this.Tb_Texto.TextChanged += new System.EventHandler(this.Tb_Texto_TextChanged);
            // 
            // Lbl_DigiteAlgo
            // 
            this.Lbl_DigiteAlgo.AutoSize = true;
            this.Lbl_DigiteAlgo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigiteAlgo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_DigiteAlgo.Location = new System.Drawing.Point(205, 256);
            this.Lbl_DigiteAlgo.Name = "Lbl_DigiteAlgo";
            this.Lbl_DigiteAlgo.Size = new System.Drawing.Size(138, 14);
            this.Lbl_DigiteAlgo.TabIndex = 4;
            this.Lbl_DigiteAlgo.Text = "Digite algo abaixo...";
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
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Resultado.Location = new System.Drawing.Point(196, 130);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(400, 69);
            this.Lbl_Resultado.TabIndex = 14;
            this.Lbl_Resultado.Text = "Hello, World!";
            this.Lbl_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_DigiteAlgo);
            this.Controls.Add(this.Tb_Texto);
            this.Controls.Add(this.Lbl_AtividadesIniciantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HelloWorld";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_AtividadesIniciantes;
        private System.Windows.Forms.TextBox Tb_Texto;
        private System.Windows.Forms.Label Lbl_DigiteAlgo;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_Resultado;
    }
}