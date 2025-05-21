using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadesWindowsForms.AtividadesJunior
{
    public partial class Fatorial : Form
    {
        public Fatorial()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Fatorar_Click(object sender, EventArgs e)
        {
            long fatorial = 1;
            Lbl_Fatoracao.Text = "";

            if (NumeroValido())
            {
                int numeroEscolhido = int.Parse(TxtB_Numero.Text);
                if(numeroEscolhido == 0)
                {
                    fatorial = 0;
                }
                else
                {
                    for (int i = 1; i <= numeroEscolhido; i++)
                    {
                        fatorial *= i;
                    }
                }

                Lbl_Fatoracao.Text = $"Fatorial: {fatorial}";
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
                int numeroEscolhido = int.Parse(TxtB_Numero.Text);
                if (numeroEscolhido >= 0 && numeroEscolhido <=20)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
