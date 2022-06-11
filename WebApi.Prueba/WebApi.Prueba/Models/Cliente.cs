using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Prueba.Models
{
    public class Cliente
    {
        [Key]
        [StringLength(10)]
        public string CodCliente { get; set; }

        [Required]
        [StringLength(200)]
        public string NombreCompleto { get; set; }

        [Required]
        [StringLength(40)]
        public string NombreCorto { get; set; }

        [Required]
        [StringLength(40)]
        public string Abreviatura { get; set; }

        [Required]
        [StringLength(11)]
        public string RUC { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado { get; set; }

        [StringLength(100)]
        public string GrupoFacturacion { get; set; }

        public DateTime InactivoDesde { get; set; }

        [StringLength(20)]
        public string CodigoSAP { get; set; }
    }
}
