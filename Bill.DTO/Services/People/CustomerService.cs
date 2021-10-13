using Bill.DAL.Interfaces.People;
using Bill.DTO.Interfaces.People;
using Bill.DTO.Mapper.People;
using Bill.DTO.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill.DTO.Services.People
{
    public class CustomerService : ICustomerService
    {
        //private IAdressRepository _adressRepository;
        private ICustomerRepository _customerRepo;

        public CustomerService(ICustomerRepository customerRepo)
        {
            //_adressRepository = adressRepository;
            _customerRepo = customerRepo;
        }

        public bool Delete(int id)
        {
            return _customerRepo.Delete(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerRepo.GetAll().Select(x => x.toDAL());
            //List<Customer> customers = new List<Customer>();
            //foreach (Customer c in _customerRepo.GetAll().Select(x=>x.toDAL()))
            //{
            //    c.Adress = _adressRepository.GetOne(c.AdressId).toDAL();
            //    customers.Add(c);
            //}
            //return customers;
        }

        public Customer GetById(int id)
        {
            return _customerRepo.GetOne(id).toDAL();
        }

        public int Insert(Customer entity)
        {
            return _customerRepo.Insert(entity.toDTO());
        }

        public void Update(Customer entity)
        {
            _customerRepo.Update(entity.toDTO());
        }
    }
}
