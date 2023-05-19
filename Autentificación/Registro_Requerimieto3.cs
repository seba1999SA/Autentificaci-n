using Autentificación.modelos.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autentificación
{
    public partial class Registro_Requerimieto3 : Form
    {
        public Registro_Requerimieto3()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TipoRequerimiento.Text) || string.IsNullOrEmpty(Asignado.Text))
            {
                MessageBox.Show("Debes completar todos los campos requeridos.");
                return;
            }

            try
            {
                // Crear la conexión a la base de datos
                //using (SqlConnection connection = new SqlConnection(ConnectionString))
                //{
                //    connection.Open();

                //    // Preparar la consulta SQL para insertar los datos en la tabla correspondiente
                //    string query = "INSERT INTO  RequerimientosSet (tipo_de_requerimientoId_Tipo_Req,UsuarioId_Usuario  ) VALUES (@Campo1, @Campo2)";

                //    // Crear el comando SQL
                //    using (SqlCommand command = new SqlCommand(query, connection))
                //    {
                //        // Asignar los valores de los campos a los parámetros del comando
                //        string TipoRequerimientoo = (string)TipoRequerimiento.Text;
                //        string Asignadoa = (string)Asignado.Text;

                //        // Ejecutar el comando SQL
                //        command.ExecuteNonQuery();

                //        // Mostrar mensaje de éxito
                //        MessageBox.Show("Datos guardados correctamente.");
                //    }
                //}
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de fallo en la conexión o consulta SQL
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }
    }
}
