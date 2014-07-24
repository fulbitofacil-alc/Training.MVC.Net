﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Course.Views.Models;

namespace MVC5Course.Views.Controllers
{
    public class BeerController : Controller
    {
        // GET: Beer
        [HttpPost]
        public ActionResult Index(Beer model)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                return View(model);
            }

            // procesar alta

            return null;
        }
    }
}