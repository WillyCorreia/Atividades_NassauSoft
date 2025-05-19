namespace AtividadesWindowsForms.AtividadesIniciante
{
    partial class Tabuada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabuada));
            this.TxtB_Numero = new System.Windows.Forms.TextBox();
            this.Lbl_PrimeiroNumero = new System.Windows.Forms.Label();
            this.Btn_Analisar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Tabuada = new System.Windows.Forms.Label();
            this.Lbl_Coluna1 = new System.Windows.Forms.Label();
            this.Lbl_Coluna2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtB_Numero
            // 
            this.TxtB_Numero.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.TxtB_Numero.Location = new System.Drawing.Point(12, 106);
            this.TxtB_Numero.Name = "TxtB_Numero";
            this.TxtB_Numero.Size = new System.Drawing.Size(215, 39);
            this.TxtB_Numero.TabIndex = 23;
            // 
            // Lbl_PrimeiroNumero
            // 
            this.Lbl_PrimeiroNumero.AutoSize = true;
            this.Lbl_PrimeiroNumero.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PrimeiroNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_PrimeiroNumero.Location = new System.Drawing.Point(48, 87);
            this.Lbl_PrimeiroNumero.Name = "Lbl_PrimeiroNumero";
            this.Lbl_PrimeiroNumero.Size = new System.Drawing.Size(140, 16);
            this.Lbl_PrimeiroNumero.TabIndex = 22;
            this.Lbl_PrimeiroNumero.Text = "Digite o número...";
            // 
            // Btn_Analisar
            // 
            this.Btn_Analisar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Analisar.Location = new System.Drawing.Point(245, 109);
            this.Btn_Analisar.Name = "Btn_Analisar";
            this.Btn_Analisar.Size = new System.Drawing.Size(101, 33);
            this.Btn_Analisar.TabIndex = 21;
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
            this.Btn_Voltar.TabIndex = 20;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Lbl_Tabuada
            // 
            this.Lbl_Tabuada.AutoSize = true;
            this.Lbl_Tabuada.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tabuada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Tabuada.Location = new System.Drawing.Point(315, 40);
            this.Lbl_Tabuada.Name = "Lbl_Tabuada";
            this.Lbl_Tabuada.Size = new System.Drawing.Size(152, 40);
            this.Lbl_Tabuada.TabIndex = 19;
            this.Lbl_Tabuada.Text = "Tabuada";
            // 
            // Lbl_Coluna1
            // 
            this.Lbl_Coluna1.AutoSize = true;
            this.Lbl_Coluna1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Coluna1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Coluna1.Location = new System.Drawing.Point(12, 160);
            this.Lbl_Coluna1.Name = "Lbl_Coluna1";
            this.Lbl_Coluna1.Size = new System.Drawing.Size(35, 144);
            this.Lbl_Coluna1.TabIndex = 24;
            this.Lbl_Coluna1.Text = "x1: \r\n\r\nx2: \r\n\r\nx3: \r\n\r\nx4: \r\n\r\nx5: \r\n";
            this.Lbl_Coluna1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Coluna2
            // 
            this.Lbl_Coluna2.AutoSize = true;
            this.Lbl_Coluna2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Coluna2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Coluna2.Location = new System.Drawing.Point(390, 160);
            this.Lbl_Coluna2.Name = "Lbl_Coluna2";
            this.Lbl_Coluna2.Size = new System.Drawing.Size(44, 144);
            this.Lbl_Coluna2.TabIndex = 29;
            this.Lbl_Coluna2.Text = "x6: \r\n\r\nx7: \r\n\r\nx8: \r\n\r\nx9: \r\n\r\nx10: ";
            this.Lbl_Coluna2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Lbl_Coluna2);
            this.Controls.Add(this.Lbl_Coluna1);
            this.Controls.Add(this.TxtB_Numero);
            this.Controls.Add(this.Lbl_PrimeiroNumero);
            this.Controls.Add(this.Btn_Analisar);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_Tabuada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tabuada";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtB_Numero;
        private System.Windows.Forms.Label Lbl_PrimeiroNumero;
        private System.Windows.Forms.Button Btn_Analisar;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_Tabuada;
        private System.Windows.Forms.Label Lbl_Coluna1;
        private System.Windows.Forms.Label Lbl_Coluna2;
    }
}