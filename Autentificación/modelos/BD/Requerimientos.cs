//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Autentificación.modelos.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Requerimientos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Requerimientos()
        {

        }
    
        public int Id_Requerimiento { get; set; }
        public string Descripcion { get; set; }
        public string Prioridad { get; set; }
        public string Nivel_Complejidad { get; set; }
        public int UsuarioId_Usuario { get; set; }
        public int Estado_RequerimientoId_Estado { get; set; }
        public int tipo_de_requerimientoId_Tipo_Req { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual Estado_Requerimiento Estado_Requerimiento { get; set; }
        public virtual tipo_de_requerimiento tipo_de_requerimiento { get; set; }
    }
}
