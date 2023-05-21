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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
        }

        #region Función Desplegar Formulario en Panel Hijo
        private Form activeForm = null;
        private void openPanelForm(Form FormHijo)
        {
            activeForm?.Close();
            activeForm = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(FormHijo);
            FormHijo.Show();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //openPanelForm(new ());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openPanelForm(new ListReq());
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
