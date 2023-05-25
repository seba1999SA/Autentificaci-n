using Autentificación.controladores;
using controladores;
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
        LlenarComboBox LstReq = new LlenarComboBox();
        ControlGuardarReq guardar = new ControlGuardarReq();
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
            //llenamos combobox prioridad
            cb_Prioridad.Items.Clear();
            cb_Prioridad.Items.Add("Baja");
            cb_Prioridad.Items.Add("Media");
            cb_Prioridad.Items.Add("Alta");

            //llamamos desde la query de TIPO DE REQUERIMIENTO llanamos una lista
            cb_TipoReq.DataSource = LstReq.ListTipoReq();
            cb_TipoReq.ValueMember = "Id_Tipo_Req";
            cb_TipoReq.DisplayMember = "Titulo_de_requerimientos";
            cb_TipoReq.Text = ("Selecciona tipo de requerimiento");

            //llamamos desde la query de ASIGNAR A RESPONSABLE llanamos una lista
            cb_.DataSource = LstReq.ListRol();
            cb_.ValueMember = "ID";
            cb_.DisplayMember = "Nombre_Rol";
            cb_.Text = ("Selecciona rol del encargado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_.Text = ("Selecciona rol del encargado");
            richTextBox1.Text = "";
            cb_TipoReq.Text = ("Selecciona tipo de requerimiento");
            cb_Prioridad.Text = "Asignelo al responsable";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int estadordefault = 2;
       
            int prioridad = cb_Prioridad.SelectedIndex;
            string prio;
            if (prioridad == 1)
            {
                prio = "Baja";
            }
            else if (prioridad == 2)
            {
                prio = "Media";
            }
            else if (prioridad == 3)
            {
                prio = "Alta";
            }
            else
            {
                prio = "";
            }
            if (prio != "" && richTextBox1.Text== "")
            {
                MessageBox.Show(guardar.GuardarReq(richTextBox1.Text, prio, 2, (int)cb_TipoReq.SelectedValue, (int)cb_.SelectedValue));

            }
            else
            {
                MessageBox.Show("No se admiten espacios vacios");
            }
        }
    }
}
