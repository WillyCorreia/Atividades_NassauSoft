using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadesWindowsForms.AtividadesIniciante
{
    public partial class Maior : Form
    {
        public Maior()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Verificar_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";

            double numeroValido, PrimeiroNumero, SegundoNumero;

            if (double.TryParse(TxtB_PrimeiroNumero.Text, out numeroValido) && double.TryParse(TxtB_SegundoNumero.Text, out numeroValido))
            {
                PrimeiroNumero = double.Parse(TxtB_PrimeiroNumero.Text);
                SegundoNumero = double.Parse(TxtB_SegundoNumero.Text);

                if( PrimeiroNumero > SegundoNumero )
                {
                    Lbl_Resultado.Text = "O primeiro número é maior";
                }
                else if( SegundoNumero > PrimeiroNumero )
                {
                    Lbl_Resultado.Text = "O segundo número é maior";
                }
                else
                {
                    Lbl_Resultado.Text = "Os números são iguais";
                }
            }
            else
            {
                if (double.TryParse(TxtB_PrimeiroNumero.Text, out numeroValido))
                {
                    MessageBox.Show("Segundo Número Inválido");
                }
                else if (double.TryParse(TxtB_SegundoNumero.Text, out numeroValido))
                {
                    MessageBox.Show("Primeiro Número Inválido");
                }
                else
                {
                    MessageBox.Show("Os Dois Números Estão Inválidos");
                }
            }
        }
    }
}
