using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEF2022.Modelos
{
    [Table("Autos")]
    public class Auto
    {
        public int AutoId { get; set; }
        [Required]
        [StringLength(50),MinLength(1)]
        public string MotorCil { get; set; }
        [Required]
        [StringLength(50), MinLength(1)]
        public string Modelo { get; set; }
        [Required]
        [StringLength(50), MinLength(1)]
        public string Marca { get; set; }


    }
}
