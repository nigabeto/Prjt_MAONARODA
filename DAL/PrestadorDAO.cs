using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PrestadorDAO : PostContext
    {
        public int AddPrestador(Prestador prestador)
        {
            try
            {
                db.Prestadors.Add(prestador);
                db.SaveChanges();
                return prestador.ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PrestadorDTO> GetPrestadorData()
        {
            List<PrestadorDTO> prestadorlist = new List<PrestadorDTO>();
            List<Prestador> list = db.Prestadors.Where(x => x.isDeleted == false).OrderBy(x => x.AddDate).ToList();
            foreach (var item in list)
            {
                PrestadorDTO dto = new PrestadorDTO();
                dto.PrestadorID = item.ID;
                dto.ServerName = item.ServerName;
                dto.Phone = item.Phone;
                dto.Email = item.Email;
                dto.RegistrationDate = item.RegistrationDate;
                dto.Active = item.Active;
                prestadorlist.Add(dto);
            }

            return prestadorlist;
        }

        public PrestadorDTO GetPrestadorWithID(int ID)
        {
            Prestador prestador = db.Prestadors.First(x => x.ID == ID);
            PrestadorDTO dto = new PrestadorDTO();
            dto.PrestadorID = prestador.ID;
            dto.ServerName = prestador.ServerName;
            dto.Phone = prestador.Phone;
            dto.Email = prestador.Email;
            dto.RegistrationDate = prestador.RegistrationDate;
            dto.Active = prestador.Active;
            return dto;
        }

        public void DeletePrestador(int ID)
        {
            try
            {
                Prestador prestador = db.Prestadors.First(x => x.ID == ID);
                prestador.isDeleted = true;
                prestador.DeletedDate = DateTime.Now;
                prestador.LastUpdateDate = DateTime.Now;
                prestador.LastUpdateUserID = UserStatic.UserID;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void UpdatePrestador(PrestadorDTO model)
        {
            try
            {
                Prestador prestador = db.Prestadors.First(x => x.ID == model.PrestadorID);
                prestador.ServerName = model.ServerName;
                prestador.Phone = model.Phone;
                prestador.Email = model.Email;
                prestador.RegistrationDate = model.RegistrationDate;
                prestador.Active = model.Active;
                prestador.LastUpdateDate = DateTime.Now;
                prestador.LastUpdateUserID = UserStatic.UserID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}