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
    public partial class CrearPlanObraSocial : Form
    {
        private PlanObraSocialDTO _planExistente;
        private ObraSocialDTO _obraSocialSeleccionada;

        public CrearPlanObraSocial()
        {
            InitializeComponent();
            this.Text = "Registrar Nuevo Plan de Obra Social";
            Titulo.Text = this.Text;
            btnRegistrarPlan.Text = "Registrar";
        }

        // Constructor para crear un nuevo plan para una obra social específica
        public CrearPlanObraSocial(ObraSocialDTO obraSocial) : this()
        {
            _obraSocialSeleccionada = obraSocial;
            this.Text = $"Registrar Nuevo Plan - {obraSocial.NombreObraSocial}";
            Titulo.Text = this.Text;
            btnRegistrarPlan.Text = "Registrar";
            btnRadioHabilitado.Checked = true;
        }

        // Constructor para editar un plan existente
        public CrearPlanObraSocial(PlanObraSocialDTO planObraSocial) : this()
        {
            this.Text = "Modificar Plan de Obra Social";
            Titulo.Text = this.Text;
            _planExistente = planObraSocial;
            btnRegistrarPlan.Text = "Modificar";

            // Precargar valores en los controles
            textNombrePlan.Text = planObraSocial.NombrePlan;
            textDescripcionPlan.Text = planObraSocial.DescripcionPlan;

            if (planObraSocial.Estado == EstadoPlanObraSocialDTO.Habilitado)
                btnRadioHabilitado.Checked = true;
            else
                btnRadioDeshabilitado.Checked = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnRegistrarPlan_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un estado
            if (!btnRadioDeshabilitado.Checked && !btnRadioHabilitado.Checked)
            {
                MessageBox.Show("Debes seleccionar un estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que los campos de texto no estén vacíos
            if (string.IsNullOrWhiteSpace(textNombrePlan.Text) || string.IsNullOrWhiteSpace(textDescripcionPlan.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_planExistente == null)
                {
                    // Crear nuevo plan
                    PlanObraSocialDTO planObraSocialDTO = new PlanObraSocialDTO
                    {
                        NombrePlan = textNombrePlan.Text,
                        DescripcionPlan = textDescripcionPlan.Text,
                        ObraSocialId = _obraSocialSeleccionada.ObraSocialId,
                        Estado = btnRadioHabilitado.Checked ? EstadoPlanObraSocialDTO.Habilitado : EstadoPlanObraSocialDTO.Deshabilitado
                    };

                    await PlanApiClient.AddAsync(planObraSocialDTO);
                    MessageBox.Show("Plan de Obra Social registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Modificar plan existente
                    _planExistente.NombrePlan = textNombrePlan.Text;
                    _planExistente.DescripcionPlan = textDescripcionPlan.Text;

                    EstadoPlanObraSocialDTO nuevoEstado = btnRadioHabilitado.Checked
                        ? EstadoPlanObraSocialDTO.Habilitado
                        : EstadoPlanObraSocialDTO.Deshabilitado;

                    _planExistente.Estado = nuevoEstado;

                    await PlanApiClient.UpdateAsync(_planExistente);
                    MessageBox.Show("Plan de Obra Social modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}