using Forms.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AppF.vista
{
    public partial class Registro : Form
    {
        public int? id;
        usuarios lista = null;
        public Registro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LabPass_Click(object sender, EventArgs e)
        {

        }

        private void BTReg_Click(object sender, EventArgs e)
        {
            using (CrCrudEntities1 db = new CrCrudEntities1())
            {
                byte[] tmpSource;
                byte[] tmpHash;
                usuarios lista = new usuarios(); 
                lista.nombre_Usuario = TBUsuario.Text;
                lista.nombre_Completo = TBNombreC.Text;
                tmpSource = ASCIIEncoding.ASCII.GetBytes(TBpass.Text);
                tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
                lista.Pass = Convert.ToBase64String(tmpHash);

                lista.rol = TBrol.Text;

                db.usuarios.Add(lista);
                db.SaveChanges();
                this.Close();
                vista.Login Log = new vista.Login();
            }
        }
    }
}
