using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LayoutBLL
    {
        private OrdemDAO ordemdao = new OrdemDAO();
        private CategoryDAO categorydao = new CategoryDAO();
        private AddressDAO addressdao = new AddressDAO();
        private PostDAO postdao = new PostDAO();

        public HomeLayoutDTO GetLayoutData()
        {
            HomeLayoutDTO dto = new HomeLayoutDTO();
            dto.Categories = categorydao.GetCategories();
            dto.Ordemlist = ordemdao.GetOrdemData();
            List<AddressDTO> addresslist = addressdao.GetAddresses();
            dto.Address = addresslist.First();
            dto.HotNews = postdao.GetHotNews();
            return dto;

        }
    }
}
