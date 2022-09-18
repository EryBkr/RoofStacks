using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class BasketController : ControllerBase
    {
        [HttpGet("{basketId}")]
        public IActionResult Basket(int basketId)
        {
            return Ok(new { BasketName="Example Name",TotalPrice=1500 });
        }
    }
}
