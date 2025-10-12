using API.Clients;
using DTOs;
using Shared;

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
            if (turnoExistente is not null)
            {
                FechaTurno.Value = turnoExistente.FechaTurno.ToDateTime(TimeOnly.MinValue);
                HoraTurno.Value = DateTime.Today.AddTicks(turnoExistente.HoraTurno.Ticks);
                btnRegistrarTurno.Text = "Confirmar";
                this.Text = h1Turno.Text = "Modificar Turno";
            }
            else
            {
                FechaTurno.MinDate = DateTime.Today;
                FechaTurno.Value = DateTime.Today;
                HoraTurno.Value = DateTime.Now;
                btnRegistrarTurno.Text = "Registrar";
                this.Text = h1Turno.Text = "Registrar Turno";
            }

            await ActualizarConsultoriosLibres();
        }


        private async Task ActualizarConsultoriosLibres()
        {
            try
            {
                var fecha = DateOnly.FromDateTime(FechaTurno.Value);
                var hora = TimeOnly.FromDateTime(HoraTurno.Value);

                var consultorios = await ConsultorioApiClient.GetLibresAsync(fecha, hora);

                if (turnoExistente is not null)
                {
                    bool yaIncluido = consultorios.Any(c => c.ConsultorioId == turnoExistente.ConsultorioId);
                    if (!yaIncluido)
                    {
                        var consultorioActual = await ConsultorioApiClient.GetAsync(turnoExistente.ConsultorioId);
                        consultorios.Add(consultorioActual);
                    }
                }

                consultorios = consultorios.OrderBy(c => c.ConsultorioId).ToList();

                comboConsultorio.DataSource = consultorios;
                comboConsultorio.DisplayMember = "Numero";
                comboConsultorio.ValueMember = "ConsultorioId";

                if (turnoExistente is not null)
                    comboConsultorio.SelectedValue = turnoExistente.ConsultorioId;
                else
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
                ProfesionalId = (int)SessionManager.PersonaId,
                FechaTurno = fechaSeleccionada,
                HoraTurno = horaSeleccionada,
                ConsultorioId = (int)comboConsultorio.SelectedValue
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

        private async void FechaTurno_ValueChanged(object sender, EventArgs e)
        {
            await ActualizarConsultoriosLibres();
        }

        private async void HoraTurno_ValueChanged(object sender, EventArgs e)
        {
            await ActualizarConsultoriosLibres();
        }
    }
}
