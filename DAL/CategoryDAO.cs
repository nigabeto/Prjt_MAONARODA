using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Objects.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DAL
{
    public class CategoryDAO : PostContext
    {
        public int AddCategory(Category category)
        {
            try
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return category.ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CategoryDTO> GetCategories()
        {
            List<Category> list = db.Categories.Where(x => x.isDeleted == false).OrderBy(x => x.AddDate).ToList();
            List<CategoryDTO> dtolist = new List<CategoryDTO>();
            foreach (var item in list)
            {
                CategoryDTO dto = new CategoryDTO();
                dto.ID = item.ID;
                dto.CategoryName = item.CategoryName;
                dtolist.Add(dto);
            }

            return dtolist;
        }

        public static IEnumerable<SelectListItem> GetCategoriesForDropdown()
        {
            IEnumerable<SelectListItem> categoryList = db.Categories.Where(x => x.isDeleted == false)
                .OrderByDescending(x => x.AddDate).Select(x => new SelectListItem()
                {
                    Text = x.CategoryName, Value = SqlFunctions.StringConvert((double)x.ID)
                }).ToList();
            return categoryList;
        }

        public void UpdateCategory(CategoryDTO model)
        {
            try
            {
                Category cat = db.Categories.First(x => x.ID == model.ID);
                cat.CategoryName = model.CategoryName;
                cat.LastUpdateDate = DateTime.Now;
                cat.LastUpdateUserID = UserStatic.UserID;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Post> DeleteCategory(int ID)
        {
            try
            {
                Category cat = db.Categories.First(x => x.ID == ID);
                cat.isDeleted = true;
                cat.DeletedDate = DateTime.Now;
                cat.LastUpdateDate = DateTime.Now;
                cat.LastUpdateUserID = UserStatic.UserID;
                db.SaveChanges();
                List<Post> postlist = db.Posts.Where(x => x.isDeleted == false && x.CategoryID == ID).ToList();
                return postlist;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public CategoryDTO GetCategoryWithID(int ID)
        {
            try
            {
                Category category = db.Categories.First(x => x.ID == ID);
                CategoryDTO dto = new CategoryDTO();
                dto.ID = category.ID;
                dto.CategoryName = category.CategoryName;
                return dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}