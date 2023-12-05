using Entidades;
using Entidades.Archivos_y_Serializadores;
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
    public partial class Login : FormBase
    {
        ArchivoJSON<ConfigApp> json = new ArchivoJSON<ConfigApp>();
        bool banderaTema = false;
        Color colorForm = Color.PeachPuff;
        Color colorSecundario;


        public Login()
        {
            InitializeComponent();
        }

        public Login(Color color) : this()
        {
            this.BackColor = color;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ConfigApp cfg = json.Leer("config.json");
            banderaTema = cfg.BanderaColor;
            this.BackColor = cfg.ColorPrimario;
        }
        private void btnLoguear_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            Administrador administrador = new Administrador();

            //if (txtUsername.Text.StartsWith("nimdaPetShop"))
            //{
                usuario = Sistema.ValidarUsuario(txtUsername.Text, txtPassword.Text);
            //}
            //else
            //{
            //    usuario = usuario.LoguearUsuario(txtUsername.Text, txtPassword.Text);
            //}
            
            Inicio inicio = new Inicio(usuario);
            inicio.Show();
            this.Hide();
        }

        private void pic_Ocultar_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.PasswordChar == '*')
            {
                pic_Mostrar.BringToFront();
                this.txtPassword.PasswordChar = '\0';
            }
        }

        private void pic_Mostrar_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.PasswordChar == '\0')
            {
                pic_Ocultar.BringToFront();
                this.txtPassword.PasswordChar = '*';
            }
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void txtUsername_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnLoguear_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnLoguear_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pic_Ocultar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pic_Ocultar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pic_Admin_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pic_Admin_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pic_Admin_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            int rng = random.Next(0, 2);

            for (int i = 0; i < 1; i++)
            {
                if (rng == 1)
                {
                    this.txtUsername.Text = "nimdaPetShop0";
                    this.txtPassword.Text = "WtTK*Qv%nauSUDo2M0^F";
                }
                else
                {
                    if (rng == 2)
                    {
                        this.txtUsername.Text = "nimdaPetShop0";
                        this.txtPassword.Text = "WtTK*Qv%nauSUDo2M0^F";
                    }

                }
            }
        }


    }
}
