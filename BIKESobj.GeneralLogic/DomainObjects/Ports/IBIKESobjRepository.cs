using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BIKESobj.DomainObjects.Ports
{
    public interface IReadOnlyBIKESobjRepository
    {
        Task<bikesobj> GetBIKESobj(long id);

        Task<IEnumerable<bikesobj>> GetAllBIKESobjs();

        Task<IEnumerable<bikesobj>> QueryBIKESobjs(ICriteria<bikesobj> criteria);

    }

    public interface IBIKESobjRepository
    {
        Task AddBIKESobj(bikesobj bikesobj);

        Task RemoveBIKESobj(bikesobj bikesobj);

        Task UpdateBIKESobj(bikesobj bikesobj);
    }
}
