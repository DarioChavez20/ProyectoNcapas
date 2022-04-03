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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ContraseñaT.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Loguearse(string usuario, String password)
        {
            try
            {
                using (CrCrudEntities1 db = new CrCrudEntities1())
                {
                    byte[] tmpSource;
                    byte[] tmpHash;
                    tmpSource = ASCIIEncoding.ASCII.GetBytes(password);
                    tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
                    String contrasena = Convert.ToBase64String(tmpHash);
                    var lista = db.usuarios.Where(C => C.nombre_Usuario == usuario && C.Pass == contrasena);

                    if (lista.Count() == 1)
                    {
                        foreach (var Datos in lista.ToList())
                        {
                            if (Datos.rol == "admin")
                            {
                                MessageBox.Show("Bienvenido " + Datos.nombre_Completo);

                               Form home = new Home(Datos.id);
                               home.Show();

                                this.Hide();
                            }
                            else if (Datos.rol == "user")
                            {
                                MessageBox.Show("Bienvenido " + Datos.nombre_Completo);

                                Form home = new Home(Datos.id);
                               home.Show();

                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("No se le ha asignado ningún rol al usuario");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña invalidos ", "alert");
                    }

                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Error = " + i);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            String usuario = Usuario1.Text;
            String password = ContraseñaT.Text;
            Loguearse(usuario, password);
        

        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void Contraseña_Click(object sender, EventArgs e)
        {

        }

        private void Usuario1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContraseñaT_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppF.vista.Registro registro = new AppF.vista.Registro();
            registro.Show();
        }
    }
}
