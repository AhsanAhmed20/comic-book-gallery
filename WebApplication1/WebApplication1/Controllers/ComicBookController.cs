﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ComicBookController :Controller
    {
           public ActionResult Detail()
            {
                if(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }

            return Content("Hello from the comic book Controller!");

            }
    }
}