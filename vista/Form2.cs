
using Forms.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppF.vista
{
    public partial class Form2 : Form
    {
        public int? id;
        public int ide;
        datos lista = null;
        public Form2(int ide,int? id = null)
        {
            InitializeComponent();
            this.ide = ide;
            this.id = id;
            if (id != null) 
            {
                cargarDatosFormulario();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cargarDatosFormulario() 
        {

            using (CrCrudEntities1 db = new CrCrudEntities1())
            {
                lista = db.datos.Find(id);
                TBprod.Text = lista.producto;
                TBvalor.Text = lista.valor.ToString();
            }
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (CrCrudEntities1 db = new CrCrudEntities1())
            {
                if (id == null)
                {
                     lista = new datos();
                }
                lista.producto = TBprod.Text;
                lista.valor = int.Parse(TBvalor.Text);
                lista.fk_usuarios = ide;
                if (id == null)
                {
                    db.datos.Add(lista);
                }
                else
                {
                    db.Entry(lista).State = System.Data.Entity.EntityState.Modified;
                }
                
                db.SaveChanges();
                this.Close();
            }
        }

        private void LabProd_Click(object sender, EventArgs e)
        {

        }
    }
}

