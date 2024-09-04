using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PartsDAO : PostContext
    {
        public int AddParts(Part part)
        {
            try
            {
                db.Parts.Add(part);
                db.SaveChanges();
                return part.ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PartsDTO> GetPartsData()
        {
            List<PartsDTO> partslist = new List<PartsDTO>();
            List<Part> list = db.Parts.Where(x => x.isDeleted == false).OrderBy(x => x.AddDate).ToList();
            foreach (var item in list)
            {
                PartsDTO dto = new PartsDTO();
                dto.PartsID = item.ID;
                dto.PartName = item.PartName;
                dto.Manufacturer = item.Manufacturer;
                dto.Value = item.Value;
                partslist.Add(dto);
            }

            return partslist;
        }
    }
}