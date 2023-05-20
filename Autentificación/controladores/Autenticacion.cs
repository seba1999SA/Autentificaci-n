using Autentificación.modelos.BD;
using Autentificación.modelos.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autentificación.controladores
{
    public class Autenticacion
    {
        //linea de conecsion para vase de datos //
        private string ConnectionString = "Data Source = SEBA\\SQLEXPRESS; Initial Catalog = trabajo_nacional; Integrated Security = True";
            
        public string AutentificasionDeUsuario(string Usuario,string Contrasena)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                //se establese la conexion a la base de datos //
                connection.Open();
                //es para aser la consulta a la base de datos y casturar si hay algun poblema//
                    try {
                    SqlCommand cmd1 = new SqlCommand("SELECT Contraseña FROM UsuarioSet WHERE CorreoElectronico = @Usuario", connection);
                    cmd1.Parameters.AddWithValue("@Usuario", Usuario);

                    string vlr = Convert.ToString(cmd1.ExecuteScalar());
                    if (vlr == Contrasena)
                    {
                        respuesta = "ok";
                    }
                    else
                        {
                            respuesta = "Usuario y contraseña no son validos";
                        }
                    }
                //si pongo un try sin su catch me marca error en el codigo//
                    catch(InvalidCastException) {
                        respuesta = "usuario no encontrado";
                    }                       
                   
                connection.Close();
            }
            //es debolver un valor en el caso de aser una operasion (si no quiero debolber algun valor creo una funsion tipo void)
            return respuesta;
        }

        private void uwu()
        {
            using (Model1Container bd = new Model1Container())
            {
                
            }
        }

    }
}
