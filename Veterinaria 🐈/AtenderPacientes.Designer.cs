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
            this.dgvAtender = new System.Windows.Forms.DataGridView();
            this.btnAtenderSeleccionado = new System.Windows.Forms.Button();
            this.dgvFechaTurnos = new System.Windows.Forms.DataGridView();
            this.btnAgregarNuevaVisita = new System.Windows.Forms.Button();
            this.btnCostoConsulta = new System.Windows.Forms.Button();
            this.gbHistorial = new System.Windows.Forms.GroupBox();
            this.txtPrecioConsulta = new System.Windows.Forms.TextBox();
            this.txtMalestar = new System.Windows.Forms.TextBox();
            this.txtInfoAd = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservacionAgregar = new System.Windows.Forms.Label();
            this.lblMascotaMalestar = new System.Windows.Forms.Label();
            this.lblEstadoTurno = new System.Windows.Forms.Label();
            this.lblVisitasPrevias = new System.Windows.Forms.Label();
            this.dgvPrecios = new System.Windows.Forms.DataGridView();
            this.btnDesplegarDgvs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechaTurnos)).BeginInit();
            this.gbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAtender
            // 
            this.dgvAtender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtender.Location = new System.Drawing.Point(563, 67);
            this.dgvAtender.Name = "dgvAtender";
            this.dgvAtender.RowTemplate.Height = 25;
            this.dgvAtender.Size = new System.Drawing.Size(591, 308);
            this.dgvAtender.TabIndex = 3;
            // 
            // btnAtenderSeleccionado
            // 
            this.btnAtenderSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtenderSeleccionado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtenderSeleccionado.Location = new System.Drawing.Point(431, 534);
            this.btnAtenderSeleccionado.Name = "btnAtenderSeleccionado";
            this.btnAtenderSeleccionado.Size = new System.Drawing.Size(144, 58);
            this.btnAtenderSeleccionado.TabIndex = 4;
            this.btnAtenderSeleccionado.Text = "Atender Seleccionado";
            this.btnAtenderSeleccionado.UseVisualStyleBackColor = true;
            this.btnAtenderSeleccionado.Click += new System.EventHandler(this.btnAtenderSeleccionado_Click);
            // 
            // dgvFechaTurnos
            // 
            this.dgvFechaTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFechaTurnos.Location = new System.Drawing.Point(806, 67);
            this.dgvFechaTurnos.Name = "dgvFechaTurnos";
            this.dgvFechaTurnos.RowTemplate.Height = 25;
            this.dgvFechaTurnos.Size = new System.Drawing.Size(348, 308);
            this.dgvFechaTurnos.TabIndex = 5;
            this.dgvFechaTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFechaTurnos_CellContentClick);
            // 
            // btnAgregarNuevaVisita
            // 
            this.btnAgregarNuevaVisita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarNuevaVisita.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarNuevaVisita.Location = new System.Drawing.Point(696, 513);
            this.btnAgregarNuevaVisita.Name = "btnAgregarNuevaVisita";
            this.btnAgregarNuevaVisita.Size = new System.Drawing.Size(144, 58);
            this.btnAgregarNuevaVisita.TabIndex = 6;
            this.btnAgregarNuevaVisita.Text = "Agregar visita.";
            this.btnAgregarNuevaVisita.UseVisualStyleBackColor = true;
            this.btnAgregarNuevaVisita.Click += new System.EventHandler(this.btnAgregarNuevaVisita_Click);
            // 
            // btnCostoConsulta
            // 
            this.btnCostoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCostoConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCostoConsulta.Location = new System.Drawing.Point(889, 513);
            this.btnCostoConsulta.Name = "btnCostoConsulta";
            this.btnCostoConsulta.Size = new System.Drawing.Size(144, 58);
            this.btnCostoConsulta.TabIndex = 7;
            this.btnCostoConsulta.Text = "Generar Ticket";
            this.btnCostoConsulta.UseVisualStyleBackColor = true;
            this.btnCostoConsulta.Click += new System.EventHandler(this.btnCostoConsulta_Click);
            // 
            // gbHistorial
            // 
            this.gbHistorial.BackColor = System.Drawing.Color.White;
            this.gbHistorial.Controls.Add(this.txtPrecioConsulta);
            this.gbHistorial.Controls.Add(this.txtMalestar);
            this.gbHistorial.Controls.Add(this.txtInfoAd);
            this.gbHistorial.Location = new System.Drawing.Point(12, 67);
            this.gbHistorial.Name = "gbHistorial";
            this.gbHistorial.Size = new System.Drawing.Size(254, 447);
            this.gbHistorial.TabIndex = 8;
            this.gbHistorial.TabStop = false;
            // 
            // txtPrecioConsulta
            // 
            this.txtPrecioConsulta.BackColor = System.Drawing.Color.White;
            this.txtPrecioConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioConsulta.Location = new System.Drawing.Point(32, 389);
            this.txtPrecioConsulta.Multiline = true;
            this.txtPrecioConsulta.Name = "txtPrecioConsulta";
            this.txtPrecioConsulta.ReadOnly = true;
            this.txtPrecioConsulta.Size = new System.Drawing.Size(200, 50);
            this.txtPrecioConsulta.TabIndex = 16;
            this.txtPrecioConsulta.Text = "Valor:";
            // 
            // txtMalestar
            // 
            this.txtMalestar.BackColor = System.Drawing.Color.White;
            this.txtMalestar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMalestar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMalestar.Location = new System.Drawing.Point(34, 17);
            this.txtMalestar.Multiline = true;
            this.txtMalestar.Name = "txtMalestar";
            this.txtMalestar.ReadOnly = true;
            this.txtMalestar.Size = new System.Drawing.Size(161, 50);
            this.txtMalestar.TabIndex = 15;
            this.txtMalestar.Text = "Malestar";
            this.txtMalestar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInfoAd
            // 
            this.txtInfoAd.BackColor = System.Drawing.Color.White;
            this.txtInfoAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfoAd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInfoAd.Location = new System.Drawing.Point(22, 109);
            this.txtInfoAd.Multiline = true;
            this.txtInfoAd.Name = "txtInfoAd";
            this.txtInfoAd.ReadOnly = true;
            this.txtInfoAd.Size = new System.Drawing.Size(200, 199);
            this.txtInfoAd.TabIndex = 11;
            this.txtInfoAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtObservaciones.Location = new System.Drawing.Point(563, 84);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(210, 85);
            this.txtObservaciones.TabIndex = 9;
            // 
            // lblObservacionAgregar
            // 
            this.lblObservacionAgregar.AutoSize = true;
            this.lblObservacionAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblObservacionAgregar.Location = new System.Drawing.Point(581, 48);
            this.lblObservacionAgregar.Name = "lblObservacionAgregar";
            this.lblObservacionAgregar.Size = new System.Drawing.Size(160, 21);
            this.lblObservacionAgregar.TabIndex = 11;
            this.lblObservacionAgregar.Text = "Nueva Observación";
            // 
            // lblMascotaMalestar
            // 
            this.lblMascotaMalestar.AutoSize = true;
            this.lblMascotaMalestar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMascotaMalestar.Location = new System.Drawing.Point(346, 9);
            this.lblMascotaMalestar.Name = "lblMascotaMalestar";
            this.lblMascotaMalestar.Size = new System.Drawing.Size(0, 30);
            this.lblMascotaMalestar.TabIndex = 12;
            // 
            // lblEstadoTurno
            // 
            this.lblEstadoTurno.AutoSize = true;
            this.lblEstadoTurno.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoTurno.Location = new System.Drawing.Point(12, 9);
            this.lblEstadoTurno.Name = "lblEstadoTurno";
            this.lblEstadoTurno.Size = new System.Drawing.Size(31, 37);
            this.lblEstadoTurno.TabIndex = 13;
            this.lblEstadoTurno.Text = "E";
            // 
            // lblVisitasPrevias
            // 
            this.lblVisitasPrevias.AutoSize = true;
            this.lblVisitasPrevias.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVisitasPrevias.Location = new System.Drawing.Point(889, 16);
            this.lblVisitasPrevias.Name = "lblVisitasPrevias";
            this.lblVisitasPrevias.Size = new System.Drawing.Size(151, 30);
            this.lblVisitasPrevias.TabIndex = 14;
            this.lblVisitasPrevias.Text = "Visitas Previas";
            // 
            // dgvPrecios
            // 
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecios.Location = new System.Drawing.Point(719, 67);
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.RowTemplate.Height = 25;
            this.dgvPrecios.Size = new System.Drawing.Size(435, 420);
            this.dgvPrecios.TabIndex = 15;
            // 
            // btnDesplegarDgvs
            // 
            this.btnDesplegarDgvs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesplegarDgvs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDesplegarDgvs.Location = new System.Drawing.Point(689, 513);
            this.btnDesplegarDgvs.Name = "btnDesplegarDgvs";
            this.btnDesplegarDgvs.Size = new System.Drawing.Size(158, 58);
            this.btnDesplegarDgvs.TabIndex = 16;
            this.btnDesplegarDgvs.Text = "Mostrar Precios";
            this.btnDesplegarDgvs.UseVisualStyleBackColor = true;
            this.btnDesplegarDgvs.Click += new System.EventHandler(this.btnDesplegarHistorial_Click);
            // 
            // AtenderPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnDesplegarDgvs);
            this.Controls.Add(this.lblVisitasPrevias);
            this.Controls.Add(this.lblEstadoTurno);
            this.Controls.Add(this.lblMascotaMalestar);
            this.Controls.Add(this.lblObservacionAgregar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.gbHistorial);
            this.Controls.Add(this.btnCostoConsulta);
            this.Controls.Add(this.btnAgregarNuevaVisita);
            this.Controls.Add(this.btnAtenderSeleccionado);
            this.Controls.Add(this.dgvAtender);
            this.Controls.Add(this.dgvPrecios);
            this.Controls.Add(this.dgvFechaTurnos);
            this.Name = "AtenderPacientes";
            this.Text = "AtenderPacientes";
            this.Controls.SetChildIndex(this.dgvFechaTurnos, 0);
            this.Controls.SetChildIndex(this.dgvPrecios, 0);
            this.Controls.SetChildIndex(this.dgvAtender, 0);
            this.Controls.SetChildIndex(this.btnAtenderSeleccionado, 0);
            this.Controls.SetChildIndex(this.btnAgregarNuevaVisita, 0);
            this.Controls.SetChildIndex(this.btnCostoConsulta, 0);
            this.Controls.SetChildIndex(this.gbHistorial, 0);
            this.Controls.SetChildIndex(this.txtObservaciones, 0);
            this.Controls.SetChildIndex(this.lblObservacionAgregar, 0);
            this.Controls.SetChildIndex(this.lblMascotaMalestar, 0);
            this.Controls.SetChildIndex(this.lblEstadoTurno, 0);
            this.Controls.SetChildIndex(this.lblVisitasPrevias, 0);
            this.Controls.SetChildIndex(this.btnDesplegarDgvs, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechaTurnos)).EndInit();
            this.gbHistorial.ResumeLayout(false);
            this.gbHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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