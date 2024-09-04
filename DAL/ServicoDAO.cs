using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ServicoDAO : PostContext
    {
        public int AddServico(Servico servico)
        {
            try
            {
                db.Servicoes.Add(servico);
                db.SaveChanges();
                return servico.ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ServicoDTO> GetServicoData()
        {
            List<ServicoDTO> servicolist = new List<ServicoDTO>();
            List<Servico> list = db.Servicoes.Where(x => x.isDeleted == false).OrderBy(x => x.AddDate).ToList();
            foreach (var item in list)
            {
                ServicoDTO dto = new ServicoDTO();
                dto.ServicoID = item.ID;
                dto.ServiceName = item.ServiceName;
                dto.Details = item.Details;
                dto.Value = item.Value;
                dto.Deadline = item.Deadline;
                servicolist.Add(dto);
            }

            return servicolist;
        }
    }
}