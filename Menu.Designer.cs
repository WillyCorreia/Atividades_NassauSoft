namespace AtividadesWindowsForms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Lbl_Atividades = new System.Windows.Forms.Label();
            this.Btn_Iniciante = new System.Windows.Forms.Button();
            this.Btn_Junior = new System.Windows.Forms.Button();
            this.Btn_Avancado = new System.Windows.Forms.Button();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Atividades
            // 
            this.Lbl_Atividades.AutoSize = true;
            this.Lbl_Atividades.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Atividades.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Atividades.Location = new System.Drawing.Point(300, 40);
            this.Lbl_Atividades.Name = "Lbl_Atividades";
            this.Lbl_Atividades.Size = new System.Drawing.Size(187, 40);
            this.Lbl_Atividades.TabIndex = 0;
            this.Lbl_Atividades.Text = "Atividades";
            // 
            // Btn_Iniciante
            // 
            this.Btn_Iniciante.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Iniciante.Location = new System.Drawing.Point(41, 151);
            this.Btn_Iniciante.Name = "Btn_Iniciante";
            this.Btn_Iniciante.Size = new System.Drawing.Size(200, 125);
            this.Btn_Iniciante.TabIndex = 1;
            this.Btn_Iniciante.Text = "Iniciante";
            this.Btn_Iniciante.UseVisualStyleBackColor = true;
            this.Btn_Iniciante.Click += new System.EventHandler(this.Btn_Iniciante_Click);
            // 
            // Btn_Junior
            // 
            this.Btn_Junior.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Junior.Location = new System.Drawing.Point(291, 151);
            this.Btn_Junior.Name = "Btn_Junior";
            this.Btn_Junior.Size = new System.Drawing.Size(200, 125);
            this.Btn_Junior.TabIndex = 2;
            this.Btn_Junior.Text = "Junior";
            this.Btn_Junior.UseVisualStyleBackColor = true;
            this.Btn_Junior.Click += new System.EventHandler(this.Btn_Junior_Click);
            // 
            // Btn_Avancado
            // 
            this.Btn_Avancado.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Avancado.Location = new System.Drawing.Point(541, 151);
            this.Btn_Avancado.Name = "Btn_Avancado";
            this.Btn_Avancado.Size = new System.Drawing.Size(200, 125);
            this.Btn_Avancado.TabIndex = 3;
            this.Btn_Avancado.Text = "Avançado";
            this.Btn_Avancado.UseVisualStyleBackColor = true;
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.Location = new System.Drawing.Point(690, 319);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(82, 30);
            this.Btn_Fechar.TabIndex = 13;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Btn_Avancado);
            this.Controls.Add(this.Btn_Junior);
            this.Controls.Add(this.Btn_Iniciante);
            this.Controls.Add(this.Lbl_Atividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Atividades;
        private System.Windows.Forms.Button Btn_Iniciante;
        private System.Windows.Forms.Button Btn_Junior;
        private System.Windows.Forms.Button Btn_Avancado;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}