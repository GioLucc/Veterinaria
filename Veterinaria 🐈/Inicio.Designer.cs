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
            this.panelInicio = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStripInicio.SuspendLayout();
            this.panelInicio.SuspendLayout();
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
            this.lblHorarioYUsuario.Location = new System.Drawing.Point(1, 635);
            this.lblHorarioYUsuario.Name = "lblHorarioYUsuario";
            this.lblHorarioYUsuario.Size = new System.Drawing.Size(134, 23);
            this.lblHorarioYUsuario.TabIndex = 1;
            this.lblHorarioYUsuario.Text = "Nombre y Hora";
            // 
            // btn_Turnos
            // 
            this.btn_Turnos.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Turnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Turnos.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Turnos.ForeColor = System.Drawing.Color.Black;
            this.btn_Turnos.Location = new System.Drawing.Point(86, 87);
            this.btn_Turnos.Name = "btn_Turnos";
            this.btn_Turnos.Size = new System.Drawing.Size(125, 50);
            this.btn_Turnos.TabIndex = 2;
            this.btn_Turnos.Text = "Nuevo Turno";
            this.btn_Turnos.UseVisualStyleBackColor = false;
            this.btn_Turnos.Click += new System.EventHandler(this.btn_Turnos_Click);
            // 
            // btn_NuestrasAnimalDomesticos
            // 
            this.btn_NuestrasAnimalDomesticos.BackColor = System.Drawing.SystemColors.Control;
            this.btn_NuestrasAnimalDomesticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuestrasAnimalDomesticos.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NuestrasAnimalDomesticos.ForeColor = System.Drawing.Color.Black;
            this.btn_NuestrasAnimalDomesticos.Location = new System.Drawing.Point(86, 494);
            this.btn_NuestrasAnimalDomesticos.Name = "btn_NuestrasAnimalDomesticos";
            this.btn_NuestrasAnimalDomesticos.Size = new System.Drawing.Size(125, 50);
            this.btn_NuestrasAnimalDomesticos.TabIndex = 3;
            this.btn_NuestrasAnimalDomesticos.Text = "Registros";
            this.btn_NuestrasAnimalDomesticos.UseVisualStyleBackColor = false;
            this.btn_NuestrasAnimalDomesticos.Click += new System.EventHandler(this.btn_NuestrasAnimalDomesticos_Click);
            // 
            // btn_DarDeAlta
            // 
            this.btn_DarDeAlta.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DarDeAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DarDeAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DarDeAlta.ForeColor = System.Drawing.Color.Black;
            this.btn_DarDeAlta.Location = new System.Drawing.Point(86, 284);
            this.btn_DarDeAlta.Name = "btn_DarDeAlta";
            this.btn_DarDeAlta.Size = new System.Drawing.Size(125, 60);
            this.btn_DarDeAlta.TabIndex = 4;
            this.btn_DarDeAlta.Text = "Nuevo usuario";
            this.btn_DarDeAlta.UseVisualStyleBackColor = false;
            this.btn_DarDeAlta.Click += new System.EventHandler(this.btn_DarDeAlta_Click);
            // 
            // btn_GestionarPaciente
            // 
            this.btn_GestionarPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.btn_GestionarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GestionarPaciente.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GestionarPaciente.ForeColor = System.Drawing.Color.Black;
            this.btn_GestionarPaciente.Location = new System.Drawing.Point(86, 384);
            this.btn_GestionarPaciente.Name = "btn_GestionarPaciente";
            this.btn_GestionarPaciente.Size = new System.Drawing.Size(125, 50);
            this.btn_GestionarPaciente.TabIndex = 5;
            this.btn_GestionarPaciente.Text = "Gestionar";
            this.btn_GestionarPaciente.UseVisualStyleBackColor = false;
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
            this.btnAdminAlta.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdminAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminAlta.ForeColor = System.Drawing.Color.Black;
            this.btnAdminAlta.Location = new System.Drawing.Point(86, 68);
            this.btnAdminAlta.Name = "btnAdminAlta";
            this.btnAdminAlta.Size = new System.Drawing.Size(125, 58);
            this.btnAdminAlta.TabIndex = 13;
            this.btnAdminAlta.Text = "Alta Empleados";
            this.btnAdminAlta.UseVisualStyleBackColor = false;
            this.btnAdminAlta.Click += new System.EventHandler(this.btnAdminAlta_Click);
            // 
            // btnAdminModificacion
            // 
            this.btnAdminModificacion.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdminModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminModificacion.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminModificacion.ForeColor = System.Drawing.Color.Black;
            this.btnAdminModificacion.Location = new System.Drawing.Point(86, 200);
            this.btnAdminModificacion.Name = "btnAdminModificacion";
            this.btnAdminModificacion.Size = new System.Drawing.Size(125, 50);
            this.btnAdminModificacion.TabIndex = 14;
            this.btnAdminModificacion.Text = "Modificación";
            this.btnAdminModificacion.UseVisualStyleBackColor = false;
            // 
            // btnAdminBaja
            // 
            this.btnAdminBaja.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdminBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminBaja.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminBaja.ForeColor = System.Drawing.Color.Black;
            this.btnAdminBaja.Location = new System.Drawing.Point(86, 334);
            this.btnAdminBaja.Name = "btnAdminBaja";
            this.btnAdminBaja.Size = new System.Drawing.Size(125, 56);
            this.btnAdminBaja.TabIndex = 15;
            this.btnAdminBaja.Text = "Eliminar Usuario";
            this.btnAdminBaja.UseVisualStyleBackColor = false;
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtender.ForeColor = System.Drawing.Color.Black;
            this.btnAtender.Location = new System.Drawing.Point(84, 72);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(125, 50);
            this.btnAtender.TabIndex = 16;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnAsignarVeterinario
            // 
            this.btnAsignarVeterinario.BackColor = System.Drawing.SystemColors.Control;
            this.btnAsignarVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarVeterinario.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsignarVeterinario.ForeColor = System.Drawing.Color.Black;
            this.btnAsignarVeterinario.Location = new System.Drawing.Point(86, 182);
            this.btnAsignarVeterinario.Name = "btnAsignarVeterinario";
            this.btnAsignarVeterinario.Size = new System.Drawing.Size(125, 69);
            this.btnAsignarVeterinario.TabIndex = 17;
            this.btnAsignarVeterinario.Text = "Asignar veterinario";
            this.btnAsignarVeterinario.UseVisualStyleBackColor = false;
            this.btnAsignarVeterinario.Click += new System.EventHandler(this.btnAsignarVeterinario_Click);
            // 
            // btnBaseDeDatos
            // 
            this.btnBaseDeDatos.BackColor = System.Drawing.SystemColors.Control;
            this.btnBaseDeDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaseDeDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBaseDeDatos.ForeColor = System.Drawing.Color.Black;
            this.btnBaseDeDatos.Location = new System.Drawing.Point(86, 485);
            this.btnBaseDeDatos.Name = "btnBaseDeDatos";
            this.btnBaseDeDatos.Size = new System.Drawing.Size(125, 69);
            this.btnBaseDeDatos.TabIndex = 18;
            this.btnBaseDeDatos.Text = "Conectar a DB\'s";
            this.btnBaseDeDatos.UseVisualStyleBackColor = false;
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
            this.guardarCambiosToolStripMenuItem.Click += new System.EventHandler(this.guardarCambiosToolStripMenuItem_Click);
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panelInicio.Controls.Add(this.btnBaseDeDatos);
            this.panelInicio.Controls.Add(this.btnAdminAlta);
            this.panelInicio.Controls.Add(this.btnAsignarVeterinario);
            this.panelInicio.Controls.Add(this.lblHorarioYUsuario);
            this.panelInicio.Controls.Add(this.btnAtender);
            this.panelInicio.Controls.Add(this.btnAdminBaja);
            this.panelInicio.Controls.Add(this.btn_Turnos);
            this.panelInicio.Controls.Add(this.btnAdminModificacion);
            this.panelInicio.Controls.Add(this.btn_NuestrasAnimalDomesticos);
            this.panelInicio.Controls.Add(this.btn_DarDeAlta);
            this.panelInicio.Controls.Add(this.btn_GestionarPaciente);
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(365, 664);
            this.panelInicio.TabIndex = 20;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.btnDesloguearse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStripInicio);
            this.MainMenuStrip = this.menuStripInicio;
            this.Name = "Inicio";
            this.Opacity = 0.97D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Controls.SetChildIndex(this.menuStripInicio, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnDesloguearse, 0);
            this.Controls.SetChildIndex(this.panelInicio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStripInicio.ResumeLayout(false);
            this.menuStripInicio.PerformLayout();
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
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
        private Panel panelInicio;
    }
}