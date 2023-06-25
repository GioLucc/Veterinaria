namespace Veterinaria__
{
    partial class FormTurnos
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
            this.lblNuevoTurno = new System.Windows.Forms.Label();
            this.dtpElegirFechaTurno = new System.Windows.Forms.DateTimePicker();
            this.lblEnSistema = new System.Windows.Forms.Label();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.btn_MostrarMascotas = new System.Windows.Forms.Button();
            this.btnAñadirMascota = new System.Windows.Forms.Button();
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.btnOcultarDatos = new System.Windows.Forms.Button();
            this.lblSeleccionarFecha = new System.Windows.Forms.Label();
            this.btnCrearTurno = new System.Windows.Forms.Button();
            this.btnParaHoy = new System.Windows.Forms.Button();
            this.lblSeleccioneMascota = new System.Windows.Forms.Label();
            this.lblMalestar = new System.Windows.Forms.Label();
            this.txtMalestar = new System.Windows.Forms.TextBox();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnUrgencia = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.lblSeleccionaImportancia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevoTurno
            // 
            this.lblNuevoTurno.AutoSize = true;
            this.lblNuevoTurno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNuevoTurno.Location = new System.Drawing.Point(12, 9);
            this.lblNuevoTurno.Name = "lblNuevoTurno";
            this.lblNuevoTurno.Size = new System.Drawing.Size(186, 32);
            this.lblNuevoTurno.TabIndex = 4;
            this.lblNuevoTurno.Text = "Agendar Turno";
            // 
            // dtpElegirFechaTurno
            // 
            this.dtpElegirFechaTurno.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtpElegirFechaTurno.CustomFormat = "dd/MM/yyyy";
            this.dtpElegirFechaTurno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpElegirFechaTurno.Location = new System.Drawing.Point(61, 115);
            this.dtpElegirFechaTurno.MaxDate = new System.DateTime(2060, 12, 23, 0, 0, 0, 0);
            this.dtpElegirFechaTurno.MinDate = new System.DateTime(2023, 5, 14, 0, 0, 0, 0);
            this.dtpElegirFechaTurno.Name = "dtpElegirFechaTurno";
            this.dtpElegirFechaTurno.Size = new System.Drawing.Size(104, 23);
            this.dtpElegirFechaTurno.TabIndex = 5;
            this.dtpElegirFechaTurno.Value = new System.DateTime(2023, 5, 14, 0, 0, 0, 0);
            // 
            // lblEnSistema
            // 
            this.lblEnSistema.AutoSize = true;
            this.lblEnSistema.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnSistema.Location = new System.Drawing.Point(313, 48);
            this.lblEnSistema.Name = "lblEnSistema";
            this.lblEnSistema.Size = new System.Drawing.Size(91, 21);
            this.lblEnSistema.TabIndex = 6;
            this.lblEnSistema.Text = "En sistema";
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgregar.Location = new System.Drawing.Point(497, 48);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(71, 21);
            this.lblAgregar.TabIndex = 7;
            this.lblAgregar.Text = "Agregar";
            // 
            // btn_MostrarMascotas
            // 
            this.btn_MostrarMascotas.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MostrarMascotas.Location = new System.Drawing.Point(297, 88);
            this.btn_MostrarMascotas.Name = "btn_MostrarMascotas";
            this.btn_MostrarMascotas.Size = new System.Drawing.Size(125, 50);
            this.btn_MostrarMascotas.TabIndex = 8;
            this.btn_MostrarMascotas.Text = "Mostrar Mascotas";
            this.btn_MostrarMascotas.UseVisualStyleBackColor = true;
            this.btn_MostrarMascotas.Click += new System.EventHandler(this.btn_MostrarMascotas_Click);
            // 
            // btnAñadirMascota
            // 
            this.btnAñadirMascota.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAñadirMascota.Location = new System.Drawing.Point(472, 88);
            this.btnAñadirMascota.Name = "btnAñadirMascota";
            this.btnAñadirMascota.Size = new System.Drawing.Size(122, 50);
            this.btnAñadirMascota.TabIndex = 9;
            this.btnAñadirMascota.Text = "Añadir Mascota";
            this.btnAñadirMascota.UseVisualStyleBackColor = true;
            this.btnAñadirMascota.Click += new System.EventHandler(this.btnAñadirMascota_Click);
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(268, 46);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.RowTemplate.Height = 25;
            this.dgvBaseDatos.Size = new System.Drawing.Size(326, 588);
            this.dgvBaseDatos.TabIndex = 10;
            this.dgvBaseDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaseDatos_CellContentClick);
            // 
            // btnOcultarDatos
            // 
            this.btnOcultarDatos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOcultarDatos.Location = new System.Drawing.Point(614, 621);
            this.btnOcultarDatos.Name = "btnOcultarDatos";
            this.btnOcultarDatos.Size = new System.Drawing.Size(139, 28);
            this.btnOcultarDatos.TabIndex = 11;
            this.btnOcultarDatos.Text = "Ocultar Mascotas";
            this.btnOcultarDatos.UseVisualStyleBackColor = true;
            this.btnOcultarDatos.Click += new System.EventHandler(this.btnOcultarDatos_Click);
            // 
            // lblSeleccionarFecha
            // 
            this.lblSeleccionarFecha.AutoSize = true;
            this.lblSeleccionarFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionarFecha.Location = new System.Drawing.Point(39, 68);
            this.lblSeleccionarFecha.Name = "lblSeleccionarFecha";
            this.lblSeleccionarFecha.Size = new System.Drawing.Size(146, 21);
            this.lblSeleccionarFecha.TabIndex = 12;
            this.lblSeleccionarFecha.Text = "Seleccionar Fecha";
            // 
            // btnCrearTurno
            // 
            this.btnCrearTurno.Location = new System.Drawing.Point(797, 397);
            this.btnCrearTurno.Name = "btnCrearTurno";
            this.btnCrearTurno.Size = new System.Drawing.Size(122, 59);
            this.btnCrearTurno.TabIndex = 13;
            this.btnCrearTurno.Text = "Crear Turno";
            this.btnCrearTurno.UseVisualStyleBackColor = true;
            this.btnCrearTurno.Click += new System.EventHandler(this.btnCrearTurno_Click);
            // 
            // btnParaHoy
            // 
            this.btnParaHoy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParaHoy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnParaHoy.Location = new System.Drawing.Point(47, 182);
            this.btnParaHoy.Name = "btnParaHoy";
            this.btnParaHoy.Size = new System.Drawing.Size(137, 49);
            this.btnParaHoy.TabIndex = 14;
            this.btnParaHoy.Text = "¡Para hoy!";
            this.btnParaHoy.UseVisualStyleBackColor = true;
            this.btnParaHoy.Click += new System.EventHandler(this.btnParaHoy_Click);
            // 
            // lblSeleccioneMascota
            // 
            this.lblSeleccioneMascota.AutoSize = true;
            this.lblSeleccioneMascota.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccioneMascota.Location = new System.Drawing.Point(298, 7);
            this.lblSeleccioneMascota.Name = "lblSeleccioneMascota";
            this.lblSeleccioneMascota.Size = new System.Drawing.Size(247, 32);
            this.lblSeleccioneMascota.TabIndex = 15;
            this.lblSeleccioneMascota.Text = "Seleccionar Mascota";
            // 
            // lblMalestar
            // 
            this.lblMalestar.AutoSize = true;
            this.lblMalestar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMalestar.Location = new System.Drawing.Point(642, 12);
            this.lblMalestar.Name = "lblMalestar";
            this.lblMalestar.Size = new System.Drawing.Size(189, 32);
            this.lblMalestar.TabIndex = 16;
            this.lblMalestar.Text = "Malestar actual";
            // 
            // txtMalestar
            // 
            this.txtMalestar.Location = new System.Drawing.Point(650, 70);
            this.txtMalestar.Multiline = true;
            this.txtMalestar.Name = "txtMalestar";
            this.txtMalestar.Size = new System.Drawing.Size(174, 48);
            this.txtMalestar.TabIndex = 17;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarDatos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarDatos.Location = new System.Drawing.Point(670, 148);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(137, 49);
            this.btnCargarDatos.TabIndex = 18;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnUrgencia
            // 
            this.btnUrgencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUrgencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrgencia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUrgencia.ForeColor = System.Drawing.Color.White;
            this.btnUrgencia.Location = new System.Drawing.Point(969, 70);
            this.btnUrgencia.Name = "btnUrgencia";
            this.btnUrgencia.Size = new System.Drawing.Size(143, 49);
            this.btnUrgencia.TabIndex = 19;
            this.btnUrgencia.Text = "URGENCIA ⚠";
            this.btnUrgencia.UseVisualStyleBackColor = false;
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.Yellow;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMedia.Location = new System.Drawing.Point(969, 161);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(143, 49);
            this.btnMedia.TabIndex = 20;
            this.btnMedia.Text = "MEDIA";
            this.btnMedia.UseVisualStyleBackColor = false;
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.LawnGreen;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNormal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNormal.Location = new System.Drawing.Point(969, 247);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(143, 49);
            this.btnNormal.TabIndex = 21;
            this.btnNormal.Text = "NORMAL";
            this.btnNormal.UseVisualStyleBackColor = false;
            // 
            // lblSeleccionaImportancia
            // 
            this.lblSeleccionaImportancia.AutoSize = true;
            this.lblSeleccionaImportancia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionaImportancia.Location = new System.Drawing.Point(881, 12);
            this.lblSeleccionaImportancia.Name = "lblSeleccionaImportancia";
            this.lblSeleccionaImportancia.Size = new System.Drawing.Size(291, 32);
            this.lblSeleccionaImportancia.TabIndex = 22;
            this.lblSeleccionaImportancia.Text = "Seleccionar Importancia";
            // 
            // FormTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lblSeleccionaImportancia);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnUrgencia);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.txtMalestar);
            this.Controls.Add(this.lblMalestar);
            this.Controls.Add(this.lblSeleccioneMascota);
            this.Controls.Add(this.btnParaHoy);
            this.Controls.Add(this.btnCrearTurno);
            this.Controls.Add(this.lblSeleccionarFecha);
            this.Controls.Add(this.btnOcultarDatos);
            this.Controls.Add(this.dgvBaseDatos);
            this.Controls.Add(this.btnAñadirMascota);
            this.Controls.Add(this.btn_MostrarMascotas);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.lblEnSistema);
            this.Controls.Add(this.dtpElegirFechaTurno);
            this.Controls.Add(this.lblNuevoTurno);
            this.Name = "FormTurnos";
            this.Text = " ";
            this.Controls.SetChildIndex(this.lblNuevoTurno, 0);
            this.Controls.SetChildIndex(this.dtpElegirFechaTurno, 0);
            this.Controls.SetChildIndex(this.lblEnSistema, 0);
            this.Controls.SetChildIndex(this.lblAgregar, 0);
            this.Controls.SetChildIndex(this.btn_MostrarMascotas, 0);
            this.Controls.SetChildIndex(this.btnAñadirMascota, 0);
            this.Controls.SetChildIndex(this.dgvBaseDatos, 0);
            this.Controls.SetChildIndex(this.btnOcultarDatos, 0);
            this.Controls.SetChildIndex(this.lblSeleccionarFecha, 0);
            this.Controls.SetChildIndex(this.btnCrearTurno, 0);
            this.Controls.SetChildIndex(this.btnParaHoy, 0);
            this.Controls.SetChildIndex(this.lblSeleccioneMascota, 0);
            this.Controls.SetChildIndex(this.lblMalestar, 0);
            this.Controls.SetChildIndex(this.txtMalestar, 0);
            this.Controls.SetChildIndex(this.btnCargarDatos, 0);
            this.Controls.SetChildIndex(this.btnUrgencia, 0);
            this.Controls.SetChildIndex(this.btnMedia, 0);
            this.Controls.SetChildIndex(this.btnNormal, 0);
            this.Controls.SetChildIndex(this.lblSeleccionaImportancia, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblNuevoTurno;
        private DateTimePicker dtpElegirFechaTurno;
        private Label lblEnSistema;
        private Label lblAgregar;
        private Button btn_MostrarMascotas;
        private Button btnAñadirMascota;
        private DataGridView dgvBaseDatos;
        private Button btnOcultarDatos;
        private Label lblSeleccionarFecha;
        private Button btnCrearTurno;
        private Button btnParaHoy;
        private Label lblSeleccioneMascota;
        private Label lblMalestar;
        private TextBox txtMalestar;
        private Button btnCargarDatos;
        private Button btnUrgencia;
        private Button btnMedia;
        private Button btnNormal;
        private Label lblSeleccionaImportancia;
    }
}