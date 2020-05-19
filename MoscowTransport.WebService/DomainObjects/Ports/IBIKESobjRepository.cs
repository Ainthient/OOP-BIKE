using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BIKESobj.DomainObjects.Ports
{
    public interface IReadOnlyBIKESobjRepository
    {
        Task<BIKESobj> GetBIKESobj(long id);

        Task<IEnumerable<BIKESobj>> GetAllBIKESobjs();

        Task<IEnumerable<BIKESobj>> QueryBIKESobj(ICriteria<BIKESobj> criteria);

    }

    public interface IBIKESobjRepository
    {
        Task AddBIKESobj(BIKESobj bikesObj);

        Task RemoveBIKESobj(BIKESobj bikesObj);

        Task UpdateBIKESobj(BIKESobj bikesObj);
    }
}
