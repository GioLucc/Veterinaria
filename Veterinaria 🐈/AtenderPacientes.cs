using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria__
{
    public partial class AtenderPacientes : FormBaseMenu
    {
        Usuario usuarioDeLaAplicacion;
        HistorialMedico historialMascota;
        Turno turnito;
        private decimal totalAcumulado = 0.00m;
        private bool primerClick = true;


        public AtenderPacientes(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioDeLaAplicacion = usuario;
            dgvFechaTurnos.Hide();
            btnAgregarNuevaVisita.Hide();
            btnCostoConsulta.Hide();
            gbHistorial.Hide();
            txtMalestar.Hide();
            txtObservaciones.Hide();
            lblObservacionAgregar.Hide();
            txtMalestar.Hide();
            lblEstadoTurno.Text = "Libre 😺";
            lblEstadoTurno.ForeColor = Color.Green;
            lblVisitasPrevias.Hide();
            btnCostoConsulta.Hide();
            txtPrecioConsulta.Hide();
            dgvPrecios.Hide();
            btnCostoConsulta.Hide();
            setDGV();
            setDGVPrecios(Sistema.listaPrecios);
            btnDesplegarDgvs.Hide();
        }

        public AtenderPacientes(Usuario usuarioForm, Color color) : this(usuarioForm)
        {
            this.BackColor = color;
        }

        public void setDGVPrecios(List<PrecioItem> lista)
        {
            dgvPrecios.AutoGenerateColumns = false;
            dgvPrecios.DataSource = lista;

            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.Name = "Seleccionado";
            checkboxColumn.HeaderText = "Seleccionado";
            checkboxColumn.DataPropertyName = "Seleccionado";

            DataGridViewTextBoxColumn descripcionColumn = new DataGridViewTextBoxColumn();
            descripcionColumn.Name = "descripcionColumn";
            descripcionColumn.HeaderText = "Descripción";
            descripcionColumn.DataPropertyName = "Descripcion";

            DataGridViewTextBoxColumn precioColumn = new DataGridViewTextBoxColumn();
            precioColumn.Name = "precioColumn";
            precioColumn.HeaderText = "Precio";
            precioColumn.DataPropertyName = "Precio";

            dgvPrecios.Columns.Add(checkboxColumn);
            dgvPrecios.Columns.Add(descripcionColumn);
            dgvPrecios.Columns.Add(precioColumn);
            dgvPrecios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPrecios.AutoResizeColumns();
            dgvPrecios.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvPrecios.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvPrecios.DefaultCellStyle.BackColor = Color.White;
            dgvPrecios.DefaultCellStyle.ForeColor = Color.Black;
            dgvPrecios.RowHeadersVisible = false;
            dgvPrecios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrecios.MultiSelect = false;
            dgvPrecios.AllowUserToResizeRows = false;
            dgvPrecios.AllowUserToResizeColumns = false;
            dgvPrecios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrecios.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvPrecios.ReadOnly = false;
            dgvPrecios.Columns["descripcionColumn"].ReadOnly = true;
            dgvPrecios.Columns["precioColumn"].ReadOnly = true;
            dgvPrecios.CellContentClick += dgvPrecios_CellContentClick;

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
                if (unTurno.NombreVet == usuarioDeLaAplicacion.Nombre || unTurno.EstadoTurno == Turno.EstadoDeTurno.SinVeterinario || unTurno.EstadoTurno == Turno.EstadoDeTurno.EnAtencion)
                {
                    turnosDisponibles.Add(unTurno);
                }
            }
            dgvAtender.DataSource = turnosDisponibles;

            dgvAtender.DataBindingComplete += dgvAtender_DataBindingComplete;         
        }

        public void setDGVHistorial()
        {          
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
            dgvFechaTurnos.ColumnHeadersDefaultCellStyle = columnHeaderStyleFecha;
            dgvFechaTurnos.ReadOnly = true;
            dgvFechaTurnos.DataSource = turnito.Mascota.HistoriaClinica;
            dgvFechaTurnos.Columns["TratamientoAplicado"].Visible = false;
            dgvFechaTurnos.Columns["VeterinarioQueAtendio"].HeaderText = "Atendido Por";         
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
            List<HistorialMedico> historial;

            if (dgvAtender.SelectedRows.Count > 0)
            {
                turnito = (Turno)dgvAtender.CurrentRow.DataBoundItem;

                //historial = turnito.Mascota.HistoriaClinica;
                turnito.EstadoTurno = Turno.EstadoDeTurno.EnAtencion;
                turnito.Veterinario.Atendiendo = true;            
                btnAtenderSeleccionado.Hide();
                dgvAtender.Hide();

                if (turnito.Mascota.HistoriaClinica.Count > 0)
                {
                    setDGVHistorial();
                    dgvFechaTurnos.Show();
                    lblMascotaMalestar.Show();
                    lblMascotaMalestar.Text = "Mascota: " + turnito.Mascota.NombreAnimal + " - " + turnito.MalestarActual;
                    turnito.Veterinario.Atendiendo = true;
                    lblEstadoTurno.Text = "Atendiendo";
                    lblEstadoTurno.ForeColor = Color.Red;
                    lblEstadoTurno.Text += "🐶";
                    lblVisitasPrevias.Show();
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

        private void btnAtenderSeleccionado_Click(object sender, EventArgs e)
        {
            SeleccionarTurno();
            btnAgregarNuevaVisita.Show();
            btnCostoConsulta.Show();
            gbHistorial.Show();
            txtObservaciones.Show();
            txtMalestar.Show();
            lblObservacionAgregar.Show();
            dgvFechaTurnos.Show();
            
        }

        private void dgvFechaTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvFechaTurnos.CurrentRow;
            HistorialMedico historialSeleccionado = (HistorialMedico)selectedRow.DataBoundItem;

            txtMalestar.Text = historialSeleccionado.Malestar;
            txtInfoAd.Text = historialSeleccionado.TratamientoAplicado;          
        }

        private void btnAgregarNuevaVisita_Click(object sender, EventArgs e)
        {
            HistorialMedico nuevaConsulta;
            nuevaConsulta = new HistorialMedico();

            if(txtObservaciones.Text.Length > 0)
            {
                nuevaConsulta.AgregarConsulta(turnito.MalestarActual,txtObservaciones.Text,turnito.Mascota,usuarioDeLaAplicacion.Nombre);
                btnAgregarNuevaVisita.Hide();
                txtObservaciones.Hide();
                btnAgregarNuevaVisita.Hide();
                lblObservacionAgregar.Hide();
                dgvFechaTurnos.DataSource = null;
                setDGVHistorial();
                btnCostoConsulta.Show();
                txtPrecioConsulta.Show();
                btnDesplegarDgvs.Show();
                
            }
            else
            {
                FormBaseMenu.MostrarAdvertencia("Su campo observaciones está vacio, procure poner algun tipo de dato acerca de la consulta");
            }

        }

        private void dgvPrecios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvPrecios.Columns["Seleccionado"].Index)
            {
                DataGridViewCheckBoxCell checkboxCell = dgvPrecios.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;

                if (checkboxCell.Value == checkboxCell.TrueValue)
                {
                    var precioItem = (PrecioItem)dgvPrecios.Rows[e.RowIndex].DataBoundItem;
                    totalAcumulado += precioItem.Precio;
                }
                else
                {
                    var precioItem = (PrecioItem)dgvPrecios.Rows[e.RowIndex].DataBoundItem;
                    totalAcumulado -= precioItem.Precio;
                }

                // Actualizar el total acumulado donde sea necesario
                txtPrecioConsulta.Text = "Valor: " + totalAcumulado.ToString("C");
            }
        }

        private void btnDesplegarHistorial_Click(object sender, EventArgs e)
        {
            if (primerClick)
            {
                btnDesplegarDgvs.Text = "Mostrar Historial";
                dgvPrecios.Show();
                primerClick = false;
            }
            else
            {
                dgvPrecios.Hide();
                btnDesplegarDgvs.Text = "Mostrar Precios";
                dgvFechaTurnos.Show();

                primerClick = true; 
            }
        }

        private void btnCostoConsulta_Click(object sender, EventArgs e)
        {
            if(totalAcumulado > 0)
            {
                dgvAtender.Show();
                turnito.EstadoTurno = Turno.EstadoDeTurno.Atendido;
                dgvFechaTurnos.Hide();
                btnAgregarNuevaVisita.Hide();
                btnCostoConsulta.Hide();
                gbHistorial.Hide();
                txtMalestar.Hide();
                txtObservaciones.Hide();
                lblObservacionAgregar.Hide();
                txtMalestar.Hide();
                lblEstadoTurno.Text = "Libre 😺";
                lblEstadoTurno.ForeColor = Color.Green;
                lblVisitasPrevias.Hide();
                btnCostoConsulta.Hide();
                txtPrecioConsulta.Hide();
                dgvPrecios.Hide();
                btnCostoConsulta.Hide();
                setDGV();
                setDGVPrecios(Sistema.listaPrecios);
                btnDesplegarDgvs.Hide();
                lblMascotaMalestar.Hide();
                btnAtenderSeleccionado.Show();
                txtObservaciones.Text = "";
                txtMalestar.Text = "";
                txtInfoAd.Text = "";
            }
            else
            {
                FormBaseMenu.MostrarAdvertencia("Debe marcar al menos una casilla para que el turno tenga un coste");
            }

        }
    }
}
