﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class SexyGochaController : Controller
    {
        // GET: SexyGocha
        public ActionResult Index()
        {
            StringBuilder str = new StringBuilder();
            return View();
        }


    }
}