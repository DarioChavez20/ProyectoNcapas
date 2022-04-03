
namespace AppF.vista
{
    partial class Home
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
            this.Home1 = new System.Windows.Forms.Label();
            this.Ir_a_Log = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtCrear = new System.Windows.Forms.Button();
            this.BtEdit = new System.Windows.Forms.Button();
            this.BtDelet = new System.Windows.Forms.Button();
            this.VTotal = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.Ir_Usuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Home1
            // 
            this.Home1.AutoSize = true;
            this.Home1.BackColor = System.Drawing.Color.Transparent;
            this.Home1.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Home1.Location = new System.Drawing.Point(12, 9);
            this.Home1.Name = "Home1";
            this.Home1.Size = new System.Drawing.Size(185, 63);
            this.Home1.TabIndex = 0;
            this.Home1.Text = "HOME";
            // 
            // Ir_a_Log
            // 
            this.Ir_a_Log.BackColor = System.Drawing.Color.Maroon;
            this.Ir_a_Log.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Ir_a_Log.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ir_a_Log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Ir_a_Log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Ir_a_Log.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ir_a_Log.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ir_a_Log.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ir_a_Log.Location = new System.Drawing.Point(23, 75);
            this.Ir_a_Log.Name = "Ir_a_Log";
            this.Ir_a_Log.Size = new System.Drawing.Size(174, 29);
            this.Ir_a_Log.TabIndex = 3;
            this.Ir_a_Log.Text = "Ir a Login";
            this.Ir_a_Log.UseVisualStyleBackColor = false;
            this.Ir_a_Log.Click += new System.EventHandler(this.Ir_a_Log_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(400, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 448);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtCrear
            // 
            this.BtCrear.BackColor = System.Drawing.Color.Maroon;
            this.BtCrear.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtCrear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtCrear.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCrear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtCrear.Location = new System.Drawing.Point(61, 128);
            this.BtCrear.Name = "BtCrear";
            this.BtCrear.Size = new System.Drawing.Size(75, 23);
            this.BtCrear.TabIndex = 5;
            this.BtCrear.Text = "Crear";
            this.BtCrear.UseVisualStyleBackColor = false;
            this.BtCrear.Click += new System.EventHandler(this.BtCrear_Click);
            // 
            // BtEdit
            // 
            this.BtEdit.BackColor = System.Drawing.Color.Maroon;
            this.BtEdit.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtEdit.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtEdit.Location = new System.Drawing.Point(61, 178);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(75, 23);
            this.BtEdit.TabIndex = 6;
            this.BtEdit.Text = "Editar";
            this.BtEdit.UseVisualStyleBackColor = false;
            this.BtEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // BtDelet
            // 
            this.BtDelet.BackColor = System.Drawing.Color.Maroon;
            this.BtDelet.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtDelet.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtDelet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtDelet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtDelet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtDelet.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDelet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtDelet.Location = new System.Drawing.Point(61, 233);
            this.BtDelet.Name = "BtDelet";
            this.BtDelet.Size = new System.Drawing.Size(75, 23);
            this.BtDelet.TabIndex = 7;
            this.BtDelet.Text = "Eliminar";
            this.BtDelet.UseVisualStyleBackColor = false;
            this.BtDelet.Click += new System.EventHandler(this.BtDelet_Click);
            // 
            // VTotal
            // 
            this.VTotal.AutoSize = true;
            this.VTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.VTotal.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VTotal.Location = new System.Drawing.Point(416, 209);
            this.VTotal.Name = "VTotal";
            this.VTotal.Size = new System.Drawing.Size(87, 15);
            this.VTotal.TabIndex = 8;
            this.VTotal.Text = "Valor Total";
            // 
            // TotalTxt
            // 
            this.TotalTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TotalTxt.Enabled = false;
            this.TotalTxt.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxt.ForeColor = System.Drawing.Color.Black;
            this.TotalTxt.Location = new System.Drawing.Point(528, 206);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.Size = new System.Drawing.Size(132, 23);
            this.TotalTxt.TabIndex = 9;
            this.TotalTxt.TextChanged += new System.EventHandler(this.TotalTxt_TextChanged);
            // 
            // Ir_Usuarios
            // 
            this.Ir_Usuarios.BackColor = System.Drawing.Color.Maroon;
            this.Ir_Usuarios.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Ir_Usuarios.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ir_Usuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Ir_Usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Ir_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ir_Usuarios.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ir_Usuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ir_Usuarios.Location = new System.Drawing.Point(61, 281);
            this.Ir_Usuarios.Name = "Ir_Usuarios";
            this.Ir_Usuarios.Size = new System.Drawing.Size(75, 23);
            this.Ir_Usuarios.TabIndex = 10;
            this.Ir_Usuarios.Text = "Usuarios";
            this.Ir_Usuarios.UseVisualStyleBackColor = false;
            this.Ir_Usuarios.Click += new System.EventHandler(this.Ir_Usuarios_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::Forms.Properties.Resources._437107_Aatrox_Aatrox_League_of_Legends_demon_eyes_demon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ir_Usuarios);
            this.Controls.Add(this.TotalTxt);
            this.Controls.Add(this.VTotal);
            this.Controls.Add(this.BtDelet);
            this.Controls.Add(this.BtEdit);
            this.Controls.Add(this.BtCrear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ir_a_Log);
            this.Controls.Add(this.Home1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Home1;
        private System.Windows.Forms.Button Ir_a_Log;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtCrear;
        private System.Windows.Forms.Button BtEdit;
        private System.Windows.Forms.Button BtDelet;
        private System.Windows.Forms.Label VTotal;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.Button Ir_Usuarios;
    }
}