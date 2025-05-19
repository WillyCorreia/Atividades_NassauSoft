using System;
using System.Windows.Forms;

namespace AtividadesWindowsForms.AtividadesIniciante
{
    public partial class Soma : Form
    {
        public Soma()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Somar_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";

            double numeroValido, PrimeiroNumero, SegundoNumero, Soma;

            if (double.TryParse(TxtB_PrimeiroNumero.Text, out numeroValido) && double.TryParse(TxtB_SegundoNumero.Text, out numeroValido))
            {
                PrimeiroNumero = double.Parse(TxtB_PrimeiroNumero.Text);
                SegundoNumero = double.Parse(TxtB_SegundoNumero.Text);

                Soma = PrimeiroNumero + SegundoNumero;

                Lbl_Resultado.Text = Soma.ToString();
            }
            else
            {
                if(double.TryParse(TxtB_PrimeiroNumero.Text, out numeroValido))
                {
                    MessageBox.Show("Segundo Número Inválido");
                }
                else if(double.TryParse(TxtB_SegundoNumero.Text, out numeroValido))
                {
                    MessageBox.Show("Primeiro Número Inválido");
                }
                else
                {
                    MessageBox.Show("Os Dois Números Estão Inválidos");
                }
            }
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbl_PrimeiroNumero_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Resultado_Click(object sender, EventArgs e)
        {

        }

        private void TxtB_PrimeiroNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
