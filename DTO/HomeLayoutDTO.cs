using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HomeLayoutDTO
    {
        public List<CategoryDTO> Categories { get; set; }
        public List<OrdemDTO> Ordemlist { get; set; }
        public AddressDTO Address { get; set; }
        public List<PostDTO> HotNews { get; set; }  
    }
}
