using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void ListaButton_Click(object sender, EventArgs e)
        {
            new FormLista().Show();
        }

        private void EncadeadaButton_Click(object sender, EventArgs e)
        {
            new FormFila().Show();
        }

        private void PilhaButton_Click(object sender, EventArgs e)
        {
            new FormPilha().Show();
        }
    }
}
