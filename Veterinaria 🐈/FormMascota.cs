using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria__
{
   
    public partial class FormAnimalDomestico : FormBaseMenu
    {
        bool ordenarPorNombre = false;
        bool ordenarPorId = false;
        bool ordenarPorApellido = false;
        Mascota mascotaHistorial;

        public FormAnimalDomestico(Color color)
        {
            InitializeComponent();
            dgvRegistroMascotas.CellContentClick += dataGridView1_CellContentClick;
            dgvFechaTurnos.Hide();
            this.BackColor = color;
        }

        private void FormAnimalDomestico_Load(object sender, EventArgs e)
        {
            dgvRegistroMascotas.Show();
            dgvPrueba.Hide();
            dgvRegistroMascotas.DataSource = Sistema.AnimalDomesticos;
            dgvRegistroMascotas.Columns["FechaDeNacimiento"].Visible = false;
            dgvRegistroMascotas.Columns["Raza"].Visible = false;
            dgvRegistroMascotas.Columns["Edad"].Visible = false;
            dgvRegistroMascotas.Columns["Especie"].Visible = false;
            dgvRegistroMascotas.Columns["Peso"].Visible = false;
            dgvRegistroMascotas.Columns["Sexo"].Visible = false;
            setDGV();        
        }

        public void setDGVHistorial()
        {
            dgvFechaTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFechaTurnos.AutoResizeColumns();
            dgvFechaTurnos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Establece la fuente y el estilo de los encabezados de columna
            dgvFechaTurnos.DefaultCellStyle.Font = new Font("Arial", 10); // Establece la fuente y el estilo de las celdas
            dgvFechaTurnos.DefaultCellStyle.BackColor = Color.White; // Establece el color de fondo de las celdas
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
            dgvFechaTurnos.DataSource = mascotaHistorial.HistoriaClinica;
            dgvFechaTurnos.Columns["TratamientoAplicado"].Visible = false;
            dgvFechaTurnos.Columns["VeterinarioQueAtendio"].HeaderText = "Atendido Por";
        }

        public void setDGV ()
        {
            dgvRegistroMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRegistroMascotas.AutoResizeColumns();
            dgvRegistroMascotas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Establece la fuente y el estilo de los encabezados de columna
            dgvRegistroMascotas.DefaultCellStyle.Font = new Font("Arial", 10); // Establece la fuente y el estilo de las celdas
            dgvRegistroMascotas.DefaultCellStyle.BackColor = Color.White; // Establece el color de fondo de las celdas
            dgvRegistroMascotas.DefaultCellStyle.ForeColor = Color.Black; // Establece el color de fuente de las celdas
            dgvRegistroMascotas.RowHeadersVisible = false; // Oculta las filas de encabezado
            dgvRegistroMascotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Establece el modo de selección
            dgvRegistroMascotas.MultiSelect = false; // Desactiva la selección múltiple
            dgvRegistroMascotas.AllowUserToResizeRows = false;
            dgvRegistroMascotas.ReadOnly = true;
            dgvRegistroMascotas.AllowUserToResizeColumns = false;
            dgvRegistroMascotas.Columns[4].HeaderText = "Id";
            dgvRegistroMascotas.Columns[5].HeaderText = "Nombre Mascota";
            dgvRegistroMascotas.Columns[6].HeaderText = "Apellido Dueño";
            
            dgvPrueba.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPrueba.AutoResizeColumns();
            dgvPrueba.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Establece la fuente y el estilo de los encabezados de columna
            dgvPrueba.DefaultCellStyle.Font = new Font("Arial", 10); // Establece la fuente y el estilo de las celdas
            dgvPrueba.DefaultCellStyle.BackColor = Color.White; // Establece el color de fondo de las celdas
            dgvPrueba.DefaultCellStyle.ForeColor = Color.Black; // Establece el color de fuente de las celdas
            dgvPrueba.RowHeadersVisible = false; // Oculta las filas de encabezado
            dgvPrueba.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Establece el modo de selección
            dgvPrueba.MultiSelect = false; // Desactiva la selección múltiple
            dgvPrueba.AllowUserToResizeRows = false;
            dgvPrueba.ReadOnly = true;
            dgvPrueba.AllowUserToResizeColumns = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow selectedRow = dgvRegistroMascotas.CurrentRow;
            Mascota Mascota = (Mascota)selectedRow.DataBoundItem;

            List<Mascota> AnimalDomesticos = new List<Mascota>();
            AnimalDomesticos.Add(Mascota);

            dgvPrueba.Show();
            dgvPrueba.DataSource = AnimalDomesticos;
            dgvPrueba.Columns[0].HeaderText = "Especie";
            dgvPrueba.Columns[1].HeaderText = "Raza";
            dgvPrueba.Columns[2].HeaderText = "Peso";
            dgvPrueba.Columns[3].HeaderText = "Sexo";
            dgvPrueba.Columns[4].HeaderText = "Id";
            dgvPrueba.Columns[5].HeaderText = "Nombre";
            dgvPrueba.Columns[6].HeaderText = "Apellido";
            dgvRegistroMascotas.Columns["FechaDeNacimiento"].Visible = false;
            dgvPrueba.Columns[8].HeaderText = "Edad";



            if (dgvRegistroMascotas.SelectedRows.Count > 0)
            {
                dgvFechaTurnos.DataSource = null;
                mascotaHistorial = (Mascota)dgvRegistroMascotas.CurrentRow.DataBoundItem;
                setDGVHistorial();
                dgvFechaTurnos.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ordenarPorId)
            {
                var idsOrdenados = Sistema.AnimalDomesticos.OrderBy(mascota => mascota.IdMascota).ToList();
                dgvRegistroMascotas.DataSource = idsOrdenados;

                ordenarPorId = true;
            }
            else
            {
                var idsOrdenadosDesc = Sistema.AnimalDomesticos.OrderByDescending(mascota => mascota.IdMascota).ToList();
                dgvRegistroMascotas.DataSource = idsOrdenadosDesc;

                ordenarPorId = false;
            }
        }

        private void btnNameSorting_Click(object sender, EventArgs e)
        {           
            if (ordenarPorNombre is not true)
            {
                var mascotasOrdenadas = Sistema.AnimalDomesticos.OrderBy((mascota => mascota.NombreAnimal)).ToList();
                dgvRegistroMascotas.DataSource = mascotasOrdenadas;
               
                ordenarPorNombre = true;
            }
            else
            {
                dgvRegistroMascotas.DataSource = Sistema.AnimalDomesticos;
                ordenarPorNombre = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ordenarPorApellido is not true)
            {
                var apellidosOrdenados = Sistema.AnimalDomesticos.OrderBy((mascota => mascota.ApellidoDueño)).ToList();
                dgvRegistroMascotas.DataSource = apellidosOrdenados;

                ordenarPorNombre = true;
            }
            else
            {
                dgvRegistroMascotas.DataSource = Sistema.AnimalDomesticos;
                ordenarPorNombre = false;
            }
        }
    }
}
