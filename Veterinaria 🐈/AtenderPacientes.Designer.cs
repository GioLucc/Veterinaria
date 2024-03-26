namespace Veterinaria__
{
    partial class AtenderPacientes
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
            dgvAtender = new DataGridView();
            btnAtenderSeleccionado = new Button();
            dgvFechaTurnos = new DataGridView();
            btnAgregarNuevaVisita = new Button();
            btnCostoConsulta = new Button();
            gbHistorial = new GroupBox();
            txtPrecioConsulta = new TextBox();
            txtMalestar = new TextBox();
            txtInfoAd = new TextBox();
            txtObservaciones = new TextBox();
            lblObservacionAgregar = new Label();
            lblMascotaMalestar = new Label();
            lblEstadoTurno = new Label();
            lblVisitasPrevias = new Label();
            dgvPrecios = new DataGridView();
            btnDesplegarDgvs = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAtender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFechaTurnos).BeginInit();
            gbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrecios).BeginInit();
            SuspendLayout();
            // 
            // dgvAtender
            // 
            dgvAtender.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtender.Location = new Point(546, 67);
            dgvAtender.Name = "dgvAtender";
            dgvAtender.RowTemplate.Height = 25;
            dgvAtender.Size = new Size(608, 308);
            dgvAtender.TabIndex = 3;
            // 
            // btnAtenderSeleccionado
            // 
            btnAtenderSeleccionado.FlatStyle = FlatStyle.Popup;
            btnAtenderSeleccionado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtenderSeleccionado.Location = new Point(431, 534);
            btnAtenderSeleccionado.Name = "btnAtenderSeleccionado";
            btnAtenderSeleccionado.Size = new Size(144, 58);
            btnAtenderSeleccionado.TabIndex = 4;
            btnAtenderSeleccionado.Text = "Atender Seleccionado";
            btnAtenderSeleccionado.UseVisualStyleBackColor = true;
            btnAtenderSeleccionado.Click += btnAtenderSeleccionado_Click;
            // 
            // dgvFechaTurnos
            // 
            dgvFechaTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFechaTurnos.Location = new Point(806, 67);
            dgvFechaTurnos.Name = "dgvFechaTurnos";
            dgvFechaTurnos.RowTemplate.Height = 25;
            dgvFechaTurnos.Size = new Size(348, 308);
            dgvFechaTurnos.TabIndex = 5;
            dgvFechaTurnos.CellContentClick += dgvFechaTurnos_CellContentClick;
            // 
            // btnAgregarNuevaVisita
            // 
            btnAgregarNuevaVisita.FlatStyle = FlatStyle.Popup;
            btnAgregarNuevaVisita.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarNuevaVisita.Location = new Point(696, 513);
            btnAgregarNuevaVisita.Name = "btnAgregarNuevaVisita";
            btnAgregarNuevaVisita.Size = new Size(144, 58);
            btnAgregarNuevaVisita.TabIndex = 6;
            btnAgregarNuevaVisita.Text = "Agregar visita.";
            btnAgregarNuevaVisita.UseVisualStyleBackColor = true;
            btnAgregarNuevaVisita.Click += btnAgregarNuevaVisita_Click;
            // 
            // btnCostoConsulta
            // 
            btnCostoConsulta.FlatStyle = FlatStyle.Popup;
            btnCostoConsulta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCostoConsulta.Location = new Point(889, 513);
            btnCostoConsulta.Name = "btnCostoConsulta";
            btnCostoConsulta.Size = new Size(144, 58);
            btnCostoConsulta.TabIndex = 7;
            btnCostoConsulta.Text = "Generar Ticket";
            btnCostoConsulta.UseVisualStyleBackColor = true;
            btnCostoConsulta.Click += btnCostoConsulta_Click;
            // 
            // gbHistorial
            // 
            gbHistorial.BackColor = Color.White;
            gbHistorial.Controls.Add(txtPrecioConsulta);
            gbHistorial.Controls.Add(txtMalestar);
            gbHistorial.Controls.Add(txtInfoAd);
            gbHistorial.Location = new Point(12, 67);
            gbHistorial.Name = "gbHistorial";
            gbHistorial.Size = new Size(254, 447);
            gbHistorial.TabIndex = 8;
            gbHistorial.TabStop = false;
            // 
            // txtPrecioConsulta
            // 
            txtPrecioConsulta.BackColor = Color.White;
            txtPrecioConsulta.BorderStyle = BorderStyle.None;
            txtPrecioConsulta.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecioConsulta.Location = new Point(32, 389);
            txtPrecioConsulta.Multiline = true;
            txtPrecioConsulta.Name = "txtPrecioConsulta";
            txtPrecioConsulta.ReadOnly = true;
            txtPrecioConsulta.Size = new Size(200, 50);
            txtPrecioConsulta.TabIndex = 16;
            txtPrecioConsulta.Text = "Valor:";
            // 
            // txtMalestar
            // 
            txtMalestar.BackColor = Color.White;
            txtMalestar.BorderStyle = BorderStyle.None;
            txtMalestar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtMalestar.Location = new Point(34, 17);
            txtMalestar.Multiline = true;
            txtMalestar.Name = "txtMalestar";
            txtMalestar.ReadOnly = true;
            txtMalestar.Size = new Size(161, 50);
            txtMalestar.TabIndex = 15;
            txtMalestar.Text = "Malestar";
            txtMalestar.TextAlign = HorizontalAlignment.Center;
            // 
            // txtInfoAd
            // 
            txtInfoAd.BackColor = Color.White;
            txtInfoAd.BorderStyle = BorderStyle.None;
            txtInfoAd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtInfoAd.Location = new Point(22, 109);
            txtInfoAd.Multiline = true;
            txtInfoAd.Name = "txtInfoAd";
            txtInfoAd.ReadOnly = true;
            txtInfoAd.Size = new Size(200, 199);
            txtInfoAd.TabIndex = 11;
            txtInfoAd.TextAlign = HorizontalAlignment.Center;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtObservaciones.Location = new Point(563, 84);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(210, 85);
            txtObservaciones.TabIndex = 9;
            // 
            // lblObservacionAgregar
            // 
            lblObservacionAgregar.AutoSize = true;
            lblObservacionAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblObservacionAgregar.Location = new Point(581, 48);
            lblObservacionAgregar.Name = "lblObservacionAgregar";
            lblObservacionAgregar.Size = new Size(160, 21);
            lblObservacionAgregar.TabIndex = 11;
            lblObservacionAgregar.Text = "Nueva Observación";
            // 
            // lblMascotaMalestar
            // 
            lblMascotaMalestar.AutoSize = true;
            lblMascotaMalestar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMascotaMalestar.Location = new Point(346, 9);
            lblMascotaMalestar.Name = "lblMascotaMalestar";
            lblMascotaMalestar.Size = new Size(0, 30);
            lblMascotaMalestar.TabIndex = 12;
            // 
            // lblEstadoTurno
            // 
            lblEstadoTurno.AutoSize = true;
            lblEstadoTurno.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoTurno.Location = new Point(12, 9);
            lblEstadoTurno.Name = "lblEstadoTurno";
            lblEstadoTurno.Size = new Size(31, 37);
            lblEstadoTurno.TabIndex = 13;
            lblEstadoTurno.Text = "E";
            // 
            // lblVisitasPrevias
            // 
            lblVisitasPrevias.AutoSize = true;
            lblVisitasPrevias.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblVisitasPrevias.Location = new Point(889, 16);
            lblVisitasPrevias.Name = "lblVisitasPrevias";
            lblVisitasPrevias.Size = new Size(151, 30);
            lblVisitasPrevias.TabIndex = 14;
            lblVisitasPrevias.Text = "Visitas Previas";
            // 
            // dgvPrecios
            // 
            dgvPrecios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrecios.Location = new Point(719, 67);
            dgvPrecios.Name = "dgvPrecios";
            dgvPrecios.RowTemplate.Height = 25;
            dgvPrecios.Size = new Size(435, 420);
            dgvPrecios.TabIndex = 15;
            // 
            // btnDesplegarDgvs
            // 
            btnDesplegarDgvs.FlatStyle = FlatStyle.Popup;
            btnDesplegarDgvs.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDesplegarDgvs.Location = new Point(689, 513);
            btnDesplegarDgvs.Name = "btnDesplegarDgvs";
            btnDesplegarDgvs.Size = new Size(158, 58);
            btnDesplegarDgvs.TabIndex = 16;
            btnDesplegarDgvs.Text = "Mostrar Precios";
            btnDesplegarDgvs.UseVisualStyleBackColor = true;
            btnDesplegarDgvs.Click += btnDesplegarHistorial_Click;
            // 
            // AtenderPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(btnDesplegarDgvs);
            Controls.Add(lblVisitasPrevias);
            Controls.Add(lblEstadoTurno);
            Controls.Add(lblMascotaMalestar);
            Controls.Add(lblObservacionAgregar);
            Controls.Add(txtObservaciones);
            Controls.Add(gbHistorial);
            Controls.Add(btnCostoConsulta);
            Controls.Add(btnAgregarNuevaVisita);
            Controls.Add(btnAtenderSeleccionado);
            Controls.Add(dgvAtender);
            Controls.Add(dgvPrecios);
            Controls.Add(dgvFechaTurnos);
            Name = "AtenderPacientes";
            Text = "AtenderPacientes";
            Controls.SetChildIndex(dgvFechaTurnos, 0);
            Controls.SetChildIndex(dgvPrecios, 0);
            Controls.SetChildIndex(dgvAtender, 0);
            Controls.SetChildIndex(btnAtenderSeleccionado, 0);
            Controls.SetChildIndex(btnAgregarNuevaVisita, 0);
            Controls.SetChildIndex(btnCostoConsulta, 0);
            Controls.SetChildIndex(gbHistorial, 0);
            Controls.SetChildIndex(txtObservaciones, 0);
            Controls.SetChildIndex(lblObservacionAgregar, 0);
            Controls.SetChildIndex(lblMascotaMalestar, 0);
            Controls.SetChildIndex(lblEstadoTurno, 0);
            Controls.SetChildIndex(lblVisitasPrevias, 0);
            Controls.SetChildIndex(btnDesplegarDgvs, 0);
            ((System.ComponentModel.ISupportInitialize)dgvAtender).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFechaTurnos).EndInit();
            gbHistorial.ResumeLayout(false);
            gbHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrecios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAtender;
        private Button btnAtenderSeleccionado;
        private DataGridView dgvFechaTurnos;
        private Button btnCostoConsulta;
        private GroupBox gbHistorial;
        private Label lblInfoAdicional;
        private Button btnAgregarNuevaVisita;
        private TextBox txtObservaciones;
        private Label lblObservaciones;
        private Label lblObservacionAgregar;
        private Label lblMascotaMalestar;
        private Label lblEstadoTurno;
        private Label lblVisitasPrevias;
        private TextBox txtInfoAd;
        private TextBox txtMalestar;
        private TextBox txtPrecioConsulta;
        private DataGridView dgvPrecios;
        private Button btnDesplegarHistorial;
        private Button btnDesplegarDgvs;
    }
}