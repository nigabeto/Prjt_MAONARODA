using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PartsBLL
    {
        private PartsDAO dao = new PartsDAO();

        public bool AddParts(PartsDTO model)
        {
            Part part = new Part();
            part.PartName = model.PartName;
            part.Manufacturer = model.Manufacturer;
            part.Value = model.Value;
            part.Deadline = model.Deadline;
            part.AddDate = DateTime.Now;
            part.LastUpdateUserID = UserStatic.UserID;
            part.LastUpdateDate = DateTime.Now;
            int PartsID = dao.AddParts(part);
            LogDAO.AddLog(General.ProcessType.PartsAdd, General.TableName.Parts, PartsID);
            return true;
        }

        public List<PartsDTO> GetPartsData()
        {
            List<PartsDTO> dtolist = new List<PartsDTO>();
            dtolist = dao.GetPartsData();
            return dtolist;
        }
    }
}