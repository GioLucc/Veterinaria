namespace Veterinaria__
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHorarioYUsuario = new System.Windows.Forms.Label();
            this.btn_Turnos = new System.Windows.Forms.Button();
            this.btn_NuestrasAnimalDomesticos = new System.Windows.Forms.Button();
            this.btn_DarDeAlta = new System.Windows.Forms.Button();
            this.btn_GestionarPaciente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDesloguearse = new System.Windows.Forms.Button();
            this.btnAdminAlta = new System.Windows.Forms.Button();
            this.btnAdminModificacion = new System.Windows.Forms.Button();
            this.btnAdminBaja = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnAsignarVeterinario = new System.Windows.Forms.Button();
            this.btnBaseDeDatos = new System.Windows.Forms.Button();
            this.menuStripInicio = new System.Windows.Forms.MenuStrip();
            this.temaDelInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStripInicio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblHorarioYUsuario
            // 
            this.lblHorarioYUsuario.AutoSize = true;
            this.lblHorarioYUsuario.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHorarioYUsuario.Location = new System.Drawing.Point(1, 639);
            this.lblHorarioYUsuario.Name = "lblHorarioYUsuario";
            this.lblHorarioYUsuario.Size = new System.Drawing.Size(134, 23);
            this.lblHorarioYUsuario.TabIndex = 1;
            this.lblHorarioYUsuario.Text = "Nombre y Hora";
            // 
            // btn_Turnos
            // 
            this.btn_Turnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Turnos.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Turnos.Location = new System.Drawing.Point(54, 39);
            this.btn_Turnos.Name = "btn_Turnos";
            this.btn_Turnos.Size = new System.Drawing.Size(125, 50);
            this.btn_Turnos.TabIndex = 2;
            this.btn_Turnos.Text = "Turnos";
            this.btn_Turnos.UseVisualStyleBackColor = true;
            this.btn_Turnos.Click += new System.EventHandler(this.btn_Turnos_Click);
            // 
            // btn_NuestrasAnimalDomesticos
            // 
            this.btn_NuestrasAnimalDomesticos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NuestrasAnimalDomesticos.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NuestrasAnimalDomesticos.Location = new System.Drawing.Point(54, 446);
            this.btn_NuestrasAnimalDomesticos.Name = "btn_NuestrasAnimalDomesticos";
            this.btn_NuestrasAnimalDomesticos.Size = new System.Drawing.Size(125, 50);
            this.btn_NuestrasAnimalDomesticos.TabIndex = 3;
            this.btn_NuestrasAnimalDomesticos.Text = "Registros";
            this.btn_NuestrasAnimalDomesticos.UseVisualStyleBackColor = true;
            this.btn_NuestrasAnimalDomesticos.Click += new System.EventHandler(this.btn_NuestrasAnimalDomesticos_Click);
            // 
            // btn_DarDeAlta
            // 
            this.btn_DarDeAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DarDeAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DarDeAlta.Location = new System.Drawing.Point(54, 236);
            this.btn_DarDeAlta.Name = "btn_DarDeAlta";
            this.btn_DarDeAlta.Size = new System.Drawing.Size(125, 50);
            this.btn_DarDeAlta.TabIndex = 4;
            this.btn_DarDeAlta.Text = "Dar de Alta";
            this.btn_DarDeAlta.UseVisualStyleBackColor = true;
            this.btn_DarDeAlta.Click += new System.EventHandler(this.btn_DarDeAlta_Click);
            // 
            // btn_GestionarPaciente
            // 
            this.btn_GestionarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GestionarPaciente.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GestionarPaciente.Location = new System.Drawing.Point(54, 336);
            this.btn_GestionarPaciente.Name = "btn_GestionarPaciente";
            this.btn_GestionarPaciente.Size = new System.Drawing.Size(125, 50);
            this.btn_GestionarPaciente.TabIndex = 5;
            this.btn_GestionarPaciente.Text = "Gestionar";
            this.btn_GestionarPaciente.UseVisualStyleBackColor = true;
            this.btn_GestionarPaciente.Click += new System.EventHandler(this.btn_GestionarPaciente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Veterinaria__.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(465, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnDesloguearse
            // 
            this.btnDesloguearse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDesloguearse.Location = new System.Drawing.Point(956, 619);
            this.btnDesloguearse.Name = "btnDesloguearse";
            this.btnDesloguearse.Size = new System.Drawing.Size(111, 30);
            this.btnDesloguearse.TabIndex = 12;
            this.btnDesloguearse.Text = "Desloguearse";
            this.btnDesloguearse.UseVisualStyleBackColor = true;
            this.btnDesloguearse.Click += new System.EventHandler(this.btnDesloguearse_Click);
            // 
            // btnAdminAlta
            // 
            this.btnAdminAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminAlta.Location = new System.Drawing.Point(54, 20);
            this.btnAdminAlta.Name = "btnAdminAlta";
            this.btnAdminAlta.Size = new System.Drawing.Size(125, 58);
            this.btnAdminAlta.TabIndex = 13;
            this.btnAdminAlta.Text = "Alta Empleados";
            this.btnAdminAlta.UseVisualStyleBackColor = true;
            this.btnAdminAlta.Click += new System.EventHandler(this.btnAdminAlta_Click);
            // 
            // btnAdminModificacion
            // 
            this.btnAdminModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminModificacion.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminModificacion.Location = new System.Drawing.Point(54, 152);
            this.btnAdminModificacion.Name = "btnAdminModificacion";
            this.btnAdminModificacion.Size = new System.Drawing.Size(125, 50);
            this.btnAdminModificacion.TabIndex = 14;
            this.btnAdminModificacion.Text = "Modificación";
            this.btnAdminModificacion.UseVisualStyleBackColor = true;
            // 
            // btnAdminBaja
            // 
            this.btnAdminBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminBaja.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminBaja.Location = new System.Drawing.Point(54, 286);
            this.btnAdminBaja.Name = "btnAdminBaja";
            this.btnAdminBaja.Size = new System.Drawing.Size(125, 50);
            this.btnAdminBaja.TabIndex = 15;
            this.btnAdminBaja.Text = "Baja";
            this.btnAdminBaja.UseVisualStyleBackColor = true;
            // 
            // btnAtender
            // 
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtender.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtender.Location = new System.Drawing.Point(52, 24);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(125, 50);
            this.btnAtender.TabIndex = 16;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnAsignarVeterinario
            // 
            this.btnAsignarVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsignarVeterinario.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsignarVeterinario.Location = new System.Drawing.Point(54, 134);
            this.btnAsignarVeterinario.Name = "btnAsignarVeterinario";
            this.btnAsignarVeterinario.Size = new System.Drawing.Size(125, 69);
            this.btnAsignarVeterinario.TabIndex = 17;
            this.btnAsignarVeterinario.Text = "Asignar veterinario";
            this.btnAsignarVeterinario.UseVisualStyleBackColor = true;
            this.btnAsignarVeterinario.Click += new System.EventHandler(this.btnAsignarVeterinario_Click);
            // 
            // btnBaseDeDatos
            // 
            this.btnBaseDeDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaseDeDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBaseDeDatos.Location = new System.Drawing.Point(54, 437);
            this.btnBaseDeDatos.Name = "btnBaseDeDatos";
            this.btnBaseDeDatos.Size = new System.Drawing.Size(125, 69);
            this.btnBaseDeDatos.TabIndex = 18;
            this.btnBaseDeDatos.Text = "Conectar a DB\'s";
            this.btnBaseDeDatos.UseVisualStyleBackColor = true;
            // 
            // menuStripInicio
            // 
            this.menuStripInicio.BackColor = System.Drawing.Color.PeachPuff;
            this.menuStripInicio.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temaDelInicioToolStripMenuItem});
            this.menuStripInicio.Location = new System.Drawing.Point(1023, 0);
            this.menuStripInicio.Name = "menuStripInicio";
            this.menuStripInicio.Size = new System.Drawing.Size(158, 33);
            this.menuStripInicio.TabIndex = 19;
            this.menuStripInicio.Text = "menuStripInicio";
            // 
            // temaDelInicioToolStripMenuItem
            // 
            this.temaDelInicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opacoToolStripMenuItem,
            this.claroToolStripMenuItem,
            this.guardarCambiosToolStripMenuItem});
            this.temaDelInicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.temaDelInicioToolStripMenuItem.Name = "temaDelInicioToolStripMenuItem";
            this.temaDelInicioToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.temaDelInicioToolStripMenuItem.Text = "Tema del Inicio";
            // 
            // opacoToolStripMenuItem
            // 
            this.opacoToolStripMenuItem.Name = "opacoToolStripMenuItem";
            this.opacoToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.opacoToolStripMenuItem.Text = "Opaco";
            this.opacoToolStripMenuItem.Click += new System.EventHandler(this.opacoToolStripMenuItem_Click);
            // 
            // claroToolStripMenuItem
            // 
            this.claroToolStripMenuItem.Name = "claroToolStripMenuItem";
            this.claroToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.claroToolStripMenuItem.Text = "Claro";
            this.claroToolStripMenuItem.Click += new System.EventHandler(this.claroToolStripMenuItem_Click);
            // 
            // guardarCambiosToolStripMenuItem
            // 
            this.guardarCambiosToolStripMenuItem.Name = "guardarCambiosToolStripMenuItem";
            this.guardarCambiosToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.guardarCambiosToolStripMenuItem.Text = "Guardar cambios";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBaseDeDatos);
            this.panel1.Controls.Add(this.btnAdminAlta);
            this.panel1.Controls.Add(this.btnAsignarVeterinario);
            this.panel1.Controls.Add(this.btnAtender);
            this.panel1.Controls.Add(this.btnAdminBaja);
            this.panel1.Controls.Add(this.btn_Turnos);
            this.panel1.Controls.Add(this.btnAdminModificacion);
            this.panel1.Controls.Add(this.btn_NuestrasAnimalDomesticos);
            this.panel1.Controls.Add(this.btn_DarDeAlta);
            this.panel1.Controls.Add(this.btn_GestionarPaciente);
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 564);
            this.panel1.TabIndex = 20;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDesloguearse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHorarioYUsuario);
            this.Controls.Add(this.menuStripInicio);
            this.MainMenuStrip = this.menuStripInicio;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Controls.SetChildIndex(this.menuStripInicio, 0);
            this.Controls.SetChildIndex(this.lblHorarioYUsuario, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnDesloguearse, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStripInicio.ResumeLayout(false);
            this.menuStripInicio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblHorarioYUsuario;
        private Button btn_Turnos;
        private Button btn_NuestrasAnimalDomesticos;
        private Button btn_DarDeAlta;
        private Button btn_GestionarPaciente;
        private PictureBox pictureBox1;
        private Button btnDesloguearse;
        private Button btnAdminAlta;
        private Button btnAdminModificacion;
        private Button btnAdminBaja;
        private Button btnAtender;
        private Button btnAsignarVeterinario;
        private Button btnBaseDeDatos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem temaDelInicioToolStripMenuItem;
        private ToolStripMenuItem opacoToolStripMenuItem;
        private ToolStripMenuItem claroToolStripMenuItem;
        private ToolStripMenuItem guardarCambiosToolStripMenuItem;
        private MenuStrip menuStripInicio;
        private Panel panel1;
    }
}