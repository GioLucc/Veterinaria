using Entidades;
using Entidades.DB;
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

            if (usuarioForm is Administrador)
            {
                btnAtender.Hide();
                btn_DarDeAlta.Hide();
                btn_GestionarPaciente.Hide();
                btn_NuestrasAnimalDomesticos.Hide();
                btn_Turnos.Hide();
            }
            else
            {   
                if(usuarioForm is Recepcionista)
                {
                    btnAtender.Hide();
                    btnAdminAlta.Hide();
                    btnAdminBaja.Hide();
                    btnAdminModificacion.Hide();

                }
                else
                {
                    btn_Turnos.Hide();
                    btn_DarDeAlta.Hide();
                    btnAdminAlta.Hide();
                    btnAdminBaja.Hide();
                    btnAdminModificacion.Hide();
                }
            }
            lblHorarioYUsuario.Text = DateTime.Now.ToLongDateString() + "" + DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    lblHorarioYUsuario.Text = usuarioForm.Apellido + " " + usuarioForm.Nombre + " - "  + usuarioForm.JerarquiaUsuario + " | " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        //}

        private void btn_Turnos_Click(object sender, EventArgs e)
        {
            FormTurnos gestionTurnos = new FormTurnos(usuarioForm);
            this.Hide();

            DialogResult retornoAlta = gestionTurnos.ShowDialog();

            if (retornoAlta == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btn_NuestrasAnimalDomesticos_Click(object sender, EventArgs e)
        {
            FormAnimalDomestico AnimalDomestico = new FormAnimalDomestico();
            this.Hide();

            DialogResult retornoAlta = AnimalDomestico.ShowDialog();

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

        private void btnAtender_Click(object sender, EventArgs e)
        {
            AtenderPacientes atender = new AtenderPacientes(usuarioForm);
            this.Hide();

            DialogResult retornoAlta = atender.ShowDialog();

            if (retornoAlta == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnAsignarVeterinario_Click(object sender, EventArgs e)
        {
            AsignarVeterinario atender = new AsignarVeterinario(usuarioForm);
            this.Hide();

            DialogResult retornoAlta = atender.ShowDialog();

            if (retornoAlta == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}
