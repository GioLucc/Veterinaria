using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veterinaria__
{
    public partial class FormAlta : FormBaseMenu
    { 
        public FormAlta(Usuario usuario) : base(usuario)
        { 
            InitializeComponent();
            dataGridView1.Hide();

            txtIdDueño.Hide();
            txtPeso.Hide();                         
            lblEspecie.Text = "Usuario";
            lblEnfermeddadActual.Text = "Contraseña";
            lblRaza.Text = "Nombre";
            lblNombreAnimalDomestico.Text = "Apellido";
            lblNombreDueño.Text = "DNI";
            lblEdad.Text = "Fecha de Nacimiento";
            lblIdDueño.Text = "Trabajando";
            lblPeso.Text = "Administrador";
            lblNombreDueño.Location = new Point(lblNombreDueño.Location.X + 35, lblNombreDueño.Location.Y + 0);
            lblNombreAnimalDomestico.Location = new Point(lblNombreAnimalDomestico.Location.X + 25, lblNombreAnimalDomestico.Location.Y + 0);
            lblEdad.Location = new Point(lblEdad.Location.X - 40, lblEdad.Location.Y + 0);
            lblPeso.Location = new Point(lblPeso.Location.X - 20, lblPeso.Location.Y + 0);
            lblSexo.Text = "Sueldo";

            if(usuario is Veterinario || usuario is Recepcionista)
            {
                chkTrabajando.Hide();
                chkEsAdmin.Hide();
                btnValidarAdmin.Hide();
                cmbJerarquia.Hide();
                lblJerarquia.Hide();
            }
                
        }
        
        public Veterinario ValidarDatosTrabajador()
        {
            Veterinario usuarioACrear = null;
            short IdUsuario = Sistema.GenerarIdCliente();
            String nombre = txtRaza.Text;
            String apellido = txtNombreAnimalDomestico.Text;
            DateTime fechaNacimiento = dtpNacimiento.Value.Date;
            String usuario = txtEspecie.Text;
            String contraseñaUsuario = txtEnfermedadActual.Text;
            bool trabajando = chkTrabajando.Checked;
            float sueldo;
            int dni;

            int edad = Sistema.CalcularEdad(fechaNacimiento);

            if(int.TryParse(txtNombreDueño.Text, out dni) &&  float.TryParse(txtSexo.Text, out sueldo) &&IdUsuario != 0 && nombre.Length > 0 && apellido.Length >0 && dni > 10000 && fechaNacimiento.Date != DateTime.Now && usuario.Length > 0 && contraseñaUsuario.Length > 0 && sueldo > 0 && cmbJerarquia.SelectedItem != null)
            {
                Veterinario nuevoUsuario = new Veterinario(IdUsuario, nombre, apellido, dni, edad, usuario, contraseñaUsuario,true,sueldo,"Cirujano",false);

                usuarioACrear = nuevoUsuario;
            }

            return usuarioACrear;
        }
        private void btnValidarAdmin_Click(object sender, EventArgs e)
        {
            Veterinario usuarioACrear;
            Administrador administrador = new Administrador();
            usuarioACrear = ValidarDatosTrabajador();

            if (usuarioACrear != null)
            {
                administrador.Alta(usuarioACrear);
                
            }
            else
            {
                FormBase.MostrarAdvertencia("Se ha ingresado un dato erroneo dentro de los campos.");
            }
        }

        public Mascota ValidarDatosMascota()
        {
            Mascota mascotaCreada = null;
            String tipoAnimalDomestico = txtEspecie.Text; 
            String raza = txtRaza.Text; 
            DateTime fechaNacimiento = dtpNacimiento.Value.Date;
            float peso;
            char sexo;
            String nombreAnimal = txtNombreAnimalDomestico.Text;
            String apellidoDueño = txtNombreDueño.Text;
            if (float.TryParse(txtPeso.Text, out peso) &&  char.TryParse(txtSexo.Text, out sexo) && tipoAnimalDomestico.Length != 0 && raza.Length != 0 && nombreAnimal.Length != 0 && peso != 0 && apellidoDueño.Length != 0)
            {               
                Mascota nuevaAnimalDomestico = new Mascota(tipoAnimalDomestico, raza, peso, sexo, nombreAnimal, apellidoDueño, Sistema.GenerarId(), fechaNacimiento);
                mascotaCreada = nuevaAnimalDomestico;
            }
           
            return mascotaCreada;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Mascota mascotaACrear;
            Recepcionista recepcionista = new Recepcionista();
            mascotaACrear = ValidarDatosMascota();
            if(mascotaACrear != null)
            {
                recepcionista.Alta(mascotaACrear);
                Sistema.AnimalDomesticos.Add(mascotaACrear);
            }
            else
            {
                FormBase.MostrarAdvertencia("Se ha ingresado un dato erroneo dentro de los campos.");
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Sistema.AnimalDomesticos;
            dataGridView1.Show();
        }

        private void btnAdminLista_Click(object sender, EventArgs e)
        {
            setDGV();
            dataGridView1.DataSource = Sistema.usuario;
            dataGridView1.Show();
        }

        public void setDGV()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Establece la fuente y el estilo de los encabezados de columna
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10); // Establece la fuente y el estilo de las celdas
            dataGridView1.DefaultCellStyle.BackColor = Color.White; // Establece el color de fondo de las celdas
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Establece el color de fuente de las celdas
            dataGridView1.RowHeadersVisible = false; // Oculta las filas de encabezado
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Establece el modo de selección
            dataGridView1.MultiSelect = false; // Desactiva la selección múltiple
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ReadOnly = true;

            //Esto no funciona
            //dataGridView1.Columns[0].HeaderText = "Id";
            //dataGridView1.Columns[1].HeaderText = "Usuario";
            //dataGridView1.Columns[2].HeaderText = "Contraseña";
            

        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            
        }
    }
}
