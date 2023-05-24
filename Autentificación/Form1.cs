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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Form login = new Login();

            openPanelForm(login);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Función Desplegar Formulario en Panel Hijo
        private Form activeForm = null;
        public void openPanelForm(Form FormHijo)
        {
            activeForm?.Close();
            activeForm = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(FormHijo);
            FormHijo.Show();
        }
        #endregion

        
    }
}
