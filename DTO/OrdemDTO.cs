using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrdemDTO
    {
        public int OrdemID { get; set; }

        [Required(ErrorMessage = "Por favor informe o tipo de serviço!!!")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Por favor informe o problema apresentado ou serviço desejado!!!")]
        public string Details { get; set; }

        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }

        public decimal TotalValue { get; set; }

        //public bool Aproved { get; set; }
        public bool Approved { get; set; }
    }
}