
namespace Forms.vista
{
    partial class UsuariosPag
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AdminBt = new System.Windows.Forms.Button();
            this.SelectLb = new System.Windows.Forms.Label();
            this.UserBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(0, 300);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(800, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // AdminBt
            // 
            this.AdminBt.BackColor = System.Drawing.Color.Black;
            this.AdminBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminBt.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AdminBt.Location = new System.Drawing.Point(26, 112);
            this.AdminBt.Name = "AdminBt";
            this.AdminBt.Size = new System.Drawing.Size(174, 49);
            this.AdminBt.TabIndex = 1;
            this.AdminBt.Text = "Admins";
            this.AdminBt.UseVisualStyleBackColor = false;
            this.AdminBt.Click += new System.EventHandler(this.AdminBt_Click);
            // 
            // SelectLb
            // 
            this.SelectLb.AutoSize = true;
            this.SelectLb.BackColor = System.Drawing.Color.Transparent;
            this.SelectLb.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLb.ForeColor = System.Drawing.Color.White;
            this.SelectLb.Location = new System.Drawing.Point(24, 65);
            this.SelectLb.Name = "SelectLb";
            this.SelectLb.Size = new System.Drawing.Size(176, 20);
            this.SelectLb.TabIndex = 3;
            this.SelectLb.Text = "Seleccione un Rol";
            this.SelectLb.Click += new System.EventHandler(this.SelectLb_Click);
            // 
            // UserBt
            // 
            this.UserBt.BackColor = System.Drawing.Color.Black;
            this.UserBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserBt.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.UserBt.Location = new System.Drawing.Point(26, 179);
            this.UserBt.Name = "UserBt";
            this.UserBt.Size = new System.Drawing.Size(174, 49);
            this.UserBt.TabIndex = 4;
            this.UserBt.Text = "Users";
            this.UserBt.UseVisualStyleBackColor = false;
            this.UserBt.Click += new System.EventHandler(this.UserBt_Click);
            // 
            // UsuariosPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms.Properties.Resources._437107_Aatrox_Aatrox_League_of_Legends_demon_eyes_demon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserBt);
            this.Controls.Add(this.SelectLb);
            this.Controls.Add(this.AdminBt);
            this.Controls.Add(this.dataGridView2);
            this.Name = "UsuariosPag";
            this.Text = "UsuariosPag";
            this.Load += new System.EventHandler(this.UsuariosPag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AdminBt;
        private System.Windows.Forms.Label SelectLb;
        private System.Windows.Forms.Button UserBt;
    }
}