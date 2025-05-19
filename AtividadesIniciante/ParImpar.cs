using System;
using System.Windows.Forms;

namespace AtividadesWindowsForms.AtividadesIniciante
{
    public partial class ParImpar : Form
    {
        public ParImpar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Somar_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";

            double numeroValido, numero;

            if (double.TryParse(TxtB_Numero.Text, out numeroValido))
            {
                numero = double.Parse(TxtB_Numero.Text);

                if (numero % 2 == 0)
                {
                    Lbl_Resultado.Text = "Par";
                }
                else
                {
                    Lbl_Resultado.Text = "Ímpar";
                }
            }
            else
            {
                MessageBox.Show("Número Inválido");
            }
        }
    }
}
