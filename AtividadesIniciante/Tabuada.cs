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
    public partial class Tabuada : Form
    {
        public Tabuada()
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
            double numeroValido, numero = 0;

            looping(numero);

            if (double.TryParse(TxtB_Numero.Text, out numeroValido))
            {
                numero = double.Parse(TxtB_Numero.Text);

                looping(numero);
            }
            else
            {
                MessageBox.Show("Número Inválido");
            }
        }

        public void looping(double numero)
        {
            double resultado;

            for (int i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                if (i == 1)
                {
                    Lbl_Coluna1.Text = $"x{i}: {resultado} \n \n";
                }
                else if (i < 5)
                {
                    Lbl_Coluna1.Text += $"x{i}: {resultado} \n \n";
                }
                else if (i == 5)
                {
                    Lbl_Coluna1.Text += $"x{i}: {resultado}";
                }
                else if(i == 6)
                {
                    Lbl_Coluna2.Text = $"x{i}: {resultado} \n \n";
                }
                else if(i < 10)
                {
                    Lbl_Coluna2.Text += $"x{i}: {resultado} \n \n";
                }
                else
                {
                    Lbl_Coluna2.Text += $"x{i}: {resultado}";
                }
            }
        }
    }
}
