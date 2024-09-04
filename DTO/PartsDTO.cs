using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PartsDTO
    {
        public int PartsID { get; set; }

        [Required(ErrorMessage = "Preencher o nome da peça!!!")]
        public string PartName { get; set; }

        [Required(ErrorMessage = "Preencher o fabricante!!!")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Preencher o valor da peça!!!")]
        public decimal Value { get; set; }

        [Required(ErrorMessage = "Preencher o prazo de entrega!!!")]
        public string Deadline { get; set; }
    }
}