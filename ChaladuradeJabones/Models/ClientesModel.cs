using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChaladuradeJabones.Models
{
    public class ClientesModel
    {

        public short ClienteId  { get; set; }
        public string Nombre { get; set; }
        public string  Apellido1 { get; set; }
        public string Apellido2  { get; set; }
        public int Movil  { get; set; }
        public int Telefono  { get; set; }
        public string Calle { get; set; }
        public int? Numero { get; set; }
        public int? Portal { get; set; }
        public string Escalera  { get; set; }
        public string Piso  { get; set; }
        public int CP { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string NFacebook { get; set; }
}
}