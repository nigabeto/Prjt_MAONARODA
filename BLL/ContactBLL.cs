using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ContactBLL
    {
        private ContactDAO dao = new ContactDAO();
        public bool AddContact(GeneralDTO model)
        {
            Contact contact = new Contact();
            contact.NameSurname = model.Name;
            contact.Email = model.Email;
            contact.Phone = model.Phone;
            contact.VehiclePlate = model.VehiclePlate;
            contact.VehicleBrand = model.VehicleBrand;
            contact.VehicleModel = model.VehicleModel;
            contact.Year = model.Year;
            contact.ProblemDescription = model.ProblemDescription;
            contact.AddDate = DateTime.Now;
            contact.LastUpdateDate = DateTime.Now;
            dao.AddContact(contact);
            return true;
        }

        public List<ContactDTO> GetAllMessages()
        {
            return dao.GetAllMessages();
        }

        public void DeleteMessage(int ID)
        {
            dao.DeleteMessage(ID);
            LogDAO.AddLog(General.ProcessType.ContactDelete, General.TableName.Contact, ID);
        }

        public void ReadMessage(int ID)
        {
            dao.ReadMessage(ID);
            LogDAO.AddLog(General.ProcessType.ContactRead, General.TableName.Contact, ID);
        }

        public List<ContactDTO> GetUnreadMessages()
        {
            return dao.GetUnreadMessages();
        }
    }
}
