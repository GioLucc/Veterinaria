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
    public partial class Inicio : FormBase
    {
        Usuario usuarioForm;

        public Inicio(Usuario usuarioForm)
        {
            InitializeComponent();
            this.usuarioForm = usuarioForm;

            if (usuarioForm.Jerarquia == Jerarquia.Administrador)
            {
                btn_DarDeAlta.Hide();
                btn_GestionarPaciente.Hide();
                btn_NuestrasMascotas.Hide();
                btn_Turnos.Hide();
            }
            else
            {

            }
            lblHorarioYUsuario.Text = DateTime.Now.ToLongDateString() + "" + DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHorarioYUsuario.Text = usuarioForm.Apellido + " " + usuarioForm.Nombre + " - "  + usuarioForm.Jerarquia + " | " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void btn_Turnos_Click(object sender, EventArgs e)
        {

        }

        private void btn_NuestrasMascotas_Click(object sender, EventArgs e)
        {
            FormMascota mascota = new FormMascota();
            this.Hide();

            DialogResult retornoAlta = mascota.ShowDialog();

            if (retornoAlta == DialogResult.OK)
            {
                this.Show();
            }
            
        }

        private void btn_GestionarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void btn_DarDeAlta_Click(object sender, EventArgs e)
        {
            FormAlta darDeAlta = new FormAlta(usuarioForm);
            this.Hide();

            DialogResult retornoAlta = darDeAlta.ShowDialog();

            if (retornoAlta == DialogResult.OK)
            {
                this.Show();
            }

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnDesloguearse_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();

            login.Show();
  
        }

        private void btnAdminAlta_Click(object sender, EventArgs e)
        {
            FormAlta darDeAlta = new FormAlta(usuarioForm);
            this.Hide();

            DialogResult retornoAlta = darDeAlta.ShowDialog();

            if (retornoAlta == DialogResult.OK)
            {
                this.Show();
            }
        }

        //private void mostrarInformación ()
        //{
        //    if(usuarioForm.Jerarquia == Jerarquia.Administrador)
        //    {

        //    }
        //}


    }
}
