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
        public CrearPlanObraSocial()
        {
            InitializeComponent();
            this.Text = "Registrar Nuevo Plan de Obra Social";
            Titulo.Text = this.Text;
            btnRegistrarPlan.Text = "Registrar";
        }

        public CrearPlanObraSocial(PlanObraSocialDTO planObraSocial) : this()
        {
            this.Text = "Modificar Plan de Obra Social";
            Titulo.Text = this.Text;
            _planExistente = planObraSocial;
            btnRegistrarPlan.Text = "Modificar";

            textNombrePlan.Text = planObraSocial.NombrePlan;
            textDescripcionPlan.Text = planObraSocial.DescripcionPlan;
            if (planObraSocial.Estado == EstadoPlanObraSocialDTO.Habilitado)
                btnRadioHabilitado.Checked = true;
            else
                btnRadioDeshabilitado.Checked = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnRegistrarPlan_Click(object sender, EventArgs e)
        {
            if ((!btnRadioDeshabilitado.Checked || !btnRadioHabilitado.Checked) && string.IsNullOrWhiteSpace(textNombrePlan.Text) && string.IsNullOrWhiteSpace(textDescripcionPlan.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (_planExistente == null)
                {
                    PlanObraSocialDTO planObraSocialDTO = new PlanObraSocialDTO
                    {
                        NombrePlan = textNombrePlan.Text,
                        DescripcionPlan = textDescripcionPlan.Text,
                        Estado = btnRadioHabilitado.Checked ? EstadoPlanObraSocialDTO.Habilitado : EstadoPlanObraSocialDTO.Deshabilitado
                    };

                    await PlanApiClient.AddAsync(planObraSocialDTO);

                    MessageBox.Show("Plan de Obra Social registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    _planExistente.NombrePlan = textNombrePlan.Text;
                    _planExistente.DescripcionPlan = textDescripcionPlan.Text;

                    if (btnRadioHabilitado.Checked)
                    {
                        await PlanApiClient.DisableAsync(_planExistente.PlanObraSocialId);
                    }
                    else if (btnRadioDeshabilitado.Checked)
                    {
                        await PlanApiClient.DisableAsync(_planExistente.PlanObraSocialId);
                    }

                    await PlanApiClient.UpdateAsync(_planExistente);
                }

                MessageBox.Show("Plan de Obra Social modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
