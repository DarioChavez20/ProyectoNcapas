using Forms.Modelo;
using System;
using System.Windows.Forms;
using System.Linq;
using Forms.vista;

namespace AppF.vista
{
    public partial class Home : Form
    {
        public int ide;
        public Home(int ide)
        {
            InitializeComponent();
            this.ide = ide;
        }
        private void Ir_a_Log_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido ");
            Form form1 = new Login();
            form1.Show();

        }


        private void Home_Load(object sender, EventArgs e)
        {
            ObtenerDatos();
        }
        private void ObtenerDatos()
        {
            using (CrCrudEntities1 db = new CrCrudEntities1())
            {

                var listado = from b in db.datos
                              select new {b.id, b.producto, b.valor, b.fk_usuarios};
                dataGridView1.DataSource = listado.ToList();
                foreach (int vt in listado.Select(d => d.valor))
                {
                    TotalTxt.Text = vt.ToString();
                }
            }
        }

        private void BtCrear_Click(object sender, EventArgs e)
        {
            int? id = null;
            vista.Form2 formCrea = new vista.Form2(ide,id);
            formCrea.ShowDialog();
            ObtenerDatos();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            if (id != null)
            {
                vista.Form2 edit = new vista.Form2(ide,id);
                edit.ShowDialog();
                ObtenerDatos();
            }
        }

        private void BtDelet_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            if (id != null)
            {
                using (CrCrudEntities1 db = new CrCrudEntities1())
                {
                    datos listado = db.datos.Find(id);
                    db.datos.Remove(listado);
                    db.SaveChanges();
                }
                ObtenerDatos();
            }
        }

        private void TotalTxt_TextChanged(object sender, EventArgs e)
        {
            int suma = 0;

            foreach (DataGridViewRow Columna in dataGridView1.Rows)
            {
                suma += Convert.ToInt32(Columna.Cells["valor"].Value);
            }

            TotalTxt.Text = suma.ToString();
        }

        private void Ir_Usuarios_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            Form pd = new UsuariosPag();
            pd.Show();
            MessageBox.Show("Informacion del usuario ");
            
        }
    }
}

