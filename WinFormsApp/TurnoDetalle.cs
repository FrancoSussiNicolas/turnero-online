using API.Clients;
using DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class TurnoDetalle : Form
    {
        private readonly TurnoDTO? turnoExistente;

        public TurnoDetalle(TurnoDTO? turno = null)
        {
            InitializeComponent();
            this.turnoExistente = turno;
        }

        private async void TurnoDetalle_Load(object sender, EventArgs e)
        {
            await CargarConsultorios();

            if (turnoExistente is not null)
            {
                FechaTurno.Value = turnoExistente.FechaTurno.ToDateTime(TimeOnly.MinValue);
                HoraTurno.Value = DateTime.Today.AddTicks(turnoExistente.HoraTurno.Ticks);
                comboConsultorio.SelectedValue = turnoExistente.NroConsultorio;
                btnRegistrarTurno.Text = "Confirmar";
                this.Text = "Modificar Turno";
                h1Turno.Text = "Modificar Turno";
            }
            else
            {
                btnRegistrarTurno.Text = "Registrar";
                this.Text = "Crear Turno";
                h1Turno.Text = "Registrar Turno";
            }
        }

        private async Task CargarConsultorios()
        {
            try
            {
                List<ConsultorioDTO> consultorios = await ConsultorioApiClient.GetDisponiblesAsync();

                comboConsultorio.DataSource = consultorios;
                comboConsultorio.DisplayMember = "Numero";
                comboConsultorio.ValueMember = "ConsultorioId";
                comboConsultorio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            if (comboConsultorio.SelectedValue is null)
            {
                MessageBox.Show("Debe seleccionar un consultorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboConsultorio.Focus();
                return;
            }

            DateOnly fechaSeleccionada = DateOnly.FromDateTime(FechaTurno.Value);
            TimeOnly horaSeleccionada = TimeOnly.FromDateTime(HoraTurno.Value);
            DateTime fechaHoraTurno = fechaSeleccionada.ToDateTime(horaSeleccionada);

            if (fechaHoraTurno < DateTime.Now)
            {
                MessageBox.Show("La fecha y hora del turno no puede ser en el pasado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var turnoDTO = new TurnoDTO
            {
                FechaTurno = fechaSeleccionada,
                HoraTurno = horaSeleccionada,
                NroConsultorio = (int)comboConsultorio.SelectedValue
            };

            try
            {
                if (turnoExistente is null)
                {
                    await TurnoApiClient.AddAsync(turnoDTO);
                    MessageBox.Show("Turno registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    turnoDTO.TurnoId = turnoExistente.TurnoId;
                    await TurnoApiClient.UpdateAsync(turnoDTO);
                    MessageBox.Show("Turno actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error al registrar el turno: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarTurno_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private async void HoraTurno_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                List<ConsultorioDTO> consultorios = await ConsultorioApiClient.GetLibresAsync(DateOnly.FromDateTime(FechaTurno.Value), TimeOnly.FromDateTime(HoraTurno.Value));

                comboConsultorio.DataSource = consultorios;
                comboConsultorio.DisplayMember = "Numero";
                comboConsultorio.ValueMember = "ConsultorioId";
                comboConsultorio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
