using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace UI.Areas.Admin.Controllers
{
    public class PrestadorController : BaseController
    {
        // GET: Admin/Prestador
        // public ActionResult Index()
        // {
        //     return View();
        // }

        private PrestadorBLL bll = new PrestadorBLL();

        public ActionResult AddPrestador()
        {
            PrestadorDTO dto = new PrestadorDTO();
            return View(dto);
        }

        [HttpPost]
        public ActionResult AddPrestador(PrestadorDTO model)
        {
            if (ModelState.IsValid)
            {
                if (bll.AddPrestador(model))
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

            PrestadorDTO newmodel = new PrestadorDTO();
            return View(newmodel);
        }

        public ActionResult PrestadorList()
        {
            List<PrestadorDTO> model = new List<PrestadorDTO>();
            model = bll.GetPrestadorData();
            return View(model);
        }

        public ActionResult UpdatePrestador(int ID)
        {
            PrestadorDTO model = new PrestadorDTO();
            model = bll.GetPrestadorWithID(ID);
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdatePrestador(PrestadorDTO model)
        {
            if (ModelState.IsValid)
            {
                if (bll.UpdatePrestador(model))
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

        public JsonResult DeletePrestador(int ID)
        {
            bll.DeletePrestador(ID);
            return Json("");
        }
    }
}