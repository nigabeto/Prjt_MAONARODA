using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AddressDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Preencher o campo Endereço!!!")]
        public string AddressContent { get; set; }

        [Required(ErrorMessage = "Preencher o campo E-mail!!!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencher o campo Telefone!!!")]
        public string Phone { get; set; }

        public string Phone2 { get; set; }
        public string Fax { get; set; }

        [Required(ErrorMessage = "Preencher dados de Mapa amplo!!!")]
        public string LargeMapPath { get; set; }

        [Required(ErrorMessage = "Preencher dados de Mapa reduzido!!!")]
        public string SmallMapPath { get; set; }
    }
}