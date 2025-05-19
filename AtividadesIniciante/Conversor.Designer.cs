namespace AtividadesWindowsForms.AtividadesIniciante
{
    partial class Conversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversor));
            this.Lbl_Conversao = new System.Windows.Forms.Label();
            this.TxtB_Numero = new System.Windows.Forms.TextBox();
            this.Lbl_DigiteONumero = new System.Windows.Forms.Label();
            this.Btn_Converter = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Conversor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Conversao
            // 
            this.Lbl_Conversao.AutoSize = true;
            this.Lbl_Conversao.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Conversao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Conversao.Location = new System.Drawing.Point(12, 189);
            this.Lbl_Conversao.Name = "Lbl_Conversao";
            this.Lbl_Conversao.Size = new System.Drawing.Size(223, 111);
            this.Lbl_Conversao.TabIndex = 30;
            this.Lbl_Conversao.Text = "Metros:\r\n\r\nCentímetros: ";
            this.Lbl_Conversao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtB_Numero
            // 
            this.TxtB_Numero.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.TxtB_Numero.Location = new System.Drawing.Point(15, 109);
            this.TxtB_Numero.Name = "TxtB_Numero";
            this.TxtB_Numero.Size = new System.Drawing.Size(215, 39);
            this.TxtB_Numero.TabIndex = 29;
            // 
            // Lbl_DigiteONumero
            // 
            this.Lbl_DigiteONumero.AutoSize = true;
            this.Lbl_DigiteONumero.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigiteONumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_DigiteONumero.Location = new System.Drawing.Point(16, 90);
            this.Lbl_DigiteONumero.Name = "Lbl_DigiteONumero";
            this.Lbl_DigiteONumero.Size = new System.Drawing.Size(202, 16);
            this.Lbl_DigiteONumero.TabIndex = 28;
            this.Lbl_DigiteONumero.Text = "Digite o valor em metros...";
            // 
            // Btn_Converter
            // 
            this.Btn_Converter.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Converter.Location = new System.Drawing.Point(236, 112);
            this.Btn_Converter.Name = "Btn_Converter";
            this.Btn_Converter.Size = new System.Drawing.Size(108, 33);
            this.Btn_Converter.TabIndex = 27;
            this.Btn_Converter.Text = "Converter";
            this.Btn_Converter.UseVisualStyleBackColor = true;
            this.Btn_Converter.Click += new System.EventHandler(this.Btn_Converter_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(15, 12);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(82, 30);
            this.Btn_Voltar.TabIndex = 26;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Lbl_Conversor
            // 
            this.Lbl_Conversor.AutoSize = true;
            this.Lbl_Conversor.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Conversor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Conversor.Location = new System.Drawing.Point(296, 40);
            this.Lbl_Conversor.Name = "Lbl_Conversor";
            this.Lbl_Conversor.Size = new System.Drawing.Size(181, 40);
            this.Lbl_Conversor.TabIndex = 25;
            this.Lbl_Conversor.Text = "Conversor";
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Lbl_Conversao);
            this.Controls.Add(this.TxtB_Numero);
            this.Controls.Add(this.Lbl_DigiteONumero);
            this.Controls.Add(this.Btn_Converter);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_Conversor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Conversor";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Conversao;
        private System.Windows.Forms.TextBox TxtB_Numero;
        private System.Windows.Forms.Label Lbl_DigiteONumero;
        private System.Windows.Forms.Button Btn_Converter;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_Conversor;
    }
}