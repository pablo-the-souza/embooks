using System;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public string GetOrders()
        {
            return "This will be a list of orders";
        }

        [HttpGet("{id}")]
        public string GetOrder(Guid Id)
        {
            return "Single Order";
        }
    }
}