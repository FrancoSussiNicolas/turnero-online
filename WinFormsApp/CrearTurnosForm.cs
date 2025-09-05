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
    public partial class CrearTurnosForm : Form
    {
        public CrearTurnosForm()
        {
            InitializeComponent();
        }
        private async void CrearTurnosForm_Load(object sender, EventArgs e)
        {
            this.comboConsultorio.Items.Clear();

            List<ConsultorioDTO> consultorios = await ConsultorioApiClient.GetDisponiblesAsync();

            comboConsultorio.DisplayMember = "Numero";
            comboConsultorio.ValueMember = "ConsultorioId";
        }

        private void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            if (comboConsultorio.SelectedItem is null)
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
                FechaTurno.Focus();
                HoraTurno.Focus();
                return;
            }

            this.guardarTurno(fechaSeleccionada, horaSeleccionada,(Consultorio)comboConsultorio.SelectedItem);

        }

        private async Task guardarTurno(DateOnly fechaTurno, TimeOnly horaTurno, Consultorio consultorio)
        {
            TurnoDTO newTurno = new TurnoDTO
            {
                FechaTurno = fechaTurno,
                HoraTurno = horaTurno,
                NroConsultorio = consultorio.ConsultorioId
            };

            await TurnoApiClient.AddAsync(newTurno);

        }

        private void btnCancelarTurno_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboConsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboConsultorio.SelectedItem != null)
            {
                Consultorio seleccionado = (Consultorio)comboConsultorio.SelectedItem;
            }
        }
    }
}
