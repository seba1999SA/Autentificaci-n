using Autentificación.modelos.BD;
using ViewModels;
using controladores;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controladores
{
    public class LlenarComboBox
    {
        conn cn = new conn();
        //falta insertar base de datos y definir el tu servidor
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

        public List<RolModel> ListRol()
        {
            List<RolModel> LstRol = new List<RolModel>();
            using (SqlConnection connection = new SqlConnection(cn.connectionS()))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM RolSet", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RolModel ROL = new RolModel();

                    ROL.ID = Convert.ToInt32(reader["ID"]);
                    ROL.Nombre_Rol = Convert.ToString(reader["Nombre_Rol"]);

                    LstRol.Add(ROL);
                }
                reader.Close();
                connection.Close();
            }
            return LstRol;
        }
    }
}
