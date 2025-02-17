using EComDAL.DTOs;
using EComDAL.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EComWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [Authorize]
        [HttpGet("GetAllOrders")]
        public async Task<IActionResult> GetAllOrders()
        {
            var result = await _orderRepository.GetAllOrders();
            if (result == null)
            {
                return NotFound("Order List is empty");
            }
            return Ok(result);
        }

        [Authorize]
        [HttpGet("GetOrderById/{Id:int}")]
        public async Task<IActionResult> GetOrderById(int Id)
        {
            var result = await _orderRepository.GetOrderById(Id);
            if (result == null)
            {
                return NotFound("Order is Not Found");
            }
            return Ok(result);
        }

        [Authorize]
        [HttpPost("AddOrder")]
        public async Task<IActionResult> AddOrder([FromBody] Orderdto orderdto)
        {
            await _orderRepository.AddOrder(orderdto);
            return Ok("Order Sucessfully Added");
        }

        [Authorize]
        [HttpPost("DeleteOrder/{Id:int}")]
        public async Task<IActionResult> DeleteOrder(int Id)
        {
            await _orderRepository.DeleteOrder(Id);
            return Ok("Order Deleted Sucessfully");
        }

        [Authorize]
        [HttpPost("UpdateOrder/{Id:int}")]
        public async Task<IActionResult> UpdateOrder(int Id, Orderdto orderdto)
        {
            await _orderRepository.UpdateOrder(orderdto, Id);
            return Ok("Order Updated Sucessfully");
        }

    }
}
