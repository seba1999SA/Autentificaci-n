using ViewModels;
using controladores;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autentificación.controladores
{
    public class ControlGuardarReq
    {
        conn cn = new conn();
        public string GuardarReq(string desc, string prio, int estado, int tipo, int rol)
        {
            using (SqlConnection connection = new SqlConnection(cn.connectionS()))
            {
                try
                {
                    connection.Open();

                    // Preparar la consulta SQL para insertar los datos en la tabla correspondiente
                    string consulta = "INSERT INTO RequerimientosSet (Descripcion, Prioridad, Estado, Tipo, Rol) VALUES (@Descripcion, @Prioridad, @Estado, @Tipo, @Rol)";

                    // Crear un objeto SqlCommand para ejecutar la consulta
                    SqlCommand comando = new SqlCommand(consulta, connection);

                    // Agregar parámetros a la consulta
                    comando.Parameters.AddWithValue("@Descripcion", desc);
                    comando.Parameters.AddWithValue("@Prioridad", prio);
                    comando.Parameters.AddWithValue("@Estado", estado);
                    comando.Parameters.AddWithValue("@Tipo", tipo);
                    comando.Parameters.AddWithValue("@Rol", rol);

                    // Ejecutar la consulta
                    comando.ExecuteNonQuery();

                    connection.Close();
                    return "ok";
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    return msg;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
