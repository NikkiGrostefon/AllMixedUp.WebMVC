﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllMixedUp.WebMVC.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Index()
        {
            return View();
        }
    }
}