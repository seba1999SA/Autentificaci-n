using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autentificación.controladores;

namespace Autentificación
{
    public partial class loqin : Form
    {
        Autenticacion auth = new Autenticacion();
        public int uwu;
        public loqin()
        {
            InitializeComponent();
            test();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuarioo = (string)Usuario.Text;
            string Contrasenaa = (string)Contrasena.Text;
            ;
            if (auth.AutentificasionDeUsuario(Usuarioo, Contrasenaa)=="ok")
            {
                MessageBox.Show("iniciste sesion");

            }
            else
            {
                MessageBox.Show(auth.AutentificasionDeUsuario(Usuarioo, Contrasenaa));


            }
        }
        public int test()
        {
            return 0;
        }
        
    }
}
