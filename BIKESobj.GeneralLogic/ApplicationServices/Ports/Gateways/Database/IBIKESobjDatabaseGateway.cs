using BIKESobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BIKESobj.ApplicationServices.Ports.Gateways.Database
{
    public interface IBIKESobjDatabaseGateway
    {
        Task AddBIKESobj(bikeobj bikeobj);

        Task RemoveBIKESobj(bikeobj bikeobj);

        Task UpdateBIKESobj(bikeobj bikeobj);

        Task<bikeobj> GetBIKESobj(long id);

        Task<IEnumerable<bikeobj>> GetAllBIKESobjs();

        Task<IEnumerable<bikeobj>> QueryBIKESobjs(Expression<Func<bikeobj, bool>> filter);

    }
}
