using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace UI.Areas.Admin.Controllers
{
    public class PartsController : BaseController
    {
        // GET: Admin/Parts
        // public ActionResult Index()
        // {
        //     return View();
        // }

        private PartsBLL bll = new PartsBLL();

        public ActionResult AddParts()
        {
            PartsDTO dto = new PartsDTO();
            return View(dto);
        }

        [HttpPost]
        public ActionResult AddParts(PartsDTO model)
        {
            if (ModelState.IsValid)
            {
                if (bll.AddParts(model))
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

            PartsDTO newmodel = new PartsDTO();
            return View(newmodel);
        }

        public ActionResult PartsList()
        {
            List<PartsDTO> model = new List<PartsDTO>();
            model = bll.GetPartsData();
            return View(model);
        }
    }
}