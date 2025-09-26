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
    public partial class CrearConsultorioForm : Form
    {
        private ConsultorioDTO _consultorioExistente;
        public CrearConsultorioForm()
        {
            InitializeComponent();
            this.Text = "Registrar Consultorio";
            Titulo.Text = this.Text;

        }
        public CrearConsultorioForm(ConsultorioDTO consultorio) : this()
        {
            this.Text = "Modificar Consultorio";
            Titulo.Text = this.Text;
            _consultorioExistente = consultorio;
            
            // Precargar valores en los controles
            textUbicacion.Text = consultorio.Ubicacion;
            if (consultorio.Estado == EstadoConsultorio.Habilitado)
                btnRadioHabilitado.Checked = true;
            else
                btnRadioDeshabilitado.Checked = true;
        }

        private async void btnRegistrarConsultorio_Click(object sender, EventArgs e)
        {
            if ((!btnRadioDeshabilitado.Checked || !btnRadioHabilitado.Checked) && string.IsNullOrWhiteSpace(textUbicacion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if(_consultorioExistente == null)
                {
                    ConsultorioDTO consultorioDTO = new ConsultorioDTO
                    {
                        Ubicacion = textUbicacion.Text,
                        Estado = btnRadioHabilitado.Checked ? EstadoConsultorio.Habilitado : EstadoConsultorio.Deshabilitado
                    };

                    await ConsultorioApiClient.AddAsync(consultorioDTO);

                    MessageBox.Show("Consultorio registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    _consultorioExistente.Ubicacion = textUbicacion.Text;

                    if (btnRadioHabilitado.Checked)
                    {
                        await ConsultorioApiClient.DisableAsync(_consultorioExistente.ConsultorioId);
                    }
                    else if (btnRadioDeshabilitado.Checked)
                    {
                        await ConsultorioApiClient.DisableAsync(_consultorioExistente.ConsultorioId);
                    }

                    
                    await ConsultorioApiClient.UpdateAsync(_consultorioExistente);
                }

                MessageBox.Show("Consultorio modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) {

                MessageBox.Show($"Error al registrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
    }
}
