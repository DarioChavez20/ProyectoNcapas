
namespace AppF.vista
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows AppF

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Usuario1 = new System.Windows.Forms.TextBox();
            this.ContraseñaT = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Ir_a_Reg = new System.Windows.Forms.Label();
            this.Link_Reg = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Cornsilk;
            this.Titulo.Location = new System.Drawing.Point(569, 29);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(196, 63);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "LOGIN";
            this.Titulo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forms.Properties.Resources._437107_Aatrox_Aatrox_League_of_Legends_demon_eyes_demon;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Usuario.Location = new System.Drawing.Point(638, 122);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(57, 15);
            this.Usuario.TabIndex = 3;
            this.Usuario.Text = "Usuario";
            this.Usuario.Click += new System.EventHandler(this.Usuario_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Contraseña.Location = new System.Drawing.Point(627, 216);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(80, 15);
            this.Contraseña.TabIndex = 4;
            this.Contraseña.Text = "Contraseña";
            this.Contraseña.Click += new System.EventHandler(this.Contraseña_Click);
            // 
            // Usuario1
            // 
            this.Usuario1.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario1.Location = new System.Drawing.Point(580, 152);
            this.Usuario1.Name = "Usuario1";
            this.Usuario1.Size = new System.Drawing.Size(160, 23);
            this.Usuario1.TabIndex = 6;
            this.Usuario1.TextChanged += new System.EventHandler(this.Usuario1_TextChanged);
            // 
            // ContraseñaT
            // 
            this.ContraseñaT.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaT.Location = new System.Drawing.Point(580, 250);
            this.ContraseñaT.Name = "ContraseñaT";
            this.ContraseñaT.Size = new System.Drawing.Size(160, 23);
            this.ContraseñaT.TabIndex = 7;
            this.ContraseñaT.TextChanged += new System.EventHandler(this.ContraseñaT_TextChanged);
            // 
            // Aceptar
            // 
            this.Aceptar.AutoSize = true;
            this.Aceptar.BackColor = System.Drawing.SystemColors.MenuText;
            this.Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Aceptar.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Aceptar.Image")));
            this.Aceptar.Location = new System.Drawing.Point(632, 345);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 43);
            this.Aceptar.TabIndex = 8;
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Ir_a_Reg
            // 
            this.Ir_a_Reg.AutoSize = true;
            this.Ir_a_Reg.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ir_a_Reg.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Ir_a_Reg.Location = new System.Drawing.Point(368, 278);
            this.Ir_a_Reg.Name = "Ir_a_Reg";
            this.Ir_a_Reg.Size = new System.Drawing.Size(0, 15);
            this.Ir_a_Reg.TabIndex = 9;
            // 
            // Link_Reg
            // 
            this.Link_Reg.ActiveLinkColor = System.Drawing.Color.DarkOrchid;
            this.Link_Reg.AutoSize = true;
            this.Link_Reg.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_Reg.LinkColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Link_Reg.Location = new System.Drawing.Point(572, 299);
            this.Link_Reg.Name = "Link_Reg";
            this.Link_Reg.Size = new System.Drawing.Size(168, 16);
            this.Link_Reg.TabIndex = 10;
            this.Link_Reg.TabStop = true;
            this.Link_Reg.Text = "¿No tienes una cuenta?";
            this.Link_Reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Link_Reg);
            this.Controls.Add(this.Ir_a_Reg);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.ContraseñaT);
            this.Controls.Add(this.Usuario1);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox Usuario1;
        private System.Windows.Forms.TextBox ContraseñaT;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Label Ir_a_Reg;
        private System.Windows.Forms.LinkLabel Link_Reg;
    }
}

