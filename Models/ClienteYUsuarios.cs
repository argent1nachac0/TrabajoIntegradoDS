using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TPDS2.Models
{
    public class ClienteCE
    {
      
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido { get; set; }
        [Required]
        public int dni { get; set; }
        [Required]
        public int cuit_cuil { get; set; }
        [Required]
        public string domicilio { get; set; }
        public int celular { get; set; }
        [Required]
        public string email { get; set; }
        public string pais { get; set; }
        public string provincia { get; set; }
        public string localidad { get; set; }
        public int cp { get; set; }
    }
    [MetadataType(typeof(ClienteCE))]
    public partial class Cliente
    {
    
    }
}