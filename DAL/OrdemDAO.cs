using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrdemDAO : PostContext
    {
        public int AddOrdem(Ordem ordem)
        {
            try
            {
                db.Ordems.Add(ordem);
                db.SaveChanges();
                return ordem.ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<OrdemDTO> GetOrdemData()
        {
            List<OrdemDTO> ordemlist = new List<OrdemDTO>();
            List<Ordem> list = db.Ordems.Where(x => x.isDeleted == false).OrderBy(x => x.AddDate).ToList();
            foreach (var item in list)
            {
                OrdemDTO dto = new OrdemDTO();
                dto.OrdemID = item.ID;
                dto.Tipo = item.Tipo;
                dto.Details = item.Details;
                dto.DateBegin = (DateTime)item.DateBegin;
                dto.DateEnd = (DateTime)item.DateEnd;
                dto.TotalValue = (decimal)item.TotalValue;
                dto.Approved = (bool)item.Approved;
                ordemlist.Add(dto);
            }

            return ordemlist;
        }

        public OrdemDTO GetOrdemWithID(int ID)
        {
            Ordem ordem = db.Ordems.First(x => x.ID == ID);
            OrdemDTO dto = new OrdemDTO();
            dto.OrdemID = ordem.ID;
            dto.Tipo = ordem.Tipo;
            dto.Details = ordem.Details;
            dto.DateBegin = (DateTime)ordem.DateBegin;
            dto.DateEnd = (DateTime)ordem.DateEnd;
            dto.TotalValue = (decimal)ordem.TotalValue;
            dto.Approved = (bool)ordem.Approved;
            return dto;
        }

        public void DeleteOrdem(int ID)
        {
            try
            {
                Ordem ordem = db.Ordems.First(x => x.ID==ID);
                ordem.isDeleted = true;
                ordem.DeletedDate = DateTime.Now;
                ordem.LastUpdateDate = DateTime.Now;
                ordem.LastUpdateUserID = UserStatic.UserID;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void UpdateOrdem(OrdemDTO model)
        {
            try
            {
                Ordem ordem = db.Ordems.First(x => x.ID == model.OrdemID);
                ordem.Tipo = model.Tipo;
                ordem.Details = model.Details;
                ordem.DateBegin = ordem.DateBegin;
                ordem.DateEnd = ordem.DateEnd;
                ordem.TotalValue = ordem.TotalValue;
                ordem.Approved = ordem.Approved;
                ordem.LastUpdateDate = DateTime.Now;
                ordem.LastUpdateUserID = UserStatic.UserID;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}