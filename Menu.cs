using System;
using System.Windows.Forms;

namespace AtividadesWindowsForms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Iniciante_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Menu_Iniciante());
        }

        private void Btn_Junior_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Menu_Junior());
        }
    }
}
