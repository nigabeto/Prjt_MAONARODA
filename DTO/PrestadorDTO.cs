using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PrestadorDTO
    {
        public int PrestadorID { get; set; }

        [Required(ErrorMessage = "Preencher o campo Nome do Prestador!!!")]
        public string ServerName { get; set; }

        [Required(ErrorMessage = "Preencher o campo Telefone!!!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Preencher o campo E-mail!!!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencher o campo Data de cadastro!!!")]
        public DateTime RegistrationDate { get; set; }

        [Required(ErrorMessage = "Preencher o campo Prestador ativo?!!!")]
        public bool Active { get; set; }
    }
}