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
    public partial class FormBaseMenu : Form
    {
        Usuario usuarioForm;
        private int posY;
        private int posX;
        private bool movimientoActivo;

        public FormBaseMenu()
        {
            InitializeComponent();
        }

        public FormBaseMenu(Usuario usuario, Color color): this()
        {
            InitializeComponent();
            this.usuarioForm = usuario;
            label1.Text = DateTime.Now.ToLongDateString() + "" + DateTime.Now.ToLongTimeString();
            timEstatus.Start();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void timEstatus_Tick(object sender, EventArgs e)
        {
            label1.Text = usuarioForm.Apellido + " " + usuarioForm.Nombre + " - " + usuarioForm.GetType() + " | " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void FormBaseMenu_MouseUp(object sender, MouseEventArgs e)
        {
            movimientoActivo = false;
        }

        private void FormBaseMenu_MouseDown(object sender, MouseEventArgs e)
        {
            movimientoActivo = true;
            posX = e.X;
            posY = e.Y;
        }

        private void FormBaseMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (movimientoActivo == true)
            {
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
            }
        }

        public static void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
