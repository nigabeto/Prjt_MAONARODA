using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ServicoBLL
    {
        private ServicoDAO dao = new ServicoDAO();

        public bool AddServico(ServicoDTO model)
        {
            Servico servico = new Servico();
            servico.ServiceName = model.ServiceName;
            servico.Details = model.Details;
            servico.Value = model.Value;
            servico.Deadline = model.Deadline;
            servico.AddDate = DateTime.Now;
            servico.LastUpdateUserID = UserStatic.UserID;
            servico.LastUpdateDate = DateTime.Now;
            int ServicoID = dao.AddServico(servico);
            LogDAO.AddLog(General.ProcessType.ServicoAdd, General.TableName.Servico, ServicoID);
            return true;
        }

        public List<ServicoDTO> GetServicoData()
        {
            List<ServicoDTO> dtolist = new List<ServicoDTO>();
            dtolist = dao.GetServicoData();
            return dtolist;
        }
    }
}