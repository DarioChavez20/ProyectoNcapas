using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms.Modelo;

namespace Forms.vista
{
    public partial class Productos_Usuario : Form
    {
        public int? id;
        public Productos_Usuario(int? id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void ObtenerDatos()
        {
            using (CrCrudEntities1 db = new CrCrudEntities1())
            {
                

                    var listado = from b in db.datos
                                  select new { b.id, b.producto, b.valor, b.fk_usuarios };
                    dataGridView3.DataSource = listado.ToList();
                }

        }

        private void Result_Click(object sender, EventArgs e)
        {
           
        }

        private void VolverBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volvera a la seleccion ");
            Form form1 = new UsuariosPag();
            form1.Show();
        }

        private void Productos_Usuario_Load(object sender, EventArgs e)
        {
            ObtenerDatos();
        }
    }
}
