using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AliController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Ali Asgar";
        }
    }
}