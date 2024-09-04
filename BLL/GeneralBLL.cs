using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class GeneralBLL
    {
        private GeneralDAO dao = new GeneralDAO();
        public GeneralDTO GetAllPosts()
        {
            GeneralDTO dto = new GeneralDTO();
            dto.SliderPost = dao.GetSliderPosts();
            dto.BreakingPost = dao.GetBreakingPosts();
            dto.PopularPost = dao.GetPopularPosts();
            dto.MostViewedPost = dao.GetMostViewedPosts();
            return dto;
        }

        public GeneralDTO GetPostDetailPageItemsWithID(int ID)
        {
            GeneralDTO dto = new GeneralDTO();
            dto.BreakingPost = dao.GetBreakingPosts();
            dto.PostDetail = dao.GetPostDetail(ID);
            return dto;
        }

        private CategoryDAO categorydao = new CategoryDAO();
        public GeneralDTO GetCategoryPostList(string categoryName)
        {
            GeneralDTO dto = new GeneralDTO();
            dto.BreakingPost = dao.GetBreakingPosts();
            //if (categoryName=="video")
            //{
            //    //Não há videos!
            //}
            //else
            //{
                List<CategoryDTO> categorylist = categorydao.GetCategories();
                int categoryID = 0;
                foreach (var item in categorylist)
                {
                    if (categoryName==SeoLink.GenerateUrl(item.CategoryName))
                    {
                        categoryID = item.ID;
                        dto.CategoryName = item.CategoryName;
                        break;
                    }
                }

                dto.CategoryPostList = dao.GetCategoryPostList(categoryID);
            //}

            return dto;
        }

        private AddressDAO addressdao = new AddressDAO();
        public GeneralDTO GetContactPageItems()
        {
           GeneralDTO dto = new GeneralDTO();
            dto.BreakingPost = dao.GetBreakingPosts();
            dto.Address = addressdao.GetAddresses().First();
            return dto;
        }

        public GeneralDTO GetSearchPosts(string searchText)
        {
            GeneralDTO dto = new GeneralDTO();
            dto.BreakingPost = dao.GetBreakingPosts();
            dto.CategoryPostList = dao.GetSearchPost(searchText);
            dto.SearchText = searchText;
            return dto;
        }
    }
}
