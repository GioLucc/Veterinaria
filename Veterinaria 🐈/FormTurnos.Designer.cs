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
            lblNuevoTurno = new Label();
            dtpElegirFechaTurno = new DateTimePicker();
            lblEnSistema = new Label();
            lblAgregar = new Label();
            btn_MostrarMascotas = new Button();
            btnAñadirMascota = new Button();
            dgvBaseDatos = new DataGridView();
            btnOcultarDatos = new Button();
            lblSeleccionarFecha = new Label();
            btnCrearTurno = new Button();
            btnParaHoy = new Button();
            lblSeleccioneMascota = new Label();
            lblMalestar = new Label();
            txtMalestar = new TextBox();
            btnCargarDatos = new Button();
            btnUrgencia = new Button();
            btnMedia = new Button();
            btnNormal = new Button();
            lblSeleccionaImportancia = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBaseDatos).BeginInit();
            SuspendLayout();
            // 
            // lblNuevoTurno
            // 
            lblNuevoTurno.AutoSize = true;
            lblNuevoTurno.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNuevoTurno.Location = new Point(12, 9);
            lblNuevoTurno.Name = "lblNuevoTurno";
            lblNuevoTurno.Size = new Size(186, 32);
            lblNuevoTurno.TabIndex = 4;
            lblNuevoTurno.Text = "Agendar Turno";
            // 
            // dtpElegirFechaTurno
            // 
            dtpElegirFechaTurno.CalendarMonthBackground = Color.FromArgb(255, 224, 192);
            dtpElegirFechaTurno.CustomFormat = "dd/MM/yyyy";
            dtpElegirFechaTurno.Format = DateTimePickerFormat.Custom;
            dtpElegirFechaTurno.Location = new Point(61, 115);
            dtpElegirFechaTurno.MaxDate = new DateTime(2060, 12, 23, 0, 0, 0, 0);
            dtpElegirFechaTurno.MinDate = new DateTime(2023, 5, 14, 0, 0, 0, 0);
            dtpElegirFechaTurno.Name = "dtpElegirFechaTurno";
            dtpElegirFechaTurno.Size = new Size(104, 23);
            dtpElegirFechaTurno.TabIndex = 5;
            dtpElegirFechaTurno.Value = new DateTime(2023, 5, 14, 0, 0, 0, 0);
            // 
            // lblEnSistema
            // 
            lblEnSistema.AutoSize = true;
            lblEnSistema.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnSistema.Location = new Point(313, 48);
            lblEnSistema.Name = "lblEnSistema";
            lblEnSistema.Size = new Size(91, 21);
            lblEnSistema.TabIndex = 6;
            lblEnSistema.Text = "En sistema";
            // 
            // lblAgregar
            // 
            lblAgregar.AutoSize = true;
            lblAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregar.Location = new Point(497, 48);
            lblAgregar.Name = "lblAgregar";
            lblAgregar.Size = new Size(71, 21);
            lblAgregar.TabIndex = 7;
            lblAgregar.Text = "Agregar";
            // 
            // btn_MostrarMascotas
            // 
            btn_MostrarMascotas.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_MostrarMascotas.Location = new Point(297, 88);
            btn_MostrarMascotas.Name = "btn_MostrarMascotas";
            btn_MostrarMascotas.Size = new Size(125, 50);
            btn_MostrarMascotas.TabIndex = 8;
            btn_MostrarMascotas.Text = "Mostrar Mascotas";
            btn_MostrarMascotas.UseVisualStyleBackColor = true;
            btn_MostrarMascotas.Click += btn_MostrarMascotas_Click;
            // 
            // btnAñadirMascota
            // 
            btnAñadirMascota.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAñadirMascota.Location = new Point(472, 88);
            btnAñadirMascota.Name = "btnAñadirMascota";
            btnAñadirMascota.Size = new Size(122, 50);
            btnAñadirMascota.TabIndex = 9;
            btnAñadirMascota.Text = "Añadir Mascota";
            btnAñadirMascota.UseVisualStyleBackColor = true;
            btnAñadirMascota.Click += btnAñadirMascota_Click;
            // 
            // dgvBaseDatos
            // 
            dgvBaseDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaseDatos.Location = new Point(215, 46);
            dgvBaseDatos.Name = "dgvBaseDatos";
            dgvBaseDatos.RowTemplate.Height = 25;
            dgvBaseDatos.Size = new Size(393, 588);
            dgvBaseDatos.TabIndex = 10;
            dgvBaseDatos.CellContentClick += dgvBaseDatos_CellContentClick;
            // 
            // btnOcultarDatos
            // 
            btnOcultarDatos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOcultarDatos.Location = new Point(614, 621);
            btnOcultarDatos.Name = "btnOcultarDatos";
            btnOcultarDatos.Size = new Size(139, 28);
            btnOcultarDatos.TabIndex = 11;
            btnOcultarDatos.Text = "Ocultar Mascotas";
            btnOcultarDatos.UseVisualStyleBackColor = true;
            btnOcultarDatos.Click += btnOcultarDatos_Click;
            // 
            // lblSeleccionarFecha
            // 
            lblSeleccionarFecha.AutoSize = true;
            lblSeleccionarFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeleccionarFecha.Location = new Point(39, 68);
            lblSeleccionarFecha.Name = "lblSeleccionarFecha";
            lblSeleccionarFecha.Size = new Size(146, 21);
            lblSeleccionarFecha.TabIndex = 12;
            lblSeleccionarFecha.Text = "Seleccionar Fecha";
            // 
            // btnCrearTurno
            // 
            btnCrearTurno.Location = new Point(797, 397);
            btnCrearTurno.Name = "btnCrearTurno";
            btnCrearTurno.Size = new Size(122, 59);
            btnCrearTurno.TabIndex = 13;
            btnCrearTurno.Text = "Crear Turno";
            btnCrearTurno.UseVisualStyleBackColor = true;
            btnCrearTurno.Click += btnCrearTurno_Click;
            // 
            // btnParaHoy
            // 
            btnParaHoy.FlatStyle = FlatStyle.Popup;
            btnParaHoy.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnParaHoy.Location = new Point(47, 182);
            btnParaHoy.Name = "btnParaHoy";
            btnParaHoy.Size = new Size(137, 49);
            btnParaHoy.TabIndex = 14;
            btnParaHoy.Text = "¡Para hoy!";
            btnParaHoy.UseVisualStyleBackColor = true;
            btnParaHoy.Click += btnParaHoy_Click;
            // 
            // lblSeleccioneMascota
            // 
            lblSeleccioneMascota.AutoSize = true;
            lblSeleccioneMascota.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeleccioneMascota.Location = new Point(298, 7);
            lblSeleccioneMascota.Name = "lblSeleccioneMascota";
            lblSeleccioneMascota.Size = new Size(247, 32);
            lblSeleccioneMascota.TabIndex = 15;
            lblSeleccioneMascota.Text = "Seleccionar Mascota";
            // 
            // lblMalestar
            // 
            lblMalestar.AutoSize = true;
            lblMalestar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMalestar.Location = new Point(642, 12);
            lblMalestar.Name = "lblMalestar";
            lblMalestar.Size = new Size(189, 32);
            lblMalestar.TabIndex = 16;
            lblMalestar.Text = "Malestar actual";
            // 
            // txtMalestar
            // 
            txtMalestar.Location = new Point(650, 70);
            txtMalestar.Multiline = true;
            txtMalestar.Name = "txtMalestar";
            txtMalestar.Size = new Size(174, 48);
            txtMalestar.TabIndex = 17;
            txtMalestar.MouseEnter += txtMalestar_MouseEnter;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.FlatStyle = FlatStyle.Popup;
            btnCargarDatos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarDatos.Location = new Point(670, 148);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(137, 49);
            btnCargarDatos.TabIndex = 18;
            btnCargarDatos.Text = "Cargar Datos";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // btnUrgencia
            // 
            btnUrgencia.BackColor = Color.FromArgb(192, 64, 0);
            btnUrgencia.FlatStyle = FlatStyle.Popup;
            btnUrgencia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUrgencia.ForeColor = Color.White;
            btnUrgencia.Location = new Point(969, 70);
            btnUrgencia.Name = "btnUrgencia";
            btnUrgencia.Size = new Size(143, 49);
            btnUrgencia.TabIndex = 19;
            btnUrgencia.Text = "URGENCIA ⚠";
            btnUrgencia.UseVisualStyleBackColor = false;
            // 
            // btnMedia
            // 
            btnMedia.BackColor = Color.Yellow;
            btnMedia.FlatStyle = FlatStyle.Popup;
            btnMedia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMedia.Location = new Point(969, 161);
            btnMedia.Name = "btnMedia";
            btnMedia.Size = new Size(143, 49);
            btnMedia.TabIndex = 20;
            btnMedia.Text = "MEDIA";
            btnMedia.UseVisualStyleBackColor = false;
            // 
            // btnNormal
            // 
            btnNormal.BackColor = Color.LawnGreen;
            btnNormal.FlatStyle = FlatStyle.Popup;
            btnNormal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNormal.Location = new Point(969, 247);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(143, 49);
            btnNormal.TabIndex = 21;
            btnNormal.Text = "NORMAL";
            btnNormal.UseVisualStyleBackColor = false;
            // 
            // lblSeleccionaImportancia
            // 
            lblSeleccionaImportancia.AutoSize = true;
            lblSeleccionaImportancia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeleccionaImportancia.Location = new Point(881, 12);
            lblSeleccionaImportancia.Name = "lblSeleccionaImportancia";
            lblSeleccionaImportancia.Size = new Size(291, 32);
            lblSeleccionaImportancia.TabIndex = 22;
            lblSeleccionaImportancia.Text = "Seleccionar Importancia";
            // 
            // FormTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(lblSeleccionaImportancia);
            Controls.Add(btnNormal);
            Controls.Add(btnMedia);
            Controls.Add(btnUrgencia);
            Controls.Add(btnCargarDatos);
            Controls.Add(txtMalestar);
            Controls.Add(lblMalestar);
            Controls.Add(lblSeleccioneMascota);
            Controls.Add(btnParaHoy);
            Controls.Add(btnCrearTurno);
            Controls.Add(lblSeleccionarFecha);
            Controls.Add(btnOcultarDatos);
            Controls.Add(dgvBaseDatos);
            Controls.Add(btnAñadirMascota);
            Controls.Add(btn_MostrarMascotas);
            Controls.Add(lblAgregar);
            Controls.Add(lblEnSistema);
            Controls.Add(dtpElegirFechaTurno);
            Controls.Add(lblNuevoTurno);
            Name = "FormTurnos";
            Text = " ";
            Load += FormTurnos_Load;
            Controls.SetChildIndex(lblNuevoTurno, 0);
            Controls.SetChildIndex(dtpElegirFechaTurno, 0);
            Controls.SetChildIndex(lblEnSistema, 0);
            Controls.SetChildIndex(lblAgregar, 0);
            Controls.SetChildIndex(btn_MostrarMascotas, 0);
            Controls.SetChildIndex(btnAñadirMascota, 0);
            Controls.SetChildIndex(dgvBaseDatos, 0);
            Controls.SetChildIndex(btnOcultarDatos, 0);
            Controls.SetChildIndex(lblSeleccionarFecha, 0);
            Controls.SetChildIndex(btnCrearTurno, 0);
            Controls.SetChildIndex(btnParaHoy, 0);
            Controls.SetChildIndex(lblSeleccioneMascota, 0);
            Controls.SetChildIndex(lblMalestar, 0);
            Controls.SetChildIndex(txtMalestar, 0);
            Controls.SetChildIndex(btnCargarDatos, 0);
            Controls.SetChildIndex(btnUrgencia, 0);
            Controls.SetChildIndex(btnMedia, 0);
            Controls.SetChildIndex(btnNormal, 0);
            Controls.SetChildIndex(lblSeleccionaImportancia, 0);
            ((System.ComponentModel.ISupportInitialize)dgvBaseDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
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