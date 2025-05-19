using AtividadesWindowsForms.AtividadesJunior;
using System;
using System.Windows.Forms;

namespace AtividadesWindowsForms
{
    public partial class Menu_Junior : Form
    {
        public Menu_Junior()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_SomaMultiplos_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new SomarMultiplos());
        }

        private void Btn_Fatorial_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Fatorial());
        }

        private void Btn_Primos_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Primos());
        }

        private void Btn_Ordenacao_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Ordenacao());
        }

        private void Btn_ContadorVogais_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Contador());
        }

        private void Btn_Calculadora_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Calculadora());
        }

        private void Btn_Adivinhe_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Adivinhe());
        }

        private void Btn_Fibonacci_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Fibonacci());
        }

        private void Btn_Palindromo_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Palindromo());
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            AbrirForm.abrir_Form(this, new Cadastro());
        }
    }
}
