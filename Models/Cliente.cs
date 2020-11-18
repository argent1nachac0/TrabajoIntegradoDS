
namespace TPDS2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public int cuit_cuil { get; set; }
        public string domicilio { get; set; }
        public int celular { get; set; }
        public Nullable<int> telefono { get; set; }
        public string email { get; set; }
        public string pais { get; set; }
        public string provincia { get; set; }
        public string localidad { get; set; }
        public int cp { get; set; }
    }
}
