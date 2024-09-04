using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RevendedorDAO : PostContext
    {
        public int AddRevendedor(Revendedor revendedor)
        {
            try
            {
                db.Revendedors.Add(revendedor);
                db.SaveChanges();
                return revendedor.ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<RevendedorDTO> GetRevendedorData()
        {
            List<RevendedorDTO> revendedorlist = new List<RevendedorDTO>();
            List<Revendedor> list = db.Revendedors.Where(x => x.isDeleted == false).OrderBy(x => x.AddDate).ToList();
            foreach (var item in list)
            {
                RevendedorDTO dto = new RevendedorDTO();
                dto.RevendedorID = item.ID;
                dto.DealerName = item.DealerName;
                dto.Phone = item.Phone;
                dto.Email = item.Email;
                dto.RegistrationDate = item.RegistrationDate;
                dto.Active = item.Active;
                revendedorlist.Add(dto);
            }

            return revendedorlist;
        }

        public RevendedorDTO GetRevendedorWithID(int ID)
        {
            Revendedor revendedor = db.Revendedors.First(x => x.ID == ID);
            RevendedorDTO dto = new RevendedorDTO();
            dto.RevendedorID = revendedor.ID;
            dto.DealerName = revendedor.DealerName;
            dto.Phone = revendedor.Phone;
            dto.Email = revendedor.Email;
            dto.RegistrationDate = revendedor.RegistrationDate;
            dto.Active = revendedor.Active;
            return dto;
        }

        public void DeleteRevendedor(int ID)
        {
            try
            {
                Revendedor revendedor = db.Revendedors.First(x => x.ID == ID);
                revendedor.isDeleted = true;
                revendedor.DeletedDate = DateTime.Now;
                revendedor.LastUpdateDate = DateTime.Now;
                revendedor.LastUpdateUserID = UserStatic.UserID;
                db.SaveChanges();


            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void UpdateRevendedor(RevendedorDTO model)
        {
            try
            {
                Revendedor revendedor = db.Revendedors.First(x => x.ID == model.RevendedorID);
                revendedor.DealerName = model.DealerName;
                revendedor.Phone = model.Phone;
                revendedor.Email = model.Email;
                revendedor.RegistrationDate = model.RegistrationDate;
                revendedor.Active = model.Active;
                revendedor.LastUpdateUserID = UserStatic.UserID;
                revendedor.LastUpdateDate = DateTime.Now;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}