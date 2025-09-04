using Entities;
using DTOs;

namespace WinFormsApp
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnverTurnos_Click(object sender, EventArgs e)
        {
            VerTurnosForm verTurnos = new VerTurnosForm();
            verTurnos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btncrearTurnos_Click(object sender, EventArgs e)
        {

        }

        private void btnAddObraSocial_Click(object sender, EventArgs e)
        {

        }
    }
}
