using Bill.DAL.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill.DAL.Interfaces.People
{
    public interface ICustomerRepository : IRepository<Customer, int>
    {
        

    }
}
