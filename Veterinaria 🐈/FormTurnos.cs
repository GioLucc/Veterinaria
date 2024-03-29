﻿using Entidades;
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
        Usuario recepcionistaActual;
        private string? nivelImportancia;
        Recepcionista recepcionista = new Recepcionista();
        SerializadoraXML<Dictionary<string, List<string>>> serializadora = new SerializadoraXML<Dictionary<string, List<string>>>();
        public event Action MalestarUrgenciaAgregado;
        private string gravedadActual;

        public FormTurnos(Usuario veterinario)
        {
            InitializeComponent();
            recepcionistaActual = veterinario;
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
        private void FormTurnos_Load(object sender, EventArgs e)
        {
            MalestarUrgenciaAgregado += FormTurnos_MalestarUrgenciaAgregado;
        }

        public FormTurnos(Usuario usuarioForm, Color color) : this(usuarioForm)
        {
            this.BackColor = color;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadirMascota_Click(object sender, EventArgs e)
        {
            FormAlta darDeAlta = new FormAlta(recepcionistaActual);
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
            dgvBaseDatos.Columns[4].HeaderText = "Identificación";
            dgvBaseDatos.Columns[5].HeaderText = "Nombre Mascota";
            dgvBaseDatos.Columns[6].HeaderText = "Apellido Dueño";
            dgvBaseDatos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvBaseDatos.ReadOnly = true;
            dgvBaseDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBaseDatos.AutoResizeColumns();

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
                        gravedadActual = "Urgente";
                        

                        break;
                    case "MEDIA":
                        recepcionista.CrearNuevoTurno(txtMalestar.Text, Mascota, dtpElegirFechaTurno.Value.Date, "Media");
                        gravedadActual = "Media";

                        break;
                    default:
                        recepcionista.CrearNuevoTurno(txtMalestar.Text, Mascota, dtpElegirFechaTurno.Value.Date, "Normal");
                        gravedadActual= "Normal";
                        break;
                }
                MalestarUrgenciaAgregado.Invoke();

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

        private void txtMalestar_MouseEnter(object sender, EventArgs e)
        {
            dgvBaseDatos.Hide();
        }

        private void FormTurnos_MalestarUrgenciaAgregado()
        {
            //Sistema.malestaresPorGravedad[gravedadActual].Add(txtMalestar.Text);
            serializadora.Escribir("path", Sistema.malestaresPorGravedad);
            FormBaseMenu.MostrarAdvertencia($"Se ha agregado el nuevo malestar: {txtMalestar.Text} para la auto-asignación a futuro de calidad {gravedadActual}");
        }
    }
}

