using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP.Controllers
{
    public class CalculController : Controller
    {
        // GET: calcul
        public int Addition(int a, int b)
        {
            return a + b;
        }
    }
}