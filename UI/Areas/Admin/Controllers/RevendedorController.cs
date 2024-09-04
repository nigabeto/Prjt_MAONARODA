using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace UI.Areas.Admin.Controllers
{
    public class RevendedorController : BaseController
    {
        // GET: Admin/Revendedor
        // public ActionResult Index()
        // {
        //     return View();
        // }

        private RevendedorBLL bll = new RevendedorBLL();

        public ActionResult AddRevendedor()
        {
            RevendedorDTO dto = new RevendedorDTO();
            return View(dto);
        }

        [HttpPost]
        public ActionResult AddRevendedor(RevendedorDTO model)
        {
            if (ModelState.IsValid)
            {
                if (bll.AddRevendedor(model))
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

            RevendedorDTO newmodel = new RevendedorDTO();
            return View(newmodel);
        }

        public ActionResult RevendedorList()
        {
            List<RevendedorDTO> model = new List<RevendedorDTO>();
            model = bll.GetRevendedorData();
            return View(model);
        }

        public ActionResult UpdateRevendedor(int ID)
        {
            RevendedorDTO model = new RevendedorDTO();
            model = bll.GeteRevendedorWithID(ID);
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateRevendedor(RevendedorDTO model)
        {
            if (ModelState.IsValid)
            {
                if (bll.UpdateRevededor(model))
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

        public JsonResult DeleteRevendedor(int ID)
        {
            bll.DeleteRevededor(ID);
            return Json("");
        }
    }
}