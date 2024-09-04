using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ServicoDTO
    {
        public int ServicoID { get; set; }

        [Required(ErrorMessage = "Preencher o nome do serviço!!!")]
        public string ServiceName { get; set; }

        [Required(ErrorMessage = "Descrever detalhes do serviço!!!")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Informar valor do serviço!!!")]
        public decimal Value { get; set; }

        [Required(ErrorMessage = "Informar prazo de conclusão do serviço!!!")]
        public string Deadline { get; set; }
    }
}