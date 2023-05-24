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
    public partial class FormAgregarReq : Form
    {
        public FormAgregarReq()
        {
            InitializeComponent();
        }

        private void FormAgregarReq_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
        }

        public void LlenarComboBox()
        {
            cb_Prioridad.Items.Clear();
            cb_Prioridad.Items.Add("Baja");
            cb_Prioridad.Items.Add("Media");
            cb_Prioridad.Items.Add("Alta");
        }
    }
}
