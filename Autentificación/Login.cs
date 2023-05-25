using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controladores;

namespace Autentificación
{
    public partial class Login : Form
    {
        //estamos creando un objeto de tipo Autentificacasion desde la clase Autentificasion
        Autenticacion Auth =  new Autenticacion();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //hacemos que los caracteres del textbox de la contraseña se vean solo "*"
            txt_clave.UseSystemPasswordChar = true;

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //almaseno los datos de los textbox en las variables correo y clave creadas resientemente 
            string correo = txt_correo.Text;
            string clave = txt_clave.Text;

            //Comparamos si la respuesta del controlador valida el login o no
            if(Auth.AutentificasionDeUsuario(correo, clave) == true)
            {
                MessageBox.Show("Iniciste sesión");
                var Menu = new FormMenu
                {
                    MinimizeBox = false
                };
                Menu.ShowDialog();

            }
            else
            {
                MessageBox.Show("Cuenta no valida");
            }
        }

    }
}
