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
    public partial class Idade : Form
    {
        public Idade()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            Lbl_IdadeEDias.Text = "Data: \n\nDias: ";

            int numeroTeste, DiaDigitado, MesDigitado, AnoDigitado, Dia, Mes, Ano, DiasDeVida, DiaHoje, MesHoje, AnoHoje;
            bool Bissexto;
            DateTime hoje = DateTime.Now;

            DiaHoje = hoje.Day;
            MesHoje = hoje.Month;
            AnoHoje = hoje.Year;

            DiasDeVida = 0;

            if (int.TryParse(TxtB_Dia.Text, out numeroTeste) && int.TryParse(TxtB_Mes.Text, out numeroTeste) && int.TryParse(TxtB_Ano.Text, out numeroTeste))
            {
                DiaDigitado = int.Parse(TxtB_Dia.Text);
                MesDigitado = int.Parse(TxtB_Mes.Text);
                AnoDigitado = int.Parse(TxtB_Ano.Text);

                Ano = AnoDigitado;
                Mes = MesDigitado;
                Dia = DiaDigitado;

                if (Dia < 1 || Dia > 31)
                {
                    MessageBox.Show("Dia inválido");
                    return;
                }

                if (Mes < 1 || Mes > 12)
                {
                    MessageBox.Show("Mês inválido");
                    return;
                }

                if (Ano < 1 || Ano > 2025)
                {
                    MessageBox.Show("Ano inválido");
                    return;
                }

                while (Ano <= 2025)
                {
                    if((Ano % 4 == 0 && Ano % 100 != 0) || (Ano % 400 == 0))
                    {
                        Bissexto = true;
                    }
                    else
                    {
                        Bissexto = false;
                    }

                    if (Ano == AnoDigitado && Ano != AnoHoje)
                    {
                        while (Mes <= 12)
                        {
                            if (Mes == MesDigitado)
                            {
                                if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
                                {
                                    if (Dia > 30)
                                    {
                                        MessageBox.Show("Dia inválido");
                                        return;
                                    }
                                    DiasDeVida += 30 - DiaDigitado + 1;
                                }
                                else if (Mes == 2)
                                {
                                    if (Bissexto)
                                    {
                                        if (Dia > 29)
                                        {
                                            MessageBox.Show("Dia inválido");
                                            return;
                                        }

                                        DiasDeVida += 29 - DiaDigitado + 1;
                                    }
                                    else
                                    {
                                        if (Dia > 28)
                                        {
                                            MessageBox.Show("Dia inválido");
                                            return;
                                        }

                                        DiasDeVida += 28 - DiaDigitado + 1;
                                    }
                                }
                                else
                                {
                                    if (Dia > 31)
                                    {
                                        MessageBox.Show("Dia inválido");
                                        return;
                                    }

                                    DiasDeVida += 31 - DiaDigitado + 1;
                                }
                            }
                            else if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
                            {
                                DiasDeVida += 30;
                            }
                            else if (Mes == 2)
                            {
                                if (Bissexto)
                                {
                                    DiasDeVida += 29;
                                }
                                else
                                {
                                    DiasDeVida += 28;
                                }
                            }
                            else
                            {
                                DiasDeVida += 31;
                            }
                            Mes++;
                        }
                        Mes = MesDigitado;
                    }
                    else if (Ano == AnoDigitado && Ano == AnoHoje)
                    {
                        if (Mes > MesHoje)
                        {
                            MessageBox.Show("Mês inválido");
                            return;
                        }
                        while (Mes <= MesHoje)
                        {
                            if (Mes == MesDigitado)
                            {
                                if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
                                {
                                    if (Dia > 30)
                                    {
                                        MessageBox.Show("Dia inválido");
                                        return;
                                    }
                                    DiasDeVida += 30 - DiaDigitado + 1;
                                }
                                else if (Mes == 2)
                                {
                                    if (Bissexto)
                                    {
                                        if (Dia > 29)
                                        {
                                            MessageBox.Show("Dia inválido");
                                            return;
                                        }

                                        DiasDeVida += 29 - DiaDigitado + 1;
                                    }
                                    else
                                    {
                                        if (Dia > 30)
                                        {
                                            MessageBox.Show("Dia inválido");
                                            return;
                                        }

                                        DiasDeVida += 28 - DiaDigitado + 1;
                                    }
                                }
                                else
                                {
                                    if (Dia > 31)
                                    {
                                        MessageBox.Show("Dia inválido");
                                        return;
                                    }

                                    DiasDeVida += 31 - DiaDigitado + 1;
                                }
                            }
                            else if (Mes == MesHoje)
                            {
                                DiasDeVida += DiaHoje;
                            }
                            else if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
                            {
                                DiasDeVida += 30;
                            }
                            else if (Mes == 2)
                            {
                                if (Bissexto)
                                {
                                    DiasDeVida += 29;
                                }
                                else
                                {
                                    DiasDeVida += 28;
                                }
                            }
                            else
                            {
                                DiasDeVida += 31;
                            }
                            Mes++;
                        }
                        Mes = MesDigitado;
                    }
                    else if(Ano == AnoHoje)
                    {
                        Mes = 1;
                        while (Mes <= MesHoje)
                        {
                            if (Mes == MesDigitado)
                            {
                                if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
                                {
                                    DiasDeVida += 30;
                                }
                                else if (Mes == 2)
                                {
                                    if (Bissexto)
                                    {
                                        DiasDeVida += 29;
                                    }
                                    else
                                    {
                                        DiasDeVida += 28;
                                    }
                                }
                                else
                                {
                                    DiasDeVida += 31;
                                }
                            }
                            else if (Mes == MesHoje)
                            {
                                DiasDeVida += DiaHoje;
                            }
                            else if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
                            {
                                DiasDeVida += 30;
                            }
                            else if (Mes == 2)
                            {
                                if (Bissexto)
                                {
                                    DiasDeVida += 29;
                                }
                                else
                                {
                                    DiasDeVida += 28;
                                }
                            }
                            else
                            {
                                DiasDeVida += 31;
                            }
                            Mes++;
                        }
                        Mes = MesDigitado;
                    }
                    else if (Bissexto)
                    {
                        DiasDeVida += 366;
                    }
                    else
                    {
                        DiasDeVida += 365;
                    }
                    Ano++;
                }

                Lbl_IdadeEDias.Text = $"Data: {DiaDigitado}/{MesDigitado}/{AnoDigitado}\n\nDias: {DiasDeVida}";

            }
            else
            {
                MessageBox.Show("Existe um número inválido");
            }
        }
    }
}
