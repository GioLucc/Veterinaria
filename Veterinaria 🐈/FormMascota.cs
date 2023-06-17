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
        public FormAnimalDomestico()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void FormAnimalDomestico_Load(object sender, EventArgs e)
        {
            dataGridView1.Show();
            dgvPrueba.Hide();
            dataGridView1.DataSource = Sistema.AnimalDomesticos;
            dataGridView1.Columns["FechaDeNacimiento"].Visible = false;
            dataGridView1.Columns["Raza"].Visible = false;
            dataGridView1.Columns["Edad"].Visible = false;
            dataGridView1.Columns["Especie"].Visible = false;
            dataGridView1.Columns["Peso"].Visible = false;
            dataGridView1.Columns["Sexo"].Visible = false;
            setDGV();        
        }

        public void setDGV ()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Establece la fuente y el estilo de los encabezados de columna
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10); // Establece la fuente y el estilo de las celdas
            dataGridView1.DefaultCellStyle.BackColor = Color.White; // Establece el color de fondo de las celdas
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Establece el color de fuente de las celdas
            dataGridView1.RowHeadersVisible = false; // Oculta las filas de encabezado
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Establece el modo de selección
            dataGridView1.MultiSelect = false; // Desactiva la selección múltiple
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Nombre Mascota";
            dataGridView1.Columns[2].HeaderText = "Nombre Dueño";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            Mascota Mascota = (Mascota)selectedRow.DataBoundItem;

            List<Mascota> AnimalDomesticos = new List<Mascota>();
            AnimalDomesticos.Add(Mascota);

            dgvPrueba.Show();
            dgvPrueba.DataSource = AnimalDomesticos;

            //PrintDocument documento = new PrintDocument();
            //documento.DefaultPageSettings.Color = true;
            //documento.DefaultPageSettings.PaperSize = new PaperSize("Historial", 850, 1100);
            //documento.DefaultPageSettings.Landscape = false;
            //documento.DocumentName = Mascota.nombreAnimal + " --  " + Mascota.Raza;

            ////documento.PrintPage += new PrintPageEventHandler();


        }
    }
}
