//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChaladuradeJabones.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TClientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TClientes()
        {
            this.TPedidos = new HashSet<TPedidos>();
        }
    
        public short ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public short Movil { get; set; }
        public short Telefono { get; set; }
        public string Email { get; set; }
        public string TipoVia { get; set; }
        public string Calle { get; set; }
        public short Numero { get; set; }
        public string Escalera { get; set; }
        public string Piso { get; set; }
        public short CP { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string NFacebook { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TPedidos> TPedidos { get; set; }
    }
}
