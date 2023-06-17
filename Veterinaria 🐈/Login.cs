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
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLoguear_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text is not null && txtPassword.Text is not null)
            {
                Usuario usuarioDevuelto;

                usuarioDevuelto = Sistema.ValidarUsuario(txtUsername.Text, txtPassword.Text);

                if (usuarioDevuelto == null)
                {

                    this.txtUsername.BackColor = Color.Red;
                    this.txtPassword.BackColor = Color.Red;
                }
                else
                {
                    this.txtUsername.BackColor = Color.Green;
                    this.txtPassword.BackColor = Color.Green;
                    Inicio nuevoLogin = new Inicio(usuarioDevuelto);
                    this.Hide();
                    nuevoLogin.Show();
                    //foreach (Veterinario item in Sistema.usuarios)
                    //{
                    //    if(item.Nombre == "Giovanni")
                    //    {
                    //        Inicio nuevoLogin = new Inicio(item);
                    //        this.Hide();
                    //        nuevoLogin.Show();
                    //    }
                    //    else
                    //    {
                    //        if(item.Jerarquia == Jerarquia.Administrador)
                    //        {
                    //            Inicio nuevoLogin = new Inicio(item);
                    //            this.Hide();
                    //            nuevoLogin.Show();
                    //        }
                    //    }
                }




            }

            
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
                    this.txtUsername.Text = "0nimdaPetShop";
                    this.txtPassword.Text = "WtTK*Qv%nauSUDo2M0^F";
                }
                else
                {
                    if (rng == 2)
                    {
                        this.txtUsername.Text = "01nimdaPetShop";
                        this.txtPassword.Text = "D75MUx8KiN@%5Yo6AMK6";
                    }

                }
            }
        }
    }
}
