using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RevendedorDTO
    {
        public int RevendedorID { get; set; }

        [Required(ErrorMessage = "Preencher nome do Revendedor!!!")]
        public string DealerName { get; set; }

        [Required(ErrorMessage = "Preencher o Telefone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Preencher o E-mail!!!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencher Data de Cadastro!!!")]
        public DateTime RegistrationDate { get; set; }

        public bool Active { get; set; }
    }
}