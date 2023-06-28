namespace Veterinaria__
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLoguear = new System.Windows.Forms.Button();
            this.pic_CatLogin = new System.Windows.Forms.PictureBox();
            this.lbl_Bienvenida = new System.Windows.Forms.Label();
            this.pic_Mostrar = new System.Windows.Forms.PictureBox();
            this.pic_Ocultar = new System.Windows.Forms.PictureBox();
            this.pic_Admin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CatLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(494, 380);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 23);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.MouseEnter += new System.EventHandler(this.txtUsername_MouseEnter);
            this.txtUsername.MouseLeave += new System.EventHandler(this.txtUsername_MouseLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(494, 475);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(180, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.MouseEnter += new System.EventHandler(this.txtPassword_MouseEnter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(541, 336);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 25);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(530, 427);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(113, 25);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Contraseña";
            // 
            // btnLoguear
            // 
            this.btnLoguear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoguear.Location = new System.Drawing.Point(530, 539);
            this.btnLoguear.Name = "btnLoguear";
            this.btnLoguear.Size = new System.Drawing.Size(113, 31);
            this.btnLoguear.TabIndex = 5;
            this.btnLoguear.Text = "Entrar";
            this.btnLoguear.UseVisualStyleBackColor = true;
            this.btnLoguear.Click += new System.EventHandler(this.btnLoguear_Click);
            this.btnLoguear.MouseEnter += new System.EventHandler(this.btnLoguear_MouseEnter);
            this.btnLoguear.MouseLeave += new System.EventHandler(this.btnLoguear_MouseLeave);
            // 
            // pic_CatLogin
            // 
            this.pic_CatLogin.Image = ((System.Drawing.Image)(resources.GetObject("pic_CatLogin.Image")));
            this.pic_CatLogin.Location = new System.Drawing.Point(389, -10);
            this.pic_CatLogin.Name = "pic_CatLogin";
            this.pic_CatLogin.Size = new System.Drawing.Size(387, 276);
            this.pic_CatLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_CatLogin.TabIndex = 6;
            this.pic_CatLogin.TabStop = false;
            // 
            // lbl_Bienvenida
            // 
            this.lbl_Bienvenida.AutoSize = true;
            this.lbl_Bienvenida.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bienvenida.Location = new System.Drawing.Point(507, 264);
            this.lbl_Bienvenida.Name = "lbl_Bienvenida";
            this.lbl_Bienvenida.Size = new System.Drawing.Size(149, 32);
            this.lbl_Bienvenida.TabIndex = 7;
            this.lbl_Bienvenida.Text = "¡Bienvenido!";
            // 
            // pic_Mostrar
            // 
            this.pic_Mostrar.Image = ((System.Drawing.Image)(resources.GetObject("pic_Mostrar.Image")));
            this.pic_Mostrar.Location = new System.Drawing.Point(692, 473);
            this.pic_Mostrar.Name = "pic_Mostrar";
            this.pic_Mostrar.Size = new System.Drawing.Size(29, 25);
            this.pic_Mostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Mostrar.TabIndex = 8;
            this.pic_Mostrar.TabStop = false;
            this.pic_Mostrar.Click += new System.EventHandler(this.pic_Mostrar_Click);
            // 
            // pic_Ocultar
            // 
            this.pic_Ocultar.Image = ((System.Drawing.Image)(resources.GetObject("pic_Ocultar.Image")));
            this.pic_Ocultar.Location = new System.Drawing.Point(692, 473);
            this.pic_Ocultar.Name = "pic_Ocultar";
            this.pic_Ocultar.Size = new System.Drawing.Size(29, 25);
            this.pic_Ocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Ocultar.TabIndex = 9;
            this.pic_Ocultar.TabStop = false;
            this.pic_Ocultar.Click += new System.EventHandler(this.pic_Ocultar_Click);
            this.pic_Ocultar.MouseEnter += new System.EventHandler(this.pic_Ocultar_MouseEnter);
            this.pic_Ocultar.MouseLeave += new System.EventHandler(this.pic_Ocultar_MouseLeave);
            // 
            // pic_Admin
            // 
            this.pic_Admin.Image = ((System.Drawing.Image)(resources.GetObject("pic_Admin.Image")));
            this.pic_Admin.Location = new System.Drawing.Point(27, 573);
            this.pic_Admin.Name = "pic_Admin";
            this.pic_Admin.Size = new System.Drawing.Size(96, 57);
            this.pic_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Admin.TabIndex = 10;
            this.pic_Admin.TabStop = false;
            this.pic_Admin.Click += new System.EventHandler(this.pic_Admin_Click);
            this.pic_Admin.MouseEnter += new System.EventHandler(this.pic_Admin_MouseEnter);
            this.pic_Admin.MouseLeave += new System.EventHandler(this.pic_Admin_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pic_Admin);
            this.Controls.Add(this.pic_Ocultar);
            this.Controls.Add(this.pic_Mostrar);
            this.Controls.Add(this.lbl_Bienvenida);
            this.Controls.Add(this.pic_CatLogin);
            this.Controls.Add(this.btnLoguear);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Controls.SetChildIndex(this.txtUsername, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.lblUsername, 0);
            this.Controls.SetChildIndex(this.lblPassword, 0);
            this.Controls.SetChildIndex(this.btnLoguear, 0);
            this.Controls.SetChildIndex(this.pic_CatLogin, 0);
            this.Controls.SetChildIndex(this.lbl_Bienvenida, 0);
            this.Controls.SetChildIndex(this.pic_Mostrar, 0);
            this.Controls.SetChildIndex(this.pic_Ocultar, 0);
            this.Controls.SetChildIndex(this.pic_Admin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CatLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLoguear;
        private PictureBox pic_CatLogin;
        private Label lbl_Bienvenida;
        private PictureBox pic_Mostrar;
        private PictureBox pic_Ocultar;
        private PictureBox pic_Admin;
    }
}