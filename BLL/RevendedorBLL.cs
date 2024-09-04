using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class RevendedorBLL
    {
        private RevendedorDAO dao = new RevendedorDAO();

        public bool AddRevendedor(RevendedorDTO model)
        {
            Revendedor revendedor = new Revendedor();
            revendedor.DealerName = model.DealerName;
            revendedor.Phone = model.Phone;
            revendedor.Email = model.Email;
            revendedor.RegistrationDate = model.RegistrationDate;
            revendedor.Active = model.Active;
            revendedor.AddDate = DateTime.Now;
            revendedor.LastUpdateUserID = UserStatic.UserID;
            revendedor.LastUpdateDate = DateTime.Now;
            int RevendedorID = dao.AddRevendedor(revendedor);
            LogDAO.AddLog(General.ProcessType.RevendedorAdd, General.TableName.Revendedor, RevendedorID);
            return true;
        }

        public List<RevendedorDTO> GetRevendedorData()
        {
            List<RevendedorDTO> dtolist = new List<RevendedorDTO>();
            dtolist = dao.GetRevendedorData();
            return dtolist;
        }

        public RevendedorDTO GeteRevendedorWithID(int ID)
        {
            RevendedorDTO revendedordto = new RevendedorDTO();
            revendedordto = dao.GetRevendedorWithID(ID);
            return revendedordto;
        }

        public bool UpdateRevededor(RevendedorDTO model)
        {
            dao.UpdateRevendedor(model);
            LogDAO.AddLog(General.ProcessType.RevendedorUpdate, General.TableName.Revendedor, model.RevendedorID);
            return true;
        }

        public void DeleteRevededor(int ID)
        {
            dao.DeleteRevendedor(ID);
            LogDAO.AddLog(General.ProcessType.RevendedorDelete, General.TableName.Revendedor, ID);

        }
    }
}