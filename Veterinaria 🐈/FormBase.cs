namespace Veterinaria__
{
    public partial class FormBase : Form
    {
        private int posY;
        private int posX;
        private bool movimientoActivo;
        public FormBase()
        {
            InitializeComponent();           
        }

        
        private void FormBase_MouseUp(object sender, MouseEventArgs e)
        {
            movimientoActivo = false;
        }

        private void FormBase_MouseDown(object sender, MouseEventArgs e)
        {
            movimientoActivo = true;
            posX = e.X;
            posY = e.Y;
        }

        private void FormBase_MouseMove(object sender, MouseEventArgs e)
        {
            if (movimientoActivo == true)
            {
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
            }        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea abandonar la aplicación?", "¡Atención!", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) ==
            DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}