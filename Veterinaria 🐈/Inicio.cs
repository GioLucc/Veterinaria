using Entidades;
using Entidades.Archivos_y_Serializadores;
using Entidades.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria__
{
    public partial class Inicio : FormBase
    {
        Usuario usuarioForm;
        bool banderaTema = false;
        Color colorForm = Color.PeachPuff;
        Color colorSecundario;
        ArchivoJSON<ConfigApp> json = new ArchivoJSON<ConfigApp>();

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
                btnAsignarVeterinario.Hide();
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
                    btnAsignarVeterinario.Hide();
                    btnBaseDeDatos.Hide();
                }
            }

            lblHorarioYUsuario.Text = DateTime.Now.ToLongDateString() + "" + DateTime.Now.ToLongTimeString();
            timer1.Start();
            

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigApp cfg = json.Leer("config.json");
                if(cfg is not null)
                {
                    banderaTema = cfg.BanderaColor;
                    this.BackColor = cfg.ColorPrimario;
                    menuStripInicio.BackColor = cfg.ColorSecundario;
                    
                    if(banderaTema == true)
                    {
                        lblHorarioYUsuario.ForeColor = Color.White;
                        foreach (Control c in this.Controls)
                        {
                            if (c is Panel)
                            {
                                Panel panel = (Panel)c;

                                foreach (Control innerControl in panel.Controls)
                                {
                                    if (innerControl is Button)
                                    {
                                        Button button = (Button)innerControl;
                                        button.BackColor = Color.Silver;
                                    }
                                }
                            }
                            else if (c is Button)
                            {
                                Button button = (Button)c;
                                button.ForeColor = Color.Black;
                            }
                        }
                    }
                    else
                    {
                        foreach (Control c in this.Controls)
                        {
                            if (c is Panel)
                            {
                                Panel panel = (Panel)c;

                                foreach (Control innerControl in panel.Controls)
                                {
                                    if (innerControl is Button)
                                    {
                                        Button button = (Button)innerControl;
                                        button.BackColor = Color.DarkSalmon;
                                    }
                                }
                            }
                            else if (c is Button)
                            {
                                Button button = (Button)c;
                                button.ForeColor = Color.Black;
                            }
                        }
                        panelInicio.BackColor = Color.Bisque;                       
                    }
                }
            }
            catch(Exception)
            {
                FormBaseMenu.MostrarAdvertencia("Error en la carga del cfg");
            }

        }

        private void btn_Turnos_Click(object sender, EventArgs e)
        {
            if (banderaTema == true)
            {
                colorForm = Color.DimGray;
            }

            FormTurnos gestionTurnos = new FormTurnos(usuarioForm, colorForm);
            this.Hide();

            DialogResult retornoAlta = gestionTurnos.ShowDialog();

            if (retornoAlta == DialogResult.OK)
            {
                this.Show();
            }


        }

        private void btn_NuestrasAnimalDomesticos_Click(object sender, EventArgs e)
        {

            if (banderaTema == true)
            {
                colorForm = Color.DimGray;
            }

            FormAnimalDomestico AnimalDomestico = new FormAnimalDomestico(colorForm);
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

            if (banderaTema == true)
            {
                colorForm = Color.DimGray;
            }

            FormAlta darDeAlta = new FormAlta(usuarioForm, colorForm);
            this.Hide();

            DialogResult retornoAlta = darDeAlta.ShowDialog();

            if (retornoAlta == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnDesloguearse_Click(object sender, EventArgs e)
        {         
            if (banderaTema == true)
            {
                colorForm = Color.DimGray;
            }

            Login login = new Login(colorForm);
            this.Hide();

            login.Show();
  
        }
        private void btnAdminAlta_Click(object sender, EventArgs e)
        {
            if (banderaTema == true)
            {
                colorForm = Color.DimGray;
            }

            FormAlta darDeAlta = new FormAlta(usuarioForm,colorForm);
            this.Hide();

            DialogResult retornoAlta = darDeAlta.ShowDialog();

            if (retornoAlta == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {

            if (banderaTema == true)
            {
                colorForm = Color.DimGray;
            }

            AtenderPacientes atender = new AtenderPacientes(usuarioForm,colorForm);
            this.Hide();

            DialogResult retornoAlta = atender.ShowDialog();

            if (retornoAlta == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnAsignarVeterinario_Click(object sender, EventArgs e)
        {
            if(banderaTema == true)
            {
                colorForm = Color.DimGray;
            }

            AsignarVeterinario atender = new AsignarVeterinario(usuarioForm, colorForm);
            this.Hide();
            DialogResult retornoAlta = atender.ShowDialog();


            if (retornoAlta == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void opacoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banderaTema = true;
            this.menuStripInicio.BackColor = Color.DarkSlateGray;
            this.BackColor = Color.DimGray;
            colorForm = Color.DimGray;
            colorSecundario = Color.DarkSlateGray;
            lblHorarioYUsuario.ForeColor = Color.White;
            int red = 81;              
            int green = 81;  
            int blue = 81;   
            Color colorFondo = Color.FromArgb(red, green, blue);

            panelInicio.BackColor = colorFondo;

            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    Panel panel = (Panel)c;

                    foreach (Control innerControl in panel.Controls)
                    {
                        if (innerControl is Button)
                        {
                            Button button = (Button)innerControl;
                            button.BackColor = Color.Silver;
                        }
                    }
                }
                else if (c is Button)
                {
                    Button button = (Button)c;
                    button.ForeColor = Color.Black;
                }
            }

        }

        private void claroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banderaTema = false;
            colorForm = Color.PeachPuff;
            colorSecundario = Color.PeachPuff;
            this.menuStripInicio.BackColor = Color.PeachPuff;
            this.BackColor = Color.PeachPuff;
            this.panelInicio.BackColor = Color.Bisque;


            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    Panel panel = (Panel)c;

                    foreach (Control innerControl in panel.Controls)
                    {
                        if (innerControl is Button)
                        {
                            Button button = (Button)innerControl;
                            button.BackColor = Color.DarkSalmon;
                        }
                    }
                }
                else if (c is Button)
                {
                    Button button = (Button)c;
                    button.ForeColor = Color.Black;
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            string tipoUsuario = "";

            if (usuarioForm is Veterinario)
            {
                tipoUsuario = "Veterinario";
            }
            else if (usuarioForm is Administrador)
            {
                tipoUsuario = "Administrador";
            }
            else if (usuarioForm is Recepcionista)
            {
                tipoUsuario = "Recepcionista";
            }

            string diaSemana = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
            diaSemana = diaSemana.Substring(0, 1).ToUpper() + diaSemana.Substring(1);

            lblHorarioYUsuario.Text = usuarioForm.Nombre + " - " + tipoUsuario + " | " + diaSemana + " " + DateTime.Now.ToLongTimeString();
        }

        private void guardarCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigApp cfg = new ConfigApp(banderaTema, this.BackColor, colorSecundario);
                json.Escribir("a", cfg);
            }
            catch(Exception)
            {
                FormBaseMenu.MostrarAdvertencia("Error en la carga del cfg");

            }


        }
    }
}
