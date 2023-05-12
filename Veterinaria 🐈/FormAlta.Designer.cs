namespace Veterinaria__
{
    partial class FormAlta
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
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtEnfermedadActual = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtIdDueño = new System.Windows.Forms.TextBox();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblEnfermeddadActual = new System.Windows.Forms.Label();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.lblNombreDueño = new System.Windows.Forms.Label();
            this.lblIdDueño = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblSexo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnValidarAdmin = new System.Windows.Forms.Button();
            this.chkTrabajando = new System.Windows.Forms.CheckBox();
            this.chkEsAdmin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(66, 40);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(100, 23);
            this.txtEspecie.TabIndex = 3;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(66, 112);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 23);
            this.txtRaza.TabIndex = 4;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(66, 317);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 23);
            this.txtPeso.TabIndex = 6;
            // 
            // txtEnfermedadActual
            // 
            this.txtEnfermedadActual.Location = new System.Drawing.Point(369, 40);
            this.txtEnfermedadActual.Name = "txtEnfermedadActual";
            this.txtEnfermedadActual.Size = new System.Drawing.Size(100, 23);
            this.txtEnfermedadActual.TabIndex = 7;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(66, 419);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 23);
            this.txtSexo.TabIndex = 12;
            // 
            // txtIdDueño
            // 
            this.txtIdDueño.Location = new System.Drawing.Point(369, 317);
            this.txtIdDueño.Name = "txtIdDueño";
            this.txtIdDueño.Size = new System.Drawing.Size(100, 23);
            this.txtIdDueño.TabIndex = 10;
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.Location = new System.Drawing.Point(370, 210);
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.Size = new System.Drawing.Size(100, 23);
            this.txtNombreDueño.TabIndex = 9;
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(370, 112);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(100, 23);
            this.txtNombreMascota.TabIndex = 8;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspecie.Location = new System.Drawing.Point(89, 9);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(53, 17);
            this.lblEspecie.TabIndex = 13;
            this.lblEspecie.Text = "Especie";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRaza.Location = new System.Drawing.Point(91, 81);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(36, 17);
            this.lblRaza.TabIndex = 14;
            this.lblRaza.Text = "Raza";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdad.Location = new System.Drawing.Point(91, 173);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 17);
            this.lblEdad.TabIndex = 15;
            this.lblEdad.Text = "Edad";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPeso.Location = new System.Drawing.Point(92, 277);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(37, 17);
            this.lblPeso.TabIndex = 16;
            this.lblPeso.Text = "Peso";
            // 
            // lblEnfermeddadActual
            // 
            this.lblEnfermeddadActual.AutoSize = true;
            this.lblEnfermeddadActual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnfermeddadActual.Location = new System.Drawing.Point(389, 9);
            this.lblEnfermeddadActual.Name = "lblEnfermeddadActual";
            this.lblEnfermeddadActual.Size = new System.Drawing.Size(61, 17);
            this.lblEnfermeddadActual.TabIndex = 17;
            this.lblEnfermeddadActual.Text = "Malestar";
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreMascota.Location = new System.Drawing.Point(373, 81);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(113, 17);
            this.lblNombreMascota.TabIndex = 18;
            this.lblNombreMascota.Text = "Nombre Mascota";
            // 
            // lblNombreDueño
            // 
            this.lblNombreDueño.AutoSize = true;
            this.lblNombreDueño.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreDueño.Location = new System.Drawing.Point(372, 173);
            this.lblNombreDueño.Name = "lblNombreDueño";
            this.lblNombreDueño.Size = new System.Drawing.Size(103, 17);
            this.lblNombreDueño.TabIndex = 19;
            this.lblNombreDueño.Text = "Nombre Dueño";
            // 
            // lblIdDueño
            // 
            this.lblIdDueño.AutoSize = true;
            this.lblIdDueño.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdDueño.Location = new System.Drawing.Point(386, 277);
            this.lblIdDueño.Name = "lblIdDueño";
            this.lblIdDueño.Size = new System.Drawing.Size(65, 17);
            this.lblIdDueño.TabIndex = 20;
            this.lblIdDueño.Text = "Id Dueño";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(220, 502);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(110, 35);
            this.btnValidar.TabIndex = 21;
            this.btnValidar.Text = "Validar Datos";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNacimiento.Location = new System.Drawing.Point(66, 207);
            this.dtpNacimiento.MaxDate = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            this.dtpNacimiento.MinDate = new System.DateTime(1999, 12, 25, 0, 0, 0, 0);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(100, 23);
            this.dtpNacimiento.TabIndex = 22;
            this.dtpNacimiento.Value = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(100, 379);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(32, 15);
            this.lblSexo.TabIndex = 23;
            this.lblSexo.Text = "Sexo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(535, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(637, 430);
            this.dataGridView1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 25;
            this.button1.Text = "Mostrar Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnValidarAdmin
            // 
            this.btnValidarAdmin.Location = new System.Drawing.Point(220, 502);
            this.btnValidarAdmin.Name = "btnValidarAdmin";
            this.btnValidarAdmin.Size = new System.Drawing.Size(110, 35);
            this.btnValidarAdmin.TabIndex = 26;
            this.btnValidarAdmin.Text = "Crear Usuario";
            this.btnValidarAdmin.UseVisualStyleBackColor = true;
            this.btnValidarAdmin.Click += new System.EventHandler(this.btnValidarAdmin_Click);
            // 
            // chkTrabajando
            // 
            this.chkTrabajando.AutoSize = true;
            this.chkTrabajando.Location = new System.Drawing.Point(412, 317);
            this.chkTrabajando.Name = "chkTrabajando";
            this.chkTrabajando.Size = new System.Drawing.Size(15, 14);
            this.chkTrabajando.TabIndex = 27;
            this.chkTrabajando.UseVisualStyleBackColor = true;
            // 
            // chkEsAdmin
            // 
            this.chkEsAdmin.AutoSize = true;
            this.chkEsAdmin.Location = new System.Drawing.Point(103, 317);
            this.chkEsAdmin.Name = "chkEsAdmin";
            this.chkEsAdmin.Size = new System.Drawing.Size(15, 14);
            this.chkEsAdmin.TabIndex = 28;
            this.chkEsAdmin.UseVisualStyleBackColor = true;
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.chkEsAdmin);
            this.Controls.Add(this.chkTrabajando);
            this.Controls.Add(this.btnValidarAdmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblIdDueño);
            this.Controls.Add(this.lblNombreDueño);
            this.Controls.Add(this.lblNombreMascota);
            this.Controls.Add(this.lblEnfermeddadActual);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtIdDueño);
            this.Controls.Add(this.txtNombreDueño);
            this.Controls.Add(this.txtNombreMascota);
            this.Controls.Add(this.txtEnfermedadActual);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtEspecie);
            this.Name = "FormAlta";
            this.Text = "FormAlta";
            this.Controls.SetChildIndex(this.txtEspecie, 0);
            this.Controls.SetChildIndex(this.txtRaza, 0);
            this.Controls.SetChildIndex(this.txtPeso, 0);
            this.Controls.SetChildIndex(this.txtEnfermedadActual, 0);
            this.Controls.SetChildIndex(this.txtNombreMascota, 0);
            this.Controls.SetChildIndex(this.txtNombreDueño, 0);
            this.Controls.SetChildIndex(this.txtIdDueño, 0);
            this.Controls.SetChildIndex(this.txtSexo, 0);
            this.Controls.SetChildIndex(this.lblEspecie, 0);
            this.Controls.SetChildIndex(this.lblRaza, 0);
            this.Controls.SetChildIndex(this.lblEdad, 0);
            this.Controls.SetChildIndex(this.lblPeso, 0);
            this.Controls.SetChildIndex(this.lblEnfermeddadActual, 0);
            this.Controls.SetChildIndex(this.lblNombreMascota, 0);
            this.Controls.SetChildIndex(this.lblNombreDueño, 0);
            this.Controls.SetChildIndex(this.lblIdDueño, 0);
            this.Controls.SetChildIndex(this.btnValidar, 0);
            this.Controls.SetChildIndex(this.dtpNacimiento, 0);
            this.Controls.SetChildIndex(this.lblSexo, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnValidarAdmin, 0);
            this.Controls.SetChildIndex(this.chkTrabajando, 0);
            this.Controls.SetChildIndex(this.chkEsAdmin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEspecie;
        private TextBox txtRaza;
        private TextBox txtPeso;
        private TextBox txtEnfermedadActual;
        private TextBox txtSexo;
        private TextBox textBox7;
        private TextBox txtIdDueño;
        private TextBox txtNombreDueño;
        private TextBox txtNombreMascota;
        private Label lblEspecie;
        private Label lblRaza;
        private Label lblEdad;
        private Label lblPeso;
        private Label lblEnfermeddadActual;
        private Label lblNombreMascota;
        private Label lblNombreDueño;
        private Label lblIdDueño;
        private Button btnValidar;
        private DateTimePicker dtpNacimiento;
        private Label lblSexo;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnValidarAdmin;
        private CheckBox chkTrabajando;
        private CheckBox chkEsAdmin;
    }
}