using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace UI.Areas.Admin.Controllers
{
    public class OrdemController : BaseController
    {
        // GET: Admin/Ordem
        // public ActionResult Index()
        // {
        //     return View();
        // }

        private OrdemBll bll = new OrdemBll();

        public ActionResult AddOrdem()
        {
            OrdemDTO dto = new OrdemDTO();
            return View(dto);
        }

        [HttpPost]
        public ActionResult AddOrdem(OrdemDTO model)
        {
            if (ModelState.IsValid)
            {
                if (bll.AddOrdem(model))
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

            OrdemDTO newmodel = new OrdemDTO();
            return View(newmodel);
        }

        public ActionResult OrdemList()
        {
            List<OrdemDTO> model = new List<OrdemDTO>();
            model = bll.GetOrdemData();
            return View(model);
        }

        public ActionResult UpdateOrdem(int ID)
        {
            OrdemDTO model = new OrdemDTO();
            model = bll.GetOrdemWithID(ID);
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateOrdem(OrdemDTO model)
        {
            if (ModelState.IsValid)
            {
                if (bll.UpdateOrdem(model))
                {
                    ViewBag.ProcessState = General.Messages.UpdateSuccess;
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

            return View(model);
        }

        public JsonResult DeleteOrdem(int ID)
        {
            bll.DeleteOrdem(ID);
            return Json("");
        }
    }
}