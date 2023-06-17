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
        public AtenderPacientes(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioDeLaAplicacion = usuario;
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
            dgvAtender.Columns["FechaColumn"].DataPropertyName = "Apellido";
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

        


    }
}
