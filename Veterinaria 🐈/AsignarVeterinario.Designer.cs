namespace Veterinaria__
{
    partial class AsignarVeterinario
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
            this.dgvAsignarVet = new System.Windows.Forms.DataGridView();
            this.dgvVeterinariosDisponibles = new System.Windows.Forms.DataGridView();
            this.btnRelacionarDgvs = new System.Windows.Forms.Button();
            this.lblVeterinariosDisp = new System.Windows.Forms.Label();
            this.lblTurnosSinVet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignarVet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinariosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsignarVet
            // 
            this.dgvAsignarVet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignarVet.Location = new System.Drawing.Point(12, 88);
            this.dgvAsignarVet.Name = "dgvAsignarVet";
            this.dgvAsignarVet.RowTemplate.Height = 25;
            this.dgvAsignarVet.Size = new System.Drawing.Size(811, 387);
            this.dgvAsignarVet.TabIndex = 3;
            // 
            // dgvVeterinariosDisponibles
            // 
            this.dgvVeterinariosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeterinariosDisponibles.Location = new System.Drawing.Point(855, 85);
            this.dgvVeterinariosDisponibles.Name = "dgvVeterinariosDisponibles";
            this.dgvVeterinariosDisponibles.RowTemplate.Height = 25;
            this.dgvVeterinariosDisponibles.Size = new System.Drawing.Size(307, 387);
            this.dgvVeterinariosDisponibles.TabIndex = 4;
            // 
            // btnRelacionarDgvs
            // 
            this.btnRelacionarDgvs.Location = new System.Drawing.Point(521, 536);
            this.btnRelacionarDgvs.Name = "btnRelacionarDgvs";
            this.btnRelacionarDgvs.Size = new System.Drawing.Size(167, 52);
            this.btnRelacionarDgvs.TabIndex = 5;
            this.btnRelacionarDgvs.Text = "Asignar Vet a Turno";
            this.btnRelacionarDgvs.UseVisualStyleBackColor = true;
            this.btnRelacionarDgvs.Click += new System.EventHandler(this.btnRelacionarDgvs_Click);
            // 
            // lblVeterinariosDisp
            // 
            this.lblVeterinariosDisp.AutoSize = true;
            this.lblVeterinariosDisp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVeterinariosDisp.Location = new System.Drawing.Point(909, 41);
            this.lblVeterinariosDisp.Name = "lblVeterinariosDisp";
            this.lblVeterinariosDisp.Size = new System.Drawing.Size(196, 21);
            this.lblVeterinariosDisp.TabIndex = 6;
            this.lblVeterinariosDisp.Text = "Veterinarios Disponibles";
            // 
            // lblTurnosSinVet
            // 
            this.lblTurnosSinVet.AutoSize = true;
            this.lblTurnosSinVet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTurnosSinVet.Location = new System.Drawing.Point(307, 37);
            this.lblTurnosSinVet.Name = "lblTurnosSinVet";
            this.lblTurnosSinVet.Size = new System.Drawing.Size(214, 25);
            this.lblTurnosSinVet.TabIndex = 7;
            this.lblTurnosSinVet.Text = "Turnos sin veterinarios";
            // 
            // AsignarVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lblTurnosSinVet);
            this.Controls.Add(this.lblVeterinariosDisp);
            this.Controls.Add(this.btnRelacionarDgvs);
            this.Controls.Add(this.dgvVeterinariosDisponibles);
            this.Controls.Add(this.dgvAsignarVet);
            this.Name = "AsignarVeterinario";
            this.Text = "AsignarVeterinario";
            this.Controls.SetChildIndex(this.dgvAsignarVet, 0);
            this.Controls.SetChildIndex(this.dgvVeterinariosDisponibles, 0);
            this.Controls.SetChildIndex(this.btnRelacionarDgvs, 0);
            this.Controls.SetChildIndex(this.lblVeterinariosDisp, 0);
            this.Controls.SetChildIndex(this.lblTurnosSinVet, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignarVet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinariosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAsignarVet;
        private DataGridView dgvVeterinariosDisponibles;
        private Button btnRelacionarDgvs;
        private Label lblVeterinariosDisp;
        private Label lblTurnosSinVet;
    }
}