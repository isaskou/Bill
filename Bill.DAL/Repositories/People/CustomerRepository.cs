using Bill.ConnectionTool;
using Bill.DAL.Interfaces.People;
using Bill.DAL.Models.People;
using Bill.DAL.Repositories.RepoBase;
using Bill.DAL.Tools;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill.DAL.Repositories.People
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(IConfiguration config) : base(config)
        {
        }

        public bool Delete(int id)
        {
            Command cmd = new Command("DELETE FROM Customer WHERE Id=@id", false);
            cmd.AddParameters("Id", id);
            return _connection.ExecuteNonQuery(cmd) == 1;
        }

        public IEnumerable<Customer> GetAll()
        {
            Command cmd = new Command("SP_GetAllCustomers", true);
            return _connection.ExecuteReader(cmd, Converter.CustomerConvert);
        }

        public Customer GetOne(int id)
        {
            Command cmd = new Command("SP_GetCustomerById", true);
            cmd.AddParameters("id", id);
            return _connection.ExecuteReader(cmd, Converter.CustomerConvert).FirstOrDefault();
        }

        public int Insert(Customer entity)
        {
            Command cmd = new Command("SP_AddCustomer", true);
            cmd.AddParameters("fn", entity.FirstName);
            cmd.AddParameters("ln", entity.LastName);
            cmd.AddParameters("surname", entity.Surname);
            cmd.AddParameters("company", entity.CompanyName);
            cmd.AddParameters("tva", entity.TVANumber);
            cmd.AddParameters("phone", entity.Phone);
            cmd.AddParameters("mail", entity.Email);
            cmd.AddParameters("adressId", entity.AdressId);

            return (int)_connection.ExecuteScalar(cmd);

        }

        public void Update(Customer entity)
        {
            Command cmd = new Command("SP_UpdateCustomer", true);
            cmd.AddParameters("fn", entity.FirstName);
            cmd.AddParameters("ln", entity.LastName);
            cmd.AddParameters("surname", entity.Surname);
            cmd.AddParameters("company", entity.CompanyName);
            cmd.AddParameters("tva", entity.TVANumber);
            cmd.AddParameters("phone", entity.Phone);
            cmd.AddParameters("mail", entity.Email);
            cmd.AddParameters("adressId", entity.AdressId);

            _connection.ExecuteNonQuery(cmd);
        }
    }
}
