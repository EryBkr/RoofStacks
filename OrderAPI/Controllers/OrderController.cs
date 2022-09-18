using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        [HttpGet("{orderId}")]
        public IActionResult Order(int orderId)
        {
            return Ok(new { OrderName = "Example Name", Address = "Istanbul" });
        }
    }
}
