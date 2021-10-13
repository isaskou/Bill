using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill.DAL.Models.People
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public string TVANumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int AdressId { get; set; }
    }
}
