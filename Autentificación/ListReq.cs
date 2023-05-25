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
    public partial class ListReq : Form
    {
        LlenarComboBox LstReq = new LlenarComboBox();

        public ListReq()
        {
            InitializeComponent();
        }

        private void ListReq_Load(object sender, EventArgs e)
        {
            CargarComboBox();           
        }

        private void CargarComboBox()
        {
            //llenamos combobox prioridad
            cb_Prioridad.Items.Clear();
            cb_Prioridad.Items.Add("Baja");
            cb_Prioridad.Items.Add("Media");
            cb_Prioridad.Items.Add("Alta");

            //llamamos desde la query de tipo de requerimiento llanamos una lista
            cb_TipoReq.DataSource = LstReq.ListTipoReq();
            cb_TipoReq.ValueMember = "Id_Tipo_Req";
            cb_TipoReq.DisplayMember = "Titulo_de_requerimientos";
            cb_TipoReq.Text = ("Selecciona tipo de requerimiento");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se liminaron los datos de: " /* + aqui pasar identificador de requerimiento*/ );
        }
    }
}
