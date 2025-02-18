using EComDAL.DTOs;
using EComDAL.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EComWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : Controller
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentController(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        [Authorize]
        [HttpGet("GetAllPayment")]
        public async Task<IActionResult> GetAllPayment()
        {
            var result = await _paymentRepository.GetAllPayment();
            if (result == null)
            {
                return NotFound("Payment List is empty");
            }
            return Ok(result);
        }

        [Authorize]
        [HttpGet("GetPaymentById/{Id:int}")]
        public async Task<IActionResult> GetPaymentById(int Id)
        {
            var result = await _paymentRepository.GetPaymentById(Id);
            if (result == null)
            {
                return NotFound("Payment is empty");
            }
            return Ok(result);
        }

        [Authorize]
        [HttpPost("AddPayment")]
        public async Task<IActionResult> AddPayment([FromBody] Paymentdto payment)
        {
            await _paymentRepository.AddPayment(payment);
            return Ok("Payment Added Sucessfully!");
        }

        [Authorize]
        [HttpDelete("DeletePayment/{Id:int}")]
        public async Task<IActionResult> DeletePayment(int Id)
        {
            await _paymentRepository.DeletePayment(Id);
            return Ok("Payment Sucessfully deleted");
        }

        [Authorize]
        [HttpPut("UpdatePayment/{Id:int}")]
        public async Task<IActionResult> UpdatePayment(int Id, Paymentdto payment)
        {
            await _paymentRepository.UpdatePayment(payment, Id);
            return Ok("Payment Updated Sucessfully");
        }

    }
}
