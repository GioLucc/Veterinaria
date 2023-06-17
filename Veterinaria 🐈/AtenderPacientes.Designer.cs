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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtender)).BeginInit();
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
            // AtenderPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.dgvAtender);
            this.Name = "AtenderPacientes";
            this.Text = "AtenderPacientes";
            this.Controls.SetChildIndex(this.dgvAtender, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAtender;
    }
}