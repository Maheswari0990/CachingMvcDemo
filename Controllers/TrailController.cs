﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CachingMvcDemo.Controllers
{
    public class TrailController : Controller
    {
        // GET: Trail
        public ActionResult Index()
        {
            return View();
        }
    }
}