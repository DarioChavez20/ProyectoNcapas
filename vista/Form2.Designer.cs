


namespace AppF.vista
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.LabProd = new System.Windows.Forms.Label();
            this.LabValor = new System.Windows.Forms.Label();
            this.TBprod = new System.Windows.Forms.TextBox();
            this.TBvalor = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabProd
            // 
            this.LabProd.AutoSize = true;
            this.LabProd.BackColor = System.Drawing.Color.Transparent;
            this.LabProd.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabProd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LabProd.Location = new System.Drawing.Point(22, 27);
            this.LabProd.Name = "LabProd";
            this.LabProd.Size = new System.Drawing.Size(102, 21);
            this.LabProd.TabIndex = 0;
            this.LabProd.Text = "Producto";
            this.LabProd.Click += new System.EventHandler(this.LabProd_Click);
            // 
            // LabValor
            // 
            this.LabValor.AutoSize = true;
            this.LabValor.BackColor = System.Drawing.Color.Transparent;
            this.LabValor.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabValor.ForeColor = System.Drawing.Color.White;
            this.LabValor.Location = new System.Drawing.Point(22, 87);
            this.LabValor.Name = "LabValor";
            this.LabValor.Size = new System.Drawing.Size(66, 21);
            this.LabValor.TabIndex = 1;
            this.LabValor.Text = "Valor";
            this.LabValor.Click += new System.EventHandler(this.label2_Click);
            // 
            // TBprod
            // 
            this.TBprod.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBprod.Location = new System.Drawing.Point(159, 27);
            this.TBprod.Name = "TBprod";
            this.TBprod.Size = new System.Drawing.Size(187, 23);
            this.TBprod.TabIndex = 2;
            // 
            // TBvalor
            // 
            this.TBvalor.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBvalor.Location = new System.Drawing.Point(144, 85);
            this.TBvalor.Name = "TBvalor";
            this.TBvalor.Size = new System.Drawing.Size(187, 23);
            this.TBvalor.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(87, 169);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 39);
            this.Save.TabIndex = 4;
            this.Save.Text = "Guardar";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms.Properties.Resources._437107_Aatrox_Aatrox_League_of_Legends_demon_eyes_demon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.TBvalor);
            this.Controls.Add(this.TBprod);
            this.Controls.Add(this.LabValor);
            this.Controls.Add(this.LabProd);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabProd;
        private System.Windows.Forms.Label LabValor;
        private System.Windows.Forms.TextBox TBprod;
        private System.Windows.Forms.TextBox TBvalor;
        private System.Windows.Forms.Button Save;
    }
}