﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContactDAO : PostContext
    {
        public void AddContact(Contact contact)
        {
            db.Contacts.Add(contact);
            db.SaveChanges();
        }

        public List<ContactDTO> GetUnreadMessages()
        {
            List<ContactDTO> dtolist = new List<ContactDTO>();
            List<Contact> list = db.Contacts.Where(x => x.isDeleted == false && x.isRead == false)
                .OrderByDescending(x => x.AddDate).ToList();
            foreach (var item in list)
            {
                ContactDTO dto = new ContactDTO();
                dto.ID = item.ID;
                dto.Name = item.NameSurname;
                dto.Email = item.Email;
                dto.Phone = item.Phone;
                dto.VehiclePlate = item.VehiclePlate;
                dto.VehicleBrand = item.VehicleBrand;
                dto.VehicleModel = item.VehicleModel;
                dto.Year = item.Year;
                dto.ProblemDescription = item.ProblemDescription;
                dto.AddDate = item.AddDate;
                dto.isRead = item.isRead;
                dtolist.Add(dto);
            }

            return dtolist;
        }

        public List<ContactDTO> GetAllMessages()
        {
            List<ContactDTO> dtolist = new List<ContactDTO>();
            List<Contact> list = db.Contacts.Where(x => x.isDeleted == false)
                .OrderByDescending(x => x.AddDate).ToList();
            foreach (var item in list)
            {
                ContactDTO dto = new ContactDTO();
                dto.ID = item.ID;
                dto.Name = item.NameSurname;
                dto.Email = item.Email;
                dto.Phone = item.Phone;
                dto.VehiclePlate = item.VehiclePlate;
                dto.VehicleBrand = item.VehicleBrand;
                dto.VehicleModel = item.VehicleModel;
                dto.Year = item.Year;
                dto.ProblemDescription = item.ProblemDescription;
                dto.AddDate = item.AddDate;
                dto.isRead = item.isRead;
                dtolist.Add(dto);
            }

            return dtolist;
        }

        public void DeleteMessage(int ID)
        {
            Contact contact = db.Contacts.First(x => x.ID == ID);
            contact.isDeleted = true;
            contact.DeletedDate = DateTime.Now;
            contact.LastUpdateDate = DateTime.Now;
            contact.LastUpdateUserID = UserStatic.UserID;
            db.SaveChanges();
        }

        public void ReadMessage(int ID)
        {
            Contact contact = db.Contacts.First(x => x.ID == ID);
            contact.isRead = true;
            contact.ReadUserID = UserStatic.UserID;
            contact.LastUpdateDate = DateTime.Now;
            contact.LastUpdateUserID = UserStatic.UserID;
            db.SaveChanges();
        }
    }
}
