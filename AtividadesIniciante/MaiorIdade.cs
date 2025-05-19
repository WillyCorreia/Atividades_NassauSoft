using System;
using System.Windows.Forms;

namespace AtividadesWindowsForms.AtividadesIniciante
{
    public partial class MaiorIdade : Form
    {
        public MaiorIdade()
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
            Lbl_IdadeEMaioridade.Text = "";

            int numeroTeste, anoDigitado, diaDigitado, mesDigitado, diaHoje, anoHoje, MesHoje, Idade;
            DateTime dateTime = DateTime.Now;
            bool MaiorIdade = false;

            diaHoje = dateTime.Day;
            MesHoje = dateTime.Month;
            anoHoje = dateTime.Year;

            if (int.TryParse(TxtB_Dia.Text, out numeroTeste) && int.TryParse(TxtB_Mes.Text, out numeroTeste) && int.TryParse(TxtB_Ano.Text, out numeroTeste))
            {
                diaDigitado = int.Parse(TxtB_Dia.Text);
                mesDigitado = int.Parse(TxtB_Mes.Text);
                anoDigitado = int.Parse(TxtB_Ano.Text);

                if (diaDigitado < 1 || diaDigitado > 31)
                {
                    MessageBox.Show("Dia inválido");
                    return;
                }

                if (mesDigitado < 1 || mesDigitado > 12)
                {
                    MessageBox.Show("Mês inválido");
                    return;
                }

                if (anoDigitado < 1 || anoDigitado > 2025)
                {
                    MessageBox.Show("Ano inválido");
                    return;
                }

                if ((anoDigitado % 4 == 0 && anoDigitado % 100 != 0) || (anoDigitado % 400 == 0))
                {
                    if (mesDigitado == 4 || mesDigitado == 6 || mesDigitado == 9 || mesDigitado == 11)
                    {
                        if (diaDigitado < 1 || diaDigitado > 30)
                        {
                            MessageBox.Show("Dia inválido");
                            return;
                        }
                    }
                    else if (mesDigitado == 2)
                    {
                        if (diaDigitado < 1 || diaDigitado > 29)
                        {
                            MessageBox.Show("Dia inválido");
                            return;
                        }
                    }
                    else
                    {
                        if (diaDigitado < 1 || diaDigitado > 31)
                        {
                            MessageBox.Show("Dia inválido");
                            return;
                        }
                    }
                }
                else
                {
                    if (mesDigitado == 4 || mesDigitado == 6 || mesDigitado == 9 || mesDigitado == 11)
                    {
                        if (diaDigitado < 1 || diaDigitado > 30)
                        {
                            MessageBox.Show("Dia inválido");
                            return;
                        }
                    }
                    else if (mesDigitado == 2)
                    {
                        if (diaDigitado < 1 || diaDigitado > 28)
                        {
                            MessageBox.Show("Dia inválido");
                            return;
                        }
                    }
                    else
                    {
                        if (diaDigitado < 1 || diaDigitado > 31)
                        {
                            MessageBox.Show("Dia inválido");
                            return;
                        }
                    }
                }

                if((anoHoje - anoDigitado) > 18)
                {
                    MaiorIdade = true;
                }
                else if((anoHoje - anoDigitado) < 18)
                {
                    MaiorIdade = false;
                }
                else
                {
                    if (MesHoje > mesDigitado)
                    {
                        MaiorIdade = true;
                    }
                    else if(MesHoje == mesDigitado)
                    {
                        if(diaHoje >= diaDigitado)
                        {
                            MaiorIdade = true;
                        }
                        else
                        {
                            MaiorIdade = false;
                        }
                    }
                    else
                    {
                        MaiorIdade = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Existe um número inválido");
                return;
            }

            if (MaiorIdade)
            {
                Lbl_IdadeEMaioridade.Text = "Sim, você já é de maior!";
            }
            else
            {
                Lbl_IdadeEMaioridade.Text = "Não, você não é de maior ainda";
            }
        }
    }
}
