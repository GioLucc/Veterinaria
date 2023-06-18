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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechaTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAtender
            // 
            this.dgvAtender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtender.Location = new System.Drawing.Point(585, 12);
            this.dgvAtender.Name = "dgvAtender";
            this.dgvAtender.RowTemplate.Height = 25;
            this.dgvAtender.Size = new System.Drawing.Size(540, 308);
            this.dgvAtender.TabIndex = 3;
            // 
            // btnAtenderSeleccionado
            // 
            this.btnAtenderSeleccionado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtenderSeleccionado.Location = new System.Drawing.Point(402, 479);
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
            this.dgvFechaTurnos.Location = new System.Drawing.Point(777, 12);
            this.dgvFechaTurnos.Name = "dgvFechaTurnos";
            this.dgvFechaTurnos.RowTemplate.Height = 25;
            this.dgvFechaTurnos.Size = new System.Drawing.Size(348, 308);
            this.dgvFechaTurnos.TabIndex = 5;
            // 
            // AtenderPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.dgvFechaTurnos);
            this.Controls.Add(this.btnAtenderSeleccionado);
            this.Controls.Add(this.dgvAtender);
            this.Name = "AtenderPacientes";
            this.Text = "AtenderPacientes";
            this.Controls.SetChildIndex(this.dgvAtender, 0);
            this.Controls.SetChildIndex(this.btnAtenderSeleccionado, 0);
            this.Controls.SetChildIndex(this.dgvFechaTurnos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechaTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAtender;
        private Button btnAtenderSeleccionado;
        private DataGridView dgvFechaTurnos;
    }
}