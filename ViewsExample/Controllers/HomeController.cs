﻿using Microsoft.AspNetCore.Mvc;

namespace SwitchViewsCoreMVC6.Controllers
{
  public class HomeController : Controller
  {
    [Route("home")]
    [Route("/")]
    public IActionResult Index()
    {
      return View(); //Views/Home/Index.cshtml
      //return View("abc"); //abc.cshtml
      //return new ViewResult() { ViewName = "abc" };
    }
  }
}
