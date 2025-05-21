using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadesWindowsForms.AtividadesJunior
{
    public partial class Adivinhe : Form
    {
        public int NumeroSecreto;
        Random random = new Random();

        public Adivinhe()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            TrocarNumeroSecreto();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Btn_Adivinhar_Click(object sender, EventArgs e)
        {
            Lbl_NumeroSecreto.Text = "";
            int numeroEscolhido;

            if (NumeroValido())
            {
                numeroEscolhido = int.Parse(TxtB_Numero.Text);

                if (numeroEscolhido == NumeroSecreto)
                {
                    Lbl_NumeroSecreto.Text = "Parabéns, você acertou o número secreto!";

                    await Task.Delay(1000);
                    MessageBox.Show("Parabéns, você acertou o número secreto! Agora ele irá trocar!");

                    TrocarNumeroSecreto();
                }
                else if(numeroEscolhido > NumeroSecreto)
                {
                    Lbl_NumeroSecreto.Text = "O número secreto é menor!";
                }
                else
                {
                    Lbl_NumeroSecreto.Text = "O número secreto é maior!";
                }
            }
            else
            {
                MessageBox.Show("Número Inválido");
            }
        }

        public void TrocarNumeroSecreto()
        {
            NumeroSecreto = random.Next(1, 101);
            Console.WriteLine(NumeroSecreto.ToString());
        }

        public bool NumeroValido()
        {
            int numeroValido, numeroEscolhido;
            if (int.TryParse(TxtB_Numero.Text, out numeroValido))
            {
                numeroEscolhido = int.Parse(TxtB_Numero.Text);
                if(numeroEscolhido > 0 &&  numeroValido < 101)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
