using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controladores
{
    public class ControlAgregarRequerimiento
    {
        //falta insertar base de datos y definir el tu servidor
        string ConnectionString = "Data Source = (local); Initial Catalog = <Base de datos> ; Integrated Security = True";
        public int AgregarReq(string desc, string priori, int a, int b, int c)
        {
            string query = "";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //abrimos conexion a la base de datos
                    connection.Open();
                }
            }
                return 0;
        }
    }
}
