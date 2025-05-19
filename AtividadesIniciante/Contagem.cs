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
    public partial class Contagem : Form
    {
        public Contagem()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Btn_IniciarContagem_Click(object sender, EventArgs e)
        {
            Lbl_Contando.Text = "";

            int numeroValido, numero;
            int contador = 0;

            if (int.TryParse(TxtB_Contador.Text, out numeroValido))
            {
                numero = int.Parse(TxtB_Contador.Text);

                if (numero > 0)
                {
                    int delei = 1000;
                    delei = delei / numero;

                    while(contador <= numero)
                    {
                        Lbl_Contando.Text = contador.ToString();
                        await Task.Delay(delei);
                        contador++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Número Inválido");
            }
        }
    }
}
