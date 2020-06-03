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
        Task AddBIKESobj(bikesobj bikesobj);

        Task RemoveBIKESobj(bikesobj bikesobj);

        Task UpdateBIKESobj(bikesobj bikesobj);

        Task<bikesobj> GetBIKESobj(long id);

        Task<IEnumerable<bikesobj>> GetAllBIKESobjs();

        Task<IEnumerable<bikesobj>> QueryBIKESobjs(Expression<Func<bikesobj, bool>> filter);

    }
}
