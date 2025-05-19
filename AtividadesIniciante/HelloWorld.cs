using System;
using System.Windows.Forms;

namespace AtividadesWindowsForms.AtividadesIniciante
{
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Console.WriteLine("Hello, World!");
        }

        private void Tb_Texto_TextChanged(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Tb_Texto.Text;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
