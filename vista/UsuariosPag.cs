using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Forms.Modelo;
using System.Windows.Forms;

namespace Forms.vista
{
    public partial class UsuariosPag : Form
    {
        public UsuariosPag()
        {
            InitializeComponent();
        }
       /* private void ObtenerDatos()
        {
            using (CrCrudEntities1 db = new CrCrudEntities1())
            {
                var listado = from u in db.usuarios
                              select new { u.id, u.nombre_Completo, u.nombre_Usuario, u.rol };
                dataGridView2.DataSource = listado.ToList();
            }
        }*/
        private void SelectLb_Click(object sender, EventArgs e)
        {

        }
        private void AdminBt_Click(object sender, EventArgs e)
        {
           /* try
            {*/

                using (CrCrudEntities1 db = new CrCrudEntities1())
                {

                /* var listado = from u in db.usuarios
                               select new { u.id, u.nombre_Completo, u.nombre_Usuario, u.rol };
                 dataGridView1.DataSource = listado.ToList();*/
                int? id = int.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString());
                Form form1 = new vista.Productos_Usuario(id);
                form1.ShowDialog();
                
                /*if (id != null)
                    if (listado.Count() == 1)
                    {
                        foreach (var users in listado.ToList())
                        {
                            if (users.rol == "admin, user")
                            {
                                MessageBox.Show("Selecciono " + users.rol);

                                Form ver = new Productos_Usuario(id);
                                ver.Show();

                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("seleccione el rol");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rol seleccionado ", "alert");
                    }
            }
        }

        catch (Exception i)
        {
            MessageBox.Show("Error = " + i);
        }

                ObtenerDatos();*/
            }
        }
            
                private void UserBt_Click(object sender, EventArgs e)
                {
                    /*try
                    {*/
                        /*using (CrCrudEntities1 db = new CrCrudEntities1())
                        {
                            var listado = from u in db.usuarios
                                          select new { u.id, u.nombre_Completo, u.nombre_Usuario, u.rol };
                            dataGridView1.DataSource = listado.ToList();
                            int? id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                            /* if (id != null)
                                 if (listado.Count() == 1)
                                 {
                                     foreach (var users in listado.ToList())
                                     {
                                         if (users.rol == "user")
                                         {
                                             MessageBox.Show("Selecciono " + users.rol);

                                             Form ver = new Productos_Usuario(id);
                                             ver.Show();

                                             this.Hide();

                                         }
                                         else
                                         {
                                             MessageBox.Show("seleccione el rol");
                                         }
                                     }
                                 }
                                 else
                                 {
                                     MessageBox.Show("Rol seleccionado ", "alert");
                                 }
                         }


                     }
                     catch (Exception i)
                     {
                         MessageBox.Show("Error = " + i);
                     }

                            ObtenerDatos();*/
                        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsuariosPag_Load(object sender, EventArgs e)
        {
            using (CrCrudEntities1 db = new CrCrudEntities1())
            {
                var listado = from u in db.usuarios
                              select new { u.id, u.nombre_Completo, u.nombre_Usuario, u.rol, };
                dataGridView2.DataSource = listado.ToList();
            }
        }
    }


            }
            
        
                    
            
                    
            
            
    

           
    

       

    



