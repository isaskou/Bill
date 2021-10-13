using Bill.DAL.Models.People;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill.DAL.Tools
{
    public static class Converter
    {
        #region People
        public static Customer CustomerConvert(IDataReader reader)
        {
            return new Customer
            {
                Id = (int)reader["Id"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Surname = reader["Surname"].ToString(),
                CompanyName = reader["CompanyName"].ToString(),
                TVANumber = reader["TVANumber"].ToString(),
                Phone = reader["Phone"].ToString(),
                Email = reader["Email"].ToString(),
                AdressId = (int)reader["AdressId"]
            };
        }
        #endregion
    }
}
