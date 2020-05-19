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
        Task AddBIKESobj(DomainObjects.BIKESobj bikesObj);

        Task RemoveBIKESobj(DomainObjects.BIKESobj bikesObj);

        Task UpdateBIKESobj(DomainObjects.BIKESobj bikesObj);

        Task<DomainObjects.BIKESobj> GetBIKESobj(long id);

        Task<IEnumerable<DomainObjects.BIKESobj>> GetAllBIKESobj();

        Task<IEnumerable<DomainObjects.BIKESobj>> QueryBIKESobj(Expression<Func<DomainObjects.BIKESobj, bool>> filter);

    }
}
