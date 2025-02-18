using EComDAL.DTOs;
using EComDAL.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EComWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderItemController : Controller
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemController(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

        [Authorize]
        [HttpGet("GetAllOrderItems")]
        public async Task<IActionResult> GetAllOrderItems()
        {
            var result = await _orderItemRepository.GetAllOrderItem();
            if (result == null)
            {
                return NotFound("Order Item List is empty");
            }
            return Ok(result);
        }

        [Authorize]
        [HttpGet("GetOrderItemById/{Id:int}")]
        public async Task<IActionResult> GetOrderItemById(int Id)
        {
            var result = await _orderItemRepository.GetOrderItemById(Id);
            if (result == null)
            {
                return NotFound("Order Item is empty");
            }
            return Ok(result);
        }

        [Authorize]
        [HttpPost("AddOrderItem")]
        public async Task<IActionResult> AddOrderItem([FromBody] OrderItemdto orderItem)
        {
            await _orderItemRepository.AddOrderItem(orderItem);
            return Ok("Order Item Added Sucessfully!");
        }

        [Authorize]
        [HttpDelete("DeleteOrderItem/{Id:int}")]
        public async Task<IActionResult> DeleteOrderItem(int Id)
        {
            await _orderItemRepository.DeleteOrderItem(Id);
            return Ok("Order Item Sucessfully deleted");
        }

        [Authorize]
        [HttpPut("UpdateOrderItem/{Id:int}")]
        public async Task<IActionResult> UpdateOrderItem(int Id, OrderItemdto orderItem)
        {
            await _orderItemRepository.UpdateOrderItem(orderItem, Id);
            return Ok("Order Item Updated Sucessfully");
        }

    }
}
