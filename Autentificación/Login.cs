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
        //estamos creando un objeto de tipo Autentificasionb desde la clase Autentificasion
        controladores.Autenticacion Auth =  new controladores.Autenticacion();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //almaseno los datos de los textbox en las variables correo y clave creadas resientemente 
            string correo = txt_correo.Text;
            string clave = txt_clave.Text;

           Auth.AutentificasionDeUsuario(correo, clave);

            
        }
    }
}
