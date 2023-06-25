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
        Mascota mascotaHitorial;

        public FormAnimalDomestico()
        {
            InitializeComponent();
            dgvRegistroMascotas.CellContentClick += dataGridView1_CellContentClick;
            dgvFechaTurnos.Hide();
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
            dgvFechaTurnos.DataSource = mascotaHitorial.HistoriaClinica;
            dgvFechaTurnos.Columns["TratamientoAplicado"].Visible = false;
            dgvFechaTurnos.Columns["VeterinarioQueAtendio"].HeaderText = "Atendido Por";
        }

        public void setDGV ()
        {
            dgvRegistroMascotas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Establece la fuente y el estilo de los encabezados de columna
            dgvRegistroMascotas.DefaultCellStyle.Font = new Font("Arial", 10); // Establece la fuente y el estilo de las celdas
            dgvRegistroMascotas.DefaultCellStyle.BackColor = Color.White; // Establece el color de fondo de las celdas
            dgvRegistroMascotas.DefaultCellStyle.ForeColor = Color.Black; // Establece el color de fuente de las celdas
            dgvRegistroMascotas.RowHeadersVisible = false; // Oculta las filas de encabezado
            dgvRegistroMascotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Establece el modo de selección
            dgvRegistroMascotas.MultiSelect = false; // Desactiva la selección múltiple
            dgvRegistroMascotas.AllowUserToResizeRows = false;
            dgvRegistroMascotas.AllowUserToResizeColumns = false;
            dgvRegistroMascotas.Columns[0].HeaderText = "Id";
            dgvRegistroMascotas.Columns[1].HeaderText = "Nombre Mascota";
            dgvRegistroMascotas.Columns[2].HeaderText = "Nombre Dueño";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvRegistroMascotas.Rows[index];
            Mascota Mascota = (Mascota)selectedRow.DataBoundItem;

            List<Mascota> AnimalDomesticos = new List<Mascota>();
            AnimalDomesticos.Add(Mascota);

            dgvPrueba.Show();
            dgvPrueba.DataSource = AnimalDomesticos;

            if (dgvRegistroMascotas.SelectedRows.Count > 0)
            {
                dgvFechaTurnos.DataSource = null;
                mascotaHitorial = (Mascota)dgvRegistroMascotas.CurrentRow.DataBoundItem;
                setDGVHistorial();
                dgvFechaTurnos.Show();


            }
        }
    }
}
