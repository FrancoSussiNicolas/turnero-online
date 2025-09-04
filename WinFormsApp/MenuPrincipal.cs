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

        private void pacientesBtn_Click(object sender, EventArgs e)
        {
            var pacForm = new PacienteForm();
            pacForm.ShowDialog();
        }

        private void profesionalesBtn_Click(object sender, EventArgs e)
        {
            var profForm = new ProfesionalForm();
            profForm.ShowDialog();

            //var newProf = new PacienteDTO();

            //profForm.AutoScaleMode = FormMode.Add;
            //profForm.Paciente = newProf;
            //profForm.ShowDialog();

            //this.GetAllAndLoad();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Shown(object sender, EventArgs e)
        {
            Login appLogin = new Login();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
