using Entidades;
using Entidades.Archivos_y_Serializadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Entidades.Turno;


namespace Veterinaria__
{
    public partial class FormTurnos : FormBaseMenu
    {
        Usuario veterinarioActual;
        private string? nivelImportancia;
        Recepcionista recepcionista = new Recepcionista();

        //String gravedad


        public FormTurnos(Usuario veterinario)
        {
            InitializeComponent();
            veterinarioActual = veterinario;
            dgvBaseDatos.Hide();
            dtpElegirFechaTurno.MinDate = DateTime.Now;
            btnCrearTurno.Hide();
            btnUrgencia.Hide();
            btnMedia.Hide();
            btnNormal.Hide();
            lblSeleccionaImportancia.Hide();
            btnUrgencia.Click += BotonNivelImportancia_Click;
            btnMedia.Click += BotonNivelImportancia_Click;
            btnNormal.Click += BotonNivelImportancia_Click;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadirMascota_Click(object sender, EventArgs e)
        {
            FormAlta darDeAlta = new FormAlta(veterinarioActual);
            this.Hide();

            DialogResult retornoAlta = darDeAlta.ShowDialog();

            if (retornoAlta == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btn_MostrarMascotas_Click(object sender, EventArgs e)
        {
            dgvBaseDatos.DataSource = Sistema.AnimalDomesticos;
            setDGV();
            dgvBaseDatos.Columns["fechaDeNacimiento"].Visible = false;
            dgvBaseDatos.Columns["raza"].Visible = false;
            dgvBaseDatos.Columns["edad"].Visible = false;
            dgvBaseDatos.Columns["especie"].Visible = false;
            dgvBaseDatos.Columns["peso"].Visible = false;
            dgvBaseDatos.Columns["sexo"].Visible = false;


            dgvBaseDatos.Show();
        }

        public void setDGV()
        {
            dgvBaseDatos.DataSource = Sistema.AnimalDomesticos;
            dgvBaseDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBaseDatos.AutoResizeColumns();
            dgvBaseDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Establece la fuente y el estilo de los encabezados de columna
            dgvBaseDatos.DefaultCellStyle.Font = new Font("Arial", 10); // Establece la fuente y el estilo de las celdas
            dgvBaseDatos.DefaultCellStyle.BackColor = Color.White; // Establece el color de fondo de las celdas
            dgvBaseDatos.DefaultCellStyle.ForeColor = Color.Black; // Establece el color de fuente de las celdas
            dgvBaseDatos.RowHeadersVisible = false; // Oculta las filas de encabezado
            dgvBaseDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Establece el modo de selección
            dgvBaseDatos.MultiSelect = false; // Desactiva la selección múltiple
            dgvBaseDatos.AllowUserToResizeRows = false;
            dgvBaseDatos.AllowUserToResizeColumns = false;
            dgvBaseDatos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBaseDatos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvBaseDatos.ReadOnly = true;


            dgvBaseDatos.Columns[0].HeaderText = "Id";
            dgvBaseDatos.Columns[1].HeaderText = "Nombre Mascota";
            dgvBaseDatos.Columns[2].HeaderText = "Apellido Dueño";
        }

        private void btnOcultarDatos_Click(object sender, EventArgs e)
        {
            dgvBaseDatos.Hide();
        }

        private void dgvBaseDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;
            //DataGridViewRow selectedRow = dgvBaseDatos.Rows[index];
            //Mascota = (Mascota)selectedRow.DataBoundItem;
            //dgvBaseDatos.Hide();
        }

        private void btnCrearTurno_Click(object sender, EventArgs e)
        {
            Mascota Mascota = (Mascota)dgvBaseDatos.SelectedRows[0].DataBoundItem;

            if (dtpElegirFechaTurno.Value.Date != dtpElegirFechaTurno.MinDate
                && txtMalestar.Text.Length > 0 && nivelImportancia is not null && nivelImportancia != "")
            {
                switch (nivelImportancia)
                {
                    case "URGENCIA ⚠":
                        recepcionista.CrearNuevoTurno(txtMalestar.Text, Mascota, dtpElegirFechaTurno.Value.Date, "Urgente");
                        break;
                    case "MEDIA":
                        recepcionista.CrearNuevoTurno(txtMalestar.Text, Mascota, dtpElegirFechaTurno.Value.Date, "Medio");
                        break;
                    default:
                        recepcionista.CrearNuevoTurno(txtMalestar.Text, Mascota, dtpElegirFechaTurno.Value.Date, "Normal");
                        break;


                }

                btnUrgencia.Hide();
                btnMedia.Hide();
                btnNormal.Hide();
                lblSeleccionaImportancia.Hide();
                btnCrearTurno.Hide();
                btnCargarDatos.Show();
                nivelImportancia = "";
            }
            else
            {
                MessageBox.Show("Porfavor asegurese de seleccionar una prioridad para el turno", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            Mascota Mascota = null;
            var mc = new ArchivoTxt();
            

            int dividirEx;
            int cero = 0;
            string error = String.Empty;

            try
            {
                dividirEx = 10 / cero;
            }
            catch (DivideByZeroException ex)
            {

                mc.Logger(ex); 
                mc.Escribir(error, "a");
            }
            

            if (dgvBaseDatos.SelectedRows.Count > 0 && txtMalestar.Text.Length > 0)
            {
                Mascota = (Mascota)dgvBaseDatos.SelectedRows[0].DataBoundItem;
                dgvBaseDatos.Hide();
            }
            else
            {
                Mascota = null;
            }

            if (Mascota != null)
            {
                dgvBaseDatos.Hide();
                DateTime fechaDeturno = dtpElegirFechaTurno.Value.Date;
                Dictionary<string, string> enfermedadEncontrada = new Dictionary<string, string>();
                String? malestarSeleccionado = txtMalestar.Text;
                enfermedadEncontrada = Turno.BuscarEnfermedadPorGravedad(malestarSeleccionado);
                Veterinario? veterinarioEncontrado = null;
                bool flagVeterinarioEncontrado = false;
              
                if (enfermedadEncontrada.Keys is not null && enfermedadEncontrada.Values is not null)
                {
                    KeyValuePair<string, string> kvp = enfermedadEncontrada.Single();
                    if (kvp.Value != "0" && kvp.Key != "0") // Deja de ser un single
                    {
                        string prioridadAtencion = kvp.Key;
                        string malestar = kvp.Value;

                        if (prioridadAtencion == Turno.PrioridadAtencion.Urgente.ToString() || prioridadAtencion == Turno.PrioridadAtencion.Media.ToString())
                        {
                            DialogResult resultado = MessageBox.Show($"Se recomienda una asignación automatica, de calidad {prioridadAtencion}, para este malestar", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                            if (resultado == DialogResult.OK)
                            {

                                DialogResult buscarUrgente = MessageBox.Show($"Desea buscar un Veterinario de Urgencia automaticamente para asignación inmediata de este turno?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (buscarUrgente == DialogResult.Yes)
                                {
                                    foreach (Usuario usuario in Sistema.usuario)
                                    {
                                        if (usuario is Veterinario veterinario)
                                        {
                                            if (veterinario.Especialidad == "Guardia Urgencias" || veterinario.Especialidad == "Cirujano" && veterinario.Atendiendo == false)
                                            {
                                                veterinarioEncontrado = veterinario;
                                                veterinarioEncontrado.Atendiendo = true;
                                                flagVeterinarioEncontrado = true;
                                                break;
                                            }                                           
                                        }
                                    }

                                    if(flagVeterinarioEncontrado == false)
                                    {
                                        veterinarioEncontrado = null;
                                    }
                                    if (veterinarioEncontrado != null)
                                    {

                                        recepcionista.CrearNuevoTurno(malestar, Mascota, fechaDeturno, prioridadAtencion, veterinarioEncontrado);
                                        MessageBox.Show($"Turno creado satisfactoriamente con el {malestar} y prioridad {prioridadAtencion} por parte del Veterinario: {veterinarioEncontrado.Nombre}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show($"No se ha encontrado ningun veterinario disponible, deberá asignar un veterinario luego de crearlo", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    }

                                }
                            }
                        }
                        
                    }
                    else
                    {                      
                        btnUrgencia.Show();
                        btnMedia.Show();
                        btnNormal.Show();
                        lblSeleccionaImportancia.Show();
                        btnCrearTurno.Show();
                        btnCargarDatos.Hide();
                        

                    }

                }
            }
            else
            {
                MessageBox.Show("No has seleccionado ninguna mascota, o elegido un malestar");
            }

            dgvBaseDatos.Hide();
            nivelImportancia = "";


        }

        private void BotonNivelImportancia_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            // Obtener el texto del botón seleccionado
            nivelImportancia = boton.Text;

            // Realizar acciones basadas en el nivel de importancia seleccionado
            // ...
        }

        private void btnParaHoy_Click(object sender, EventArgs e)
        {
            dtpElegirFechaTurno.Value = DateTime.Now;
        }
        
    }
}

