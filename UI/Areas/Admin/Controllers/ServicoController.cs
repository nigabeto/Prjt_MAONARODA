using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace UI.Areas.Admin.Controllers
{
    public class ServicoController : BaseController
    {
        // GET: Admin/Servico
        // public ActionResult Index()
        // {
        //     return View();
        // }

        private ServicoBLL bll = new ServicoBLL();

        public ActionResult AddServico()
        {
            ServicoDTO dto = new ServicoDTO();
            return View(dto);
        }

        [HttpPost]
        public ActionResult AddServico(ServicoDTO model)
        {
            if (ModelState.IsValid)
            {
                if (bll.AddServico(model))
                {
                    ViewBag.ProcessState = General.Messages.AddSuccess;
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.ProcessState = General.Messages.GeneralError;
                }
            }
            else
            {
                ViewBag.ProcessState = General.Messages.EmptyArea;
            }

            ServicoDTO newmodel = new ServicoDTO();
            return View(newmodel);
        }

        public ActionResult ServicoList()
        {
            List<ServicoDTO> model = new List<ServicoDTO>();
            model = bll.GetServicoData();
            return View(model);
        }
    }
}