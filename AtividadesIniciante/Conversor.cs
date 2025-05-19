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
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Converter_Click(object sender, EventArgs e)
        {
            Lbl_Conversao.Text = $"Metros: \n\nCentimetros: ";


            double numeroValido, metros, centimetros;

            if (double.TryParse(TxtB_Numero.Text, out numeroValido))
            {
                metros = double.Parse(TxtB_Numero.Text);
                centimetros = metros * 100;

                Lbl_Conversao.Text = $"Metros: {metros}m\n\nCentimetros: {centimetros}cm";
            }
            else
            {
                MessageBox.Show("Número Inválido");
            }
        }
    }
}
