using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill.DAL.Interfaces
{
    public interface IRepository<Tentity, Tid> : 
        IInsertRepository<Tentity, Tid>,
        IGetAllRepository<Tentity>,
        IGetOneRepository<Tentity, Tid>,
        IUpdateRepository<Tentity>,
        IDeleteRepository<Tid>

        where Tentity: class
        where Tid:struct
    {
    }

    public interface IDeleteRepository<Tid>
    {
        bool Delete(Tid id);
    }

    public interface IUpdateRepository<Tentity>
    {
        void Update(Tentity entity);
    }

    public interface IGetOneRepository<Tentity, Tid>
    {
        Tentity GetOne(Tid id);
    }

    public interface IGetAllRepository<Tentity>
    {
        IEnumerable<Tentity> GetAll();
    }

    public interface IInsertRepository<Tentity, Tid>
    {
        Tid Insert(Tentity entity);
    }
}
