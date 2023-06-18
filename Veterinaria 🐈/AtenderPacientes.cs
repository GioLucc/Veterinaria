using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria__
{
    public partial class AtenderPacientes : FormBaseMenu
    {
        Usuario usuarioDeLaAplicacion;
        HistorialMedico historialMascota;


        public AtenderPacientes(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioDeLaAplicacion = usuario;
            //dgvAtender.SelectionChanged += dgvAtender_SelectionChanged;
            //dgvAtender.CellContentClick += dgvAtender_CellContentClick;
            dgvFechaTurnos.Hide();
            setDGV();
        }

        public void setDGV()
        {         
            dgvAtender.Columns.Clear();
            dgvAtender.AutoGenerateColumns = false;
            dgvAtender.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAtender.AutoResizeColumns();
            dgvAtender.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Establece la fuente y el estilo de los encabezados de columna
            dgvAtender.DefaultCellStyle.Font = new Font("Arial", 10); // Establece la fuente y el estilo de las celdas
            dgvAtender.DefaultCellStyle.BackColor = Color.White; // Establece el color de fondo de las celdas
            dgvAtender.DefaultCellStyle.ForeColor = Color.Black; // Establece el color de fuente de las celdas
            dgvAtender.RowHeadersVisible = false; // Oculta las filas de encabezado
            dgvAtender.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Establece el modo de selección
            dgvAtender.MultiSelect = false; // Desactiva la selección múltiple
            dgvAtender.AllowUserToResizeRows = false;
            dgvAtender.AllowUserToResizeColumns = false;
            dgvAtender.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAtender.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvAtender.ReadOnly = true;
        
            dgvAtender.Columns.Add("FechaColumn", "Fecha");
            dgvAtender.Columns.Add("NombreColumn", "Nombre");
            dgvAtender.Columns.Add("ApellidoDueñoColumn", "Apellido");
            dgvAtender.Columns.Add("EdadColumn", "Edad");
            dgvAtender.Columns.Add("MalestarColumn", "Malestar");
            dgvAtender.Columns.Add("UrgenciaMedicaColumn", "Relevancia");

            dgvAtender.Columns["NombreColumn"].DataPropertyName = "Nombre";
            dgvAtender.Columns["UrgenciaMedicaColumn"].DataPropertyName = "UrgenciaAtencion";
            dgvAtender.Columns["FechaColumn"].DataPropertyName = "Fecha";
            dgvAtender.Columns["ApellidoDueñoColumn"].DataPropertyName = "Apellido";
            dgvAtender.Columns["EdadColumn"].DataPropertyName = "Edad";
            dgvAtender.Columns["MalestarColumn"].DataPropertyName = "MalestarActual";

            List<Turno> turnosDisponibles = new List<Turno>();
            foreach (Turno unTurno in Sistema.turnos)
            {
                if (unTurno.NombreVet == usuarioDeLaAplicacion.Nombre || unTurno.EstadoTurno == Turno.EstadoDeTurno.SinVeterinario)
                {
                    turnosDisponibles.Add(unTurno);

                }

            }
            dgvAtender.DataSource = turnosDisponibles;

            dgvAtender.DataBindingComplete += dgvAtender_DataBindingComplete;

            //dgvFechaTurnos.Columns.Clear();
            //dgvFechaTurnos.AutoGenerateColumns = false;
            dgvFechaTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFechaTurnos.AutoResizeColumns();
            dgvFechaTurnos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Establece la fuente y el estilo de los encabezados de columna
            dgvFechaTurnos.DefaultCellStyle.Font = new Font("Arial", 10); // Establece la fuente y el estilo de las celdas
            dgvFechaTurnos.DefaultCellStyle.BackColor = Color.White; // Establece el color de fondo de las celdas
            dgvFechaTurnos.BackgroundColor = Color.PeachPuff;
            dgvFechaTurnos.DefaultCellStyle.ForeColor = Color.Black; // Establece el color de fuente de las celdas
            dgvFechaTurnos.RowHeadersVisible = false; // Oculta las filas de encabezado
            dgvFechaTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Establece el modo de selección
            dgvFechaTurnos.MultiSelect = false; // Desactiva la selección múltiple
            dgvFechaTurnos.AllowUserToResizeRows = false;
            dgvFechaTurnos.AllowUserToResizeColumns = false;
            dgvFechaTurnos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle columnHeaderStyleFecha = new DataGridViewCellStyle();
            columnHeaderStyleFecha.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFechaTurnos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvFechaTurnos.ReadOnly = true;





        }

        private void dgvAtender_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAtender.Rows)
            {
                DataGridViewCell cell = row.Cells["UrgenciaMedicaColumn"];
                if (cell.Value != null && cell.Value.ToString() == Turno.PrioridadAtencion.Urgente.ToString())
                {
                    cell.Style.BackColor = Color.Red;
                }
            }
        }

        private void SeleccionarTurno()
        {
            Turno turnito;
            List<HistorialMedico> historial = new List<HistorialMedico>();  

            if (dgvAtender.SelectedRows.Count > 0)
            {
                turnito = (Turno)dgvAtender.SelectedRows[0].DataBoundItem;

                historial = turnito.Mascota.HistoriaClinica;
                turnito.EstadoTurno = Turno.EstadoDeTurno.EnAtencion;
                turnito.Veterinario.Atendiendo = true;
                dgvFechaTurnos.DataSource = turnito.Mascota.HistoriaClinica;
                dgvFechaTurnos.Columns["TratamientoAplicado"].Visible = false;        
                dgvFechaTurnos.Columns["VeterinarioQueAtendio"].HeaderText = "Atendido Por";
                btnAtenderSeleccionado.Hide();
                dgvAtender.Hide();
                
                if(historial.Count > 0)
                {
                    dgvFechaTurnos.Show();
                    setDGV();
                }
                else
                {
                    FormBaseMenu.MostrarAdvertencia("Este turno es de una mascota que no contiene historia clinica!");
                }
                
                
            }
            else
            {
                MessageBox.Show("Porfavor seleccione un turno para poner atenderlo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void dgvAtender_SelectionChanged(object sender, EventArgs e)
        //{
        //    DataGridViewRow selectedRow = dgvAtender.SelectedRows[0];
        //    objetoSeleccionado = selectedRow.DataBoundItem as Mascota;

            
        //}


        //private void dgvAtender_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //int index = e.RowIndex;
        //    //DataGridViewRow selectedRow = dgvAtender.Rows[index];

        //    //Turno turnoSeleccionado = (Turno)selectedRow.DataBoundItem;
        //    //List<DateTime> fechas = new List<DateTime>();

        //    //fechas.AddRange(turnoSeleccionado.Mascota.HistorialMedico.Keys.ToList());

        //    //dgvFechaTurnos.DataSource = fechas;
        //    //dgvFechaTurnos.Show();

        //    //dgvFechaTurnos.DataSource = new BindingSource(turnoSeleccionado.Mascota.HistorialMedico.Keys, null);
        //    //dgvFechaTurnos.Show();

        //}

        private void btnAtenderSeleccionado_Click(object sender, EventArgs e)
        {
            SeleccionarTurno();

        }
    }
}
