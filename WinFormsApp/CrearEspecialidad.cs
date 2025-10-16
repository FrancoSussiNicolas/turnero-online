using API.Clients;
using DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class CrearEspecialidad : Form
    {
        private EspecialidadDTO _especialidadExistente;
        public CrearEspecialidad()
        {
            InitializeComponent();
            this.Text = "Registrar Nueva Especialidad";
            Titulo.Text = this.Text;
            btnRegistrarEspecialidad.Text = "Registrar";
        }

        public CrearEspecialidad(EspecialidadDTO especialidad) : this()
        {
            this.Text = "Modificar Especialidad";
            Titulo.Text = this.Text;
            _especialidadExistente = especialidad;
            btnRegistrarEspecialidad.Text = "Modificar";

            // Precargar valores en los controles
            textDescripcion.Text = especialidad.Descripcion;
            if (especialidad.Estado == EstadoEspecialidadDTO.Habilitada)
                btnRadioHabilitado.Checked = true;
            else
                btnRadioDeshabilitado.Checked = true;
        }

        public static string QuitarTildes(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return texto;

            var normalized = texto.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var c in normalized)
            {
                var uc = CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnRegistrarEspecialidad_Click(object sender, EventArgs e)
        {
            if ((!btnRadioDeshabilitado.Checked || !btnRadioHabilitado.Checked) && string.IsNullOrWhiteSpace(textDescripcion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (_especialidadExistente == null)
                {
                    var especialidadesExistentes = await EspecialidadApiClient.GetAllAsync();

                    string textoNormalizado = QuitarTildes(textDescripcion.Text).ToLower();

                    bool existeDescripcion = especialidadesExistentes
                        .Any(es => QuitarTildes(es.Descripcion).ToLower() == textoNormalizado);

                    if (existeDescripcion)
                    {
                        MessageBox.Show("Ya existe una especialidad con esa descripción.",
                                        "Validación",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }

                    EspecialidadDTO especialidadDTO = new EspecialidadDTO
                    {
                        Descripcion = textDescripcion.Text,
                        Estado = btnRadioHabilitado.Checked ? EstadoEspecialidadDTO.Habilitada : EstadoEspecialidadDTO.Deshabilitada
                    };

                    await EspecialidadApiClient.AddAsync(especialidadDTO);

                    MessageBox.Show("Especialidad registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    _especialidadExistente.Descripcion = textDescripcion.Text;

                    if (btnRadioHabilitado.Checked)
                    {
                        await EspecialidadApiClient.DisableAsync(_especialidadExistente.EspecialidadId);
                    }
                    else if (btnRadioDeshabilitado.Checked)
                    {
                        await EspecialidadApiClient.DisableAsync(_especialidadExistente.EspecialidadId);
                    }


                    await EspecialidadApiClient.UpdateAsync(_especialidadExistente);
                }

                MessageBox.Show("Especialidad modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
