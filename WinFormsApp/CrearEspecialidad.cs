using API.Clients;
using DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class CrearEspecialidad : Form
    {
        public CrearEspecialidad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            string descripcion = inputDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, ingrese la descripción de la especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EspecialidadDTO newEspecialidad = new EspecialidadDTO
            {
                Descripcion = descripcion
            };

            await EspecialidadApiClient.AddAsync(newEspecialidad);
        }

        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearEspecialidad_Load(object sender, EventArgs e)
        {

        }
    }
}
