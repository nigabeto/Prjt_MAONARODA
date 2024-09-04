using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PrestadorBLL
    {
        private PrestadorDAO dao = new PrestadorDAO();

        public bool AddPrestador(PrestadorDTO model)
        {
            Prestador prestador = new Prestador();
            prestador.ServerName = model.ServerName;
            prestador.Phone = model.Phone;
            prestador.Email = model.Email;
            prestador.RegistrationDate = model.RegistrationDate;
            prestador.Active = model.Active;
            prestador.AddDate = DateTime.Now;
            prestador.LastUpdateUserID = UserStatic.UserID;
            prestador.LastUpdateDate = DateTime.Now;
            int PrestadorID = dao.AddPrestador(prestador);
            LogDAO.AddLog(General.ProcessType.PrestadorAdd, General.TableName.Prestador, PrestadorID);
            return true;
        }

        public List<PrestadorDTO> GetPrestadorData()
        {
            List<PrestadorDTO> dtolist = new List<PrestadorDTO>();
            dtolist = dao.GetPrestadorData();
            return dtolist;
        }

        public PrestadorDTO GetPrestadorWithID(int ID)
        {
            PrestadorDTO prestadordto = new PrestadorDTO();
            prestadordto = dao.GetPrestadorWithID(ID);
            return prestadordto;
        }

        public bool UpdatePrestador(PrestadorDTO model)
        {
            dao.UpdatePrestador(model);
            LogDAO.AddLog(General.ProcessType.PrestadorUpdate, General.TableName.Prestador, model.PrestadorID);
            return true;
        }

        public void DeletePrestador(int ID)
        {
            dao.DeletePrestador(ID);
            LogDAO.AddLog(General.ProcessType.PrestadorDelete, General.TableName.Prestador, ID);
        }
    }
}