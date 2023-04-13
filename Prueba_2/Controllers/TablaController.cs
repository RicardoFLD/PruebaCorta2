using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Prueba_2.Models;
using Prueba_2.Controllers;
using Prueba_2.Models.ViewModels;

namespace Prueba_2.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            List<ListTablaViewModel> lst;

            using (DestTuristEntities3 db = new DestTuristEntities3())
            {
                lst = (from d in db.Destinos
                          select new ListTablaViewModel
                          {
                              foto=d.foto,
                              Nombre = d.Nombre,
                              Descripcion = d.Descripcion,
                              Precio = (int)d.Precio
                          }).ToList();
            }

            return View(lst);
        }
    }
}