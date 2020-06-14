using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw13.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw13.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class ZamowieniaController : ControllerBase
    {
        private readonly ZamowieniaDbService _services;

        public ZamowieniaController(ZamowieniaDbService services)
        {
            _services = services;
        }

        [HttpGet]
        [Route("get/{nazwisko}")]
        public IActionResult GetZamowienie(string nazwisko)
        {

            return Ok(200);
        }
    }
}