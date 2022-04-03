
namespace Forms.vista
{
    partial class Productos_Usuario
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Result = new System.Windows.Forms.Label();
            this.VolverBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView3.Location = new System.Drawing.Point(0, 238);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(800, 212);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.Color.Transparent;
            this.Result.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Result.Location = new System.Drawing.Point(12, 23);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(306, 24);
            this.Result.TabIndex = 1;
            this.Result.Text = "Resultado de la selección";
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // VolverBt
            // 
            this.VolverBt.BackColor = System.Drawing.Color.Black;
            this.VolverBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VolverBt.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VolverBt.Location = new System.Drawing.Point(617, 38);
            this.VolverBt.Name = "VolverBt";
            this.VolverBt.Size = new System.Drawing.Size(100, 41);
            this.VolverBt.TabIndex = 3;
            this.VolverBt.Text = "Volver";
            this.VolverBt.UseVisualStyleBackColor = false;
            this.VolverBt.Click += new System.EventHandler(this.VolverBt_Click);
            // 
            // Productos_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms.Properties.Resources._437107_Aatrox_Aatrox_League_of_Legends_demon_eyes_demon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VolverBt);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Productos_Usuario";
            this.Text = "Productos_Usuario";
            this.Load += new System.EventHandler(this.Productos_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button VolverBt;
    }
}