using System;
using System.Windows.Forms;

namespace AtividadesWindowsForms.AtividadesJunior
{
    public partial class SomarMultiplos : Form
    {
        public SomarMultiplos()
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
            Lbl_Multiplos.Text = "";
            Lbl_Soma.Text = "";
            int soma = 0;
            int pularLinha = 0;

            

            if (NumeroValido())
            {
                int numeroEscolhido = int.Parse(TxtB_Numero.Text);
                for (int i = 0; i <= 100; i++)
                {
                    if (numeroEscolhido != 0 && i % numeroEscolhido == 0)
                    {
                        if(pularLinha == 22)
                        {
                            Lbl_Multiplos.Text += $"\n{i}//";
                            soma += i;
                            pularLinha = 0;
                        }
                        else
                        {
                            Lbl_Multiplos.Text += $"{i}//";
                            soma += i;
                        } 
                        pularLinha++;
                    }
                    else if(numeroEscolhido == 0)
                    {
                        Lbl_Multiplos.Text = "0";
                        soma = 0;
                    }
                }
                Lbl_Soma.Text = $"Soma: {soma}";
            }
            else
            {
                MessageBox.Show("Número inválido!");
            }
        }

        public bool NumeroValido()
        {
            int numeroValido, numeroEscolhido;
            if (int.TryParse(TxtB_Numero.Text, out numeroValido))
            {
                numeroEscolhido = int.Parse(TxtB_Numero.Text);
                if (numeroEscolhido >= 0 && numeroValido <= 100)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
