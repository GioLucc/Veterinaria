namespace Veterinaria__
{
    partial class FormAnimalDomestico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRegistroMascotas = new System.Windows.Forms.DataGridView();
            this.dgvPrueba = new System.Windows.Forms.DataGridView();
            this.dgvFechaTurnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroMascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechaTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistroMascotas
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistroMascotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRegistroMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistroMascotas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRegistroMascotas.Location = new System.Drawing.Point(12, 12);
            this.dgvRegistroMascotas.Name = "dgvRegistroMascotas";
            this.dgvRegistroMascotas.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistroMascotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvRegistroMascotas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRegistroMascotas.RowTemplate.Height = 25;
            this.dgvRegistroMascotas.Size = new System.Drawing.Size(330, 637);
            this.dgvRegistroMascotas.TabIndex = 3;
            this.dgvRegistroMascotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvPrueba
            // 
            this.dgvPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrueba.Location = new System.Drawing.Point(364, 12);
            this.dgvPrueba.Name = "dgvPrueba";
            this.dgvPrueba.RowTemplate.Height = 25;
            this.dgvPrueba.Size = new System.Drawing.Size(798, 75);
            this.dgvPrueba.TabIndex = 4;
            // 
            // dgvFechaTurnos
            // 
            this.dgvFechaTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFechaTurnos.Location = new System.Drawing.Point(814, 120);
            this.dgvFechaTurnos.Name = "dgvFechaTurnos";
            this.dgvFechaTurnos.RowTemplate.Height = 25;
            this.dgvFechaTurnos.Size = new System.Drawing.Size(348, 308);
            this.dgvFechaTurnos.TabIndex = 6;
            // 
            // FormAnimalDomestico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.dgvFechaTurnos);
            this.Controls.Add(this.dgvPrueba);
            this.Controls.Add(this.dgvRegistroMascotas);
            this.Name = "FormAnimalDomestico";
            this.Text = "AnimalDomesticos";
            this.Load += new System.EventHandler(this.FormAnimalDomestico_Load);
            this.Controls.SetChildIndex(this.dgvRegistroMascotas, 0);
            this.Controls.SetChildIndex(this.dgvPrueba, 0);
            this.Controls.SetChildIndex(this.dgvFechaTurnos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroMascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechaTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvRegistroMascotas;
        private DataGridView dgvPrueba;
        private DataGridView dgvFechaTurnos;
    }
}