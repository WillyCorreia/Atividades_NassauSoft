using System;
using System.Windows.Forms;

namespace AtividadesWindowsForms.AtividadesJunior
{
    public partial class Primos : Form
    {
        public Primos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Analisar_Click(object sender, EventArgs e)
        {
            Lbl_EPrimo.Text = "";


            if (NumeroValido())
            {
                int numeroEscolhido = int.Parse(TxtB_Numero.Text);
                int multi = 0;

                for (int i = 1; i <= numeroEscolhido; i++)
                {
                    if(numeroEscolhido%i == 0)
                    {
                        multi++;
                    }
                }

                if(multi == 2)
                {
                    Lbl_EPrimo.Text = "É primo!";
                }
                else
                {
                    Lbl_EPrimo.Text = "Não é primo!";
                }
            }
            else
            {
                MessageBox.Show("Número inválido!");
            }
        }

        public bool NumeroValido()
        {
            int numeroValido;
            if (int.TryParse(TxtB_Numero.Text, out numeroValido))
            {
                return true;
            }
            return false;
        }
    }
}
