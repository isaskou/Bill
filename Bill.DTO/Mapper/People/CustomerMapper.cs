using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using dal = Bill.DAL.Models.People;
using dto = Bill.DTO.Models.People;

namespace Bill.DTO.Mapper.People
{
    public static class CustomerMapper
    {
        public static dto.Customer toDAL(this dal.Customer c)
        {
            return new dto.Customer
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Surname = c.Surname,
                CompanyName = c.CompanyName,
                TVANumber = c.TVANumber,
                Phone = c.Phone,
                Email = c.Email,
                AdressId = c.AdressId

            };
        }

        public static dal.Customer toDTO(this dto.Customer c)
        {
            return new dal.Customer
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Surname = c.Surname,
                CompanyName = c.CompanyName,
                TVANumber = c.TVANumber,
                Phone = c.Phone,
                Email = c.Email,
                AdressId = c.AdressId
            };
        }
    }
}
