using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autentificación
{
    public partial class Login : Form
    {
        Form1 form1 = new Form1();

        //estamos creando un objeto de tipo Autentificacasion desde la clase Autentificasion
        controladores.Autenticacion Auth =  new controladores.Autenticacion();

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
                this.Close();
            }
            else
            {
                MessageBox.Show("Cuenta no valida");
            }
        }

    }
}
