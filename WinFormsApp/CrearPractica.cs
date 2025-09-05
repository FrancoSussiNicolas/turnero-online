using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DTOs; 
using API

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.Clients;

namespace WinFormsApp
{
    public partial class CrearPractica : Form
    {
        public CrearPractica()
        {
            InitializeComponent();
        }

        private async void btnRegistrarPractica_Click(object sender, EventArgs e)
        {
            if(nomPractica != null &&  descripcionPractica != null)
            {
                PracticaDTO practicaDTO = new PracticaDTO
                {
                    Nombre = nomPractica.Text, 
                    Descripcion = descripcionPractica.Text 

                };

                await PracticaApiClient.AddAsync(practicaDTO);


            }
            else
            {
                MessageBox.Show("Debes completar todos los campos.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nomPractica.Focus();
                descripcionPractica.Focus();
                return;
            }

        }


        private void btnCancelarPractica_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
