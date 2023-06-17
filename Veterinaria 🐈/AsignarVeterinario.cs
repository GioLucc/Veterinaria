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
using System.Linq;

namespace Veterinaria__
{
    public partial class AsignarVeterinario : FormBaseMenu
    {
        public AsignarVeterinario(Usuario usuarioForm)
        {
            InitializeComponent();
            setDGV();
            dgvAsignarVet.Show();
        }

        public void setDGV()
        {
            List<Turno> turnosSinAtender = new List<Turno>();

            foreach (Turno elemento in Sistema.turnos)
            {
                if(elemento.EstadoTurno == Turno.EstadoDeTurno.SinVeterinario && elemento.Veterinario.Nombre == "")
                {
                    turnosSinAtender.Add(elemento);
                }
            }
            dgvAsignarVet.DataSource = turnosSinAtender;

            dgvAsignarVet.Columns.Clear();
            dgvAsignarVet.AutoGenerateColumns = false;
            dgvAsignarVet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAsignarVet.AutoResizeColumns();
            dgvAsignarVet.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Establece la fuente y el estilo de los encabezados de columna
            dgvAsignarVet.DefaultCellStyle.Font = new Font("Arial", 10); // Establece la fuente y el estilo de las celdas
            dgvAsignarVet.DefaultCellStyle.BackColor = Color.White; // Establece el color de fondo de las celdas
            dgvAsignarVet.DefaultCellStyle.ForeColor = Color.Black; // Establece el color de fuente de las celdas
            dgvAsignarVet.RowHeadersVisible = false; // Oculta las filas de encabezado
            dgvAsignarVet.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Establece el modo de selección
            dgvAsignarVet.MultiSelect = false; // Desactiva la selección múltiple
            dgvAsignarVet.AllowUserToResizeRows = false;
            dgvAsignarVet.AllowUserToResizeColumns = false;
            dgvAsignarVet.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAsignarVet.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvAsignarVet.ReadOnly = true;


            dgvAsignarVet.Columns.Add("FechaColumn", "Fecha");
            dgvAsignarVet.Columns.Add("NombreColumn", "Nombre");
            dgvAsignarVet.Columns.Add("ApellidoDueñoColumn", "Apellido");
            dgvAsignarVet.Columns.Add("EdadColumn", "Edad");
            dgvAsignarVet.Columns.Add("MalestarColumn", "Malestar");
            dgvAsignarVet.Columns.Add("UrgenciaMedicaColumn", "Relevancia");
            dgvAsignarVet.Columns.Add("VeterinarioColumn", "Veterinario Asignado");
            dgvAsignarVet.Columns.Add("EspecialidadColumn", "Especialidad");

            dgvAsignarVet.Columns["NombreColumn"].DataPropertyName = "Nombre";
            dgvAsignarVet.Columns["UrgenciaMedicaColumn"].DataPropertyName = "UrgenciaAtencion";
            dgvAsignarVet.Columns["FechaColumn"].DataPropertyName = "Fecha";
            dgvAsignarVet.Columns["ApellidoDueñoColumn"].DataPropertyName = "Apellido";
            dgvAsignarVet.Columns["EdadColumn"].DataPropertyName = "Edad";
            dgvAsignarVet.Columns["MalestarColumn"].DataPropertyName = "MalestarActual";
            dgvAsignarVet.Columns["VeterinarioColumn"].DataPropertyName = "NombreVet";
            dgvAsignarVet.Columns["EspecialidadColumn"].DataPropertyName = "EspecialidadVet";
            dgvAsignarVet.DataBindingComplete += dgvAsignarVet_DataBindingComplete;
            

            List<Veterinario> veterinariosDisponibles = new List<Veterinario>();
            foreach (Usuario usuario in Sistema.usuario)
            {
                if (usuario is Veterinario veterinario)
                {
                    if (veterinario.Atendiendo == false)
                    {
                        veterinariosDisponibles.Add(veterinario);

                    }
                }
            }
            dgvVeterinariosDisponibles.DataSource = veterinariosDisponibles;


            dgvVeterinariosDisponibles.Columns.Clear();
            dgvVeterinariosDisponibles.AutoGenerateColumns = false;
            dgvVeterinariosDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVeterinariosDisponibles.AutoResizeColumns();
            dgvVeterinariosDisponibles.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Establece la fuente y el estilo de los encabezados de columna
            dgvVeterinariosDisponibles.DefaultCellStyle.Font = new Font("Arial", 10); // Establece la fuente y el estilo de las celdas
            dgvVeterinariosDisponibles.DefaultCellStyle.BackColor = Color.White; // Establece el color de fondo de las celdas
            dgvVeterinariosDisponibles.DefaultCellStyle.ForeColor = Color.Black; // Establece el color de fuente de las celdas
            dgvVeterinariosDisponibles.RowHeadersVisible = false; // Oculta las filas de encabezado
            dgvVeterinariosDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Establece el modo de selección
            dgvVeterinariosDisponibles.MultiSelect = false; // Desactiva la selección múltiple
            dgvVeterinariosDisponibles.AllowUserToResizeRows = false;
            dgvVeterinariosDisponibles.AllowUserToResizeColumns = false;
            dgvVeterinariosDisponibles.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle columnHeaderStyle1 = new DataGridViewCellStyle();
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVeterinariosDisponibles.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvVeterinariosDisponibles.ReadOnly = true;

            dgvVeterinariosDisponibles.Columns.Add("VeterinarioColumn", "Veterinario Disp.");
            dgvVeterinariosDisponibles.Columns.Add("EspecialidadColumn", "Especialidad");


            dgvVeterinariosDisponibles.Columns["VeterinarioColumn"].DataPropertyName = "Nombre";
            dgvVeterinariosDisponibles.Columns["EspecialidadColumn"].DataPropertyName = "Especialidad";

        }

        private void AsignarVeterinarioAlTurno()
        {
            Turno turnito;
            Veterinario veterinarioASeleccionar;

            if (dgvAsignarVet.SelectedRows.Count > 0 && dgvVeterinariosDisponibles.SelectedRows.Count > 0)
            {
                turnito = (Turno)dgvAsignarVet.SelectedRows[0].DataBoundItem;
                veterinarioASeleccionar = (Veterinario)dgvVeterinariosDisponibles.SelectedRows[0].DataBoundItem;
                turnito.Veterinario = veterinarioASeleccionar;
                veterinarioASeleccionar.Atendiendo = true;
                setDGV();
            }
            else
            {
                MessageBox.Show("Porfavor seleccione uno de los campos para poder asignar correctamente un veterinario a este turno","Atención",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
            
        }
        private void dgvAsignarVet_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAsignarVet.Rows)
            {
                DataGridViewCell cell = row.Cells["UrgenciaMedicaColumn"];
                if (cell.Value != null && cell.Value.ToString() == Turno.PrioridadAtencion.Urgente.ToString())
                {
                    cell.Style.BackColor = Color.Red;
                }
            }
        }

        private void btnRelacionarDgvs_Click(object sender, EventArgs e)
        {
            AsignarVeterinarioAlTurno();
        }
    }
}
