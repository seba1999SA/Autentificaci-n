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
    public partial class panelpadre : Form
    {
        public panelpadre()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //openPanelForm(new Form2());
            Form uwu = new loqin();
            openPanelForm(uwu);
            int hola = uwu.Text();

        }

        #region Función Desplegar Formulario en Panel Hijo
        private Form activeForm = null;
        public void openPanelForm(Form FormHijo)
        {
            activeForm?.Close();
            activeForm = FormHijo;
            FormHijo.TopLevel = false;
            panelChildForm.Controls.Add(FormHijo);
            FormHijo.Show();
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Application.Exit();
        }


    }
}
