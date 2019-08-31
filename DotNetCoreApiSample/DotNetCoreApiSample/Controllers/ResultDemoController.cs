﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreApiSample.Controllers
{
    [Route("api/[controller]")]
    public class ResultDemoController : Controller
    {
        [HttpGet]
        public IActionResult GetUserCode()
        {
            return Ok("oec2003");
        }
    }
}
