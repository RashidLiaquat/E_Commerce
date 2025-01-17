using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class User : AuditFields
    {
        public string? Full_Name { get; set; }
        public string? User_Name { get; set; }
        public string? Email { get; set; }
        public string? Phone_Number { get; set; }
        public bool Gender { get; set; }
        public string? Profile_Pic { get; set; }
        public string? Password { get; set; }
        public string? Confirm_Password { get; set; }
        public string? Address { get; set; }
        public Role? Role_Id { get; set; }
        public Country? Country_Id { get; set; }

    }
}
