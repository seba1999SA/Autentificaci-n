using Autentificación.modelos.BD;
using ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace controladores
{
    public class ControlMostrarReq
    {
        conn cn = new conn();
        public List<TipoReqModel> ListTipoReq()
        {
            List<TipoReqModel> LstTipo = new List<TipoReqModel>();
            using (SqlConnection connection = new SqlConnection(cn.connectionS()))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tipo_de_requerimientoSet", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TipoReqModel TIPO = new TipoReqModel();

                    TIPO.Id_Tipo_Req = Convert.ToInt32(reader["Id_Tipo_Req"]);
                    TIPO.Titulo_de_requerimientos = Convert.ToString(reader["Titulo_de_requerimientos"]);

                    LstTipo.Add(TIPO);
                }
                reader.Close();
                connection.Close();
            }
            return LstTipo;
        }
    }
}
