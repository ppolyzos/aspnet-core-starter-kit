﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StarterKit.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok(new {status = true});
        }
    }
}
