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

namespace Veterinaria__
{
    public partial class FormAlta : FormBaseMenu
    { 
        public FormAlta(Usuario usuario) : base(usuario)
        { 
            InitializeComponent();
            dataGridView1.Hide();
            if(usuario.Jerarquia == Jerarquia.Administrador)
            {
                

                txtIdDueño.Hide();
                txtPeso.Hide();
                txtSexo.Hide();
                lblSexo.Hide();

               
                lblEspecie.Text = "Usuario";
                lblEnfermeddadActual.Text = "Contraseña";
                lblRaza.Text = "Nombre";
                lblNombreMascota.Text = "Apellido";
                lblNombreDueño.Text = "DNI";
                lblEdad.Text = "Fecha de Nacimiento";
                lblIdDueño.Text = "Trabajando";
                lblPeso.Text = "Administrador";
                lblNombreDueño.Location = new Point(lblNombreDueño.Location.X + 35, lblNombreDueño.Location.Y + 0);
                lblNombreMascota.Location = new Point(lblNombreMascota.Location.X + 25, lblNombreMascota.Location.Y + 0);
                lblEdad.Location = new Point(lblEdad.Location.X - 40, lblEdad.Location.Y + 0);
                lblPeso.Location = new Point(lblPeso.Location.X - 20, lblPeso.Location.Y + 0);
            }
            else
            {
                chkTrabajando.Hide();
                chkEsAdmin.Hide();
                btnValidarAdmin.Hide();
            }
        }


        public void AgregarTrabajador()
        {
            int IdUsuario = Sistema.GenerarIdCliente();
            String nombre = txtRaza.Text;
            String apellido = txtNombreMascota.Text;
            String dni = txtNombreDueño.Text;
            DateTime fechaNacimiento = dtpNacimiento.Value.Date;
           // string dni = txtIdDueño.Text;
            String Usuario = txtEspecie.Text;
            String contraseñaUsuario = txtEnfermedadActual.Text;
            bool esAdmin = chkEsAdmin.Checked;
            bool trabajando = chkTrabajando.Checked;
            // Acá viene que jerarquia
        }

        public void AgregarMascota()
        {
            String tipoMascota = txtEspecie.Text; 
            String raza = txtRaza.Text; 
            DateTime fechaNacimiento = dtpNacimiento.Value.Date;
            float peso = float.Parse(txtPeso.Text);
            char sexo = char.Parse(txtSexo.Text);
            String enfermedadActual = txtEnfermedadActual.Text; 
            String nombreMascota = txtNombreMascota.Text;
            String nombreDueño = txtNombreDueño.Text;
            int IdDueño = int.Parse(txtIdDueño.Text);


            if(tipoMascota.Length != 0 && raza.Length != 0
                 && nombreMascota.Length != 0 &&
                peso != 0 && enfermedadActual.Length != 0 && nombreDueño.Length != 0 && IdDueño > 0)
            { 
                Mascota nuevaMascota = new Mascota(tipoMascota, raza, peso, sexo,enfermedadActual, nombreMascota, nombreDueño, IdDueño, fechaNacimiento);

                Sistema.mascotas.Add(nuevaMascota);
                MessageBox.Show(nuevaMascota.ToString());
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            AgregarMascota();
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Show();
            dataGridView1.DataSource = Sistema.mascotas;
        }

        private void btnValidarAdmin_Click(object sender, EventArgs e)
        {


            AgregarTrabajador();
        }
    }
}
