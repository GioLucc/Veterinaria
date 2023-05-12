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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHorarioYUsuario = new System.Windows.Forms.Label();
            this.btn_Turnos = new System.Windows.Forms.Button();
            this.btn_NuestrasMascotas = new System.Windows.Forms.Button();
            this.btn_DarDeAlta = new System.Windows.Forms.Button();
            this.btn_GestionarPaciente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDesloguearse = new System.Windows.Forms.Button();
            this.btnAdminAlta = new System.Windows.Forms.Button();
            this.btnAdminModificacion = new System.Windows.Forms.Button();
            this.btnAdminBaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHorarioYUsuario
            // 
            this.lblHorarioYUsuario.AutoSize = true;
            this.lblHorarioYUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHorarioYUsuario.Location = new System.Drawing.Point(1, 639);
            this.lblHorarioYUsuario.Name = "lblHorarioYUsuario";
            this.lblHorarioYUsuario.Size = new System.Drawing.Size(117, 20);
            this.lblHorarioYUsuario.TabIndex = 1;
            this.lblHorarioYUsuario.Text = "Nombre y Hora";
            // 
            // btn_Turnos
            // 
            this.btn_Turnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Turnos.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Turnos.Location = new System.Drawing.Point(12, 97);
            this.btn_Turnos.Name = "btn_Turnos";
            this.btn_Turnos.Size = new System.Drawing.Size(125, 50);
            this.btn_Turnos.TabIndex = 2;
            this.btn_Turnos.Text = "Turnos";
            this.btn_Turnos.UseVisualStyleBackColor = true;
            this.btn_Turnos.Click += new System.EventHandler(this.btn_Turnos_Click);
            // 
            // btn_NuestrasMascotas
            // 
            this.btn_NuestrasMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NuestrasMascotas.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NuestrasMascotas.Location = new System.Drawing.Point(12, 465);
            this.btn_NuestrasMascotas.Name = "btn_NuestrasMascotas";
            this.btn_NuestrasMascotas.Size = new System.Drawing.Size(125, 50);
            this.btn_NuestrasMascotas.TabIndex = 3;
            this.btn_NuestrasMascotas.Text = "Mascotas";
            this.btn_NuestrasMascotas.UseVisualStyleBackColor = true;
            this.btn_NuestrasMascotas.Click += new System.EventHandler(this.btn_NuestrasMascotas_Click);
            // 
            // btn_DarDeAlta
            // 
            this.btn_DarDeAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DarDeAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DarDeAlta.Location = new System.Drawing.Point(12, 221);
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
            this.btn_GestionarPaciente.Location = new System.Drawing.Point(12, 355);
            this.btn_GestionarPaciente.Name = "btn_GestionarPaciente";
            this.btn_GestionarPaciente.Size = new System.Drawing.Size(125, 50);
            this.btn_GestionarPaciente.TabIndex = 5;
            this.btn_GestionarPaciente.Text = "Gestionar";
            this.btn_GestionarPaciente.UseVisualStyleBackColor = true;
            this.btn_GestionarPaciente.Click += new System.EventHandler(this.btn_GestionarPaciente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
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
            this.btnAdminAlta.Location = new System.Drawing.Point(12, 39);
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
            this.btnAdminModificacion.Location = new System.Drawing.Point(12, 171);
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
            this.btnAdminBaja.Location = new System.Drawing.Point(12, 305);
            this.btnAdminBaja.Name = "btnAdminBaja";
            this.btnAdminBaja.Size = new System.Drawing.Size(125, 50);
            this.btnAdminBaja.TabIndex = 15;
            this.btnAdminBaja.Text = "Baja";
            this.btnAdminBaja.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnAdminBaja);
            this.Controls.Add(this.btnAdminModificacion);
            this.Controls.Add(this.btnAdminAlta);
            this.Controls.Add(this.btnDesloguearse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_GestionarPaciente);
            this.Controls.Add(this.btn_DarDeAlta);
            this.Controls.Add(this.btn_NuestrasMascotas);
            this.Controls.Add(this.btn_Turnos);
            this.Controls.Add(this.lblHorarioYUsuario);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Controls.SetChildIndex(this.lblHorarioYUsuario, 0);
            this.Controls.SetChildIndex(this.btn_Turnos, 0);
            this.Controls.SetChildIndex(this.btn_NuestrasMascotas, 0);
            this.Controls.SetChildIndex(this.btn_DarDeAlta, 0);
            this.Controls.SetChildIndex(this.btn_GestionarPaciente, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnDesloguearse, 0);
            this.Controls.SetChildIndex(this.btnAdminAlta, 0);
            this.Controls.SetChildIndex(this.btnAdminModificacion, 0);
            this.Controls.SetChildIndex(this.btnAdminBaja, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblHorarioYUsuario;
        private Button btn_Turnos;
        private Button btn_NuestrasMascotas;
        private Button btn_DarDeAlta;
        private Button btn_GestionarPaciente;
        private PictureBox pictureBox1;
        private Button btnDesloguearse;
        private Button btnAdminAlta;
        private Button btnAdminModificacion;
        private Button btnAdminBaja;
    }
}