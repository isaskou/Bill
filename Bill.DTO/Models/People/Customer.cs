using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill.DTO.Models.People
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
        public Adress Adress { get; set; }

        public Customer()
        {
        }

        public Customer(int id, string firstName, string lastName, string surname, string companyName, string tVANumber, string phone, string email, int adressId, Adress adress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Surname = surname;
            CompanyName = companyName;
            TVANumber = tVANumber;
            Phone = phone;
            Email = email;
            AdressId = adressId;
            Adress = adress;
        }
    }
}
