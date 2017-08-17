using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BaseASPCore.Controllers
{
    public class SampleController : Controller
    {
        public SampleController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            throw new NotImplementedException();
        }

    }
}
