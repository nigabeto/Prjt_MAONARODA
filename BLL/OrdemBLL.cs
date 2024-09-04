using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class OrdemBll
    {
        private OrdemDAO dao = new OrdemDAO();

        public bool AddOrdem(OrdemDTO model)
        {
            Ordem ordem = new Ordem();
            ordem.Tipo = model.Tipo;
            ordem.Details = model.Details;
            ordem.DateBegin = model.DateBegin;
            ordem.DateEnd = model.DateEnd;
            ordem.TotalValue = model.TotalValue;
            ordem.Approved = model.Approved;
            ordem.AddDate = DateTime.Now;
            ordem.LastUpdateUserID = UserStatic.UserID;
            ordem.LastUpdateDate = DateTime.Now;
            int OrdemID = dao.AddOrdem(ordem);
            LogDAO.AddLog(General.ProcessType.OrdemAdd, General.TableName.Ordem, OrdemID);
            return true;
        }

        public List<OrdemDTO> GetOrdemData()
        {
            List<OrdemDTO> dtolist = new List<OrdemDTO>();
            dtolist = dao.GetOrdemData();
            return dtolist;
        }

        public OrdemDTO GetOrdemWithID(int ID)
        {
            OrdemDTO ordemdto = new OrdemDTO();
            ordemdto = dao.GetOrdemWithID(ID);
            return ordemdto;
        }

        public bool UpdateOrdem(OrdemDTO model)
        {
            dao.UpdateOrdem(model);
            LogDAO.AddLog(General.ProcessType.OrdemUpdate, General.TableName.Ordem, model.OrdemID);
            return true;
        }

        public void DeleteOrdem(int ID)
        {
            dao.DeleteOrdem(ID);
            LogDAO.AddLog(General.ProcessType.OrdemDelete, General.TableName.Ordem, ID);
        }
    }
}