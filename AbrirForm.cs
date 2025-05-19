using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadesWindowsForms
{
    internal class AbrirForm
    {
        public static void abrir_Form(Form origem, Form form)
        {
            origem.Hide();
            form.ShowDialog();
            origem.Show();
        }
    }
}
