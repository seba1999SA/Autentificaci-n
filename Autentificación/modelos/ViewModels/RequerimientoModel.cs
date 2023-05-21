using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentificación.modelos.ViewModels
{
    public class RequerimientoModel
    {
        public int Id_Requerimiento { get; set; }
        public string Descripcion { get; set; }
        public string prioridad { get; set; }
        public string Nivel_Complejidad { get; set; }
        public int Estado_RequerimientoId_Estado { get; set; }
        public int tipo_de_requeriemientoId_Tipo_Req { get; set; }
    }
}
