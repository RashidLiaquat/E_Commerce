using EComDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.DTOs
{
    public class Paymentdto : AuditFieldsdto
    {
        public decimal Amount { get; set; }
        public PaymentType PaymentMethod { get; set; }
        public PaymentStatus Pay_Status { get; set; }
        public string? TranscationId { get; set; }
        public DateTime Payment_Date { get; set; } = DateTime.UtcNow;
        public Currency? Currency_Id { get; set; }
        public string? Remarks { get; set; }
        public User? User_Id { get; set; }
        public Order? Order_Id { get; set; }
    }
}
