using AtividadesWindowsForms.AtividadesIniciante;
using System;
using System.Windows.Forms;

namespace AtividadesWindowsForms
{
    public partial class Menu_Iniciante : Form
    {
        public Menu_Iniciante()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_HelloWorld_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new HelloWorld());
        }

        private void Btn_Soma_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Soma());
        }

        private void Btn_Media_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Media());
        }

        private void Btn_ParImpar_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new ParImpar());
        }

        private void Btn_Maior_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Maior());
        }

        private void Btn_Tabuada_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Tabuada());
        }

        private void Btn_Contagem_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Contagem());
        }

        private void Btn_MetroCentrimetros_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Conversor());
        }

        private void Btn_Idade_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Idade());
        }

        private void Btn_MaiorIdade_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new MaiorIdade());
        }
    }
}
