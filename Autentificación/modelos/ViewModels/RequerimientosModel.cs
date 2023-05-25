using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class RequerimientosModel
    {
        public int Id_Requerimiento { get; set; }
        public string Descripcion { get; set; }
        public string Prioridad { get; set; }
        public int Estado_RequerimientoId_Estado { get; set; }
        public int tipo_de_requerimientoId_Tipo_Req { get ; set; }
        public int RolID { get; set; }
    }
}
