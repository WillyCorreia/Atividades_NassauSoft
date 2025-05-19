using System;
using System.Windows.Forms;

namespace AtividadesWindowsForms.AtividadesIniciante
{
    public partial class Media : Form
    {
        public Media()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_CalcularMedia_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";

            double numeroTeste, n1, n2, n3, media;

            if(double.TryParse(TxtB_PrimeiroNumero.Text, out numeroTeste) && double.TryParse(TxtB_SegundoNumero.Text, out numeroTeste) && double.TryParse(TxtB_TerceiroNumero.Text, out numeroTeste))
            {
                n1 = double.Parse(TxtB_PrimeiroNumero.Text);
                n2 = double.Parse(TxtB_SegundoNumero.Text);
                n3 = double.Parse(TxtB_TerceiroNumero.Text);

                media = (n1 + n2 + n3) / 3;

                Lbl_Resultado.Text = media.ToString();
            }else
            {
                MessageBox.Show("Existe um número inválido");
            }
        }
    }
}
