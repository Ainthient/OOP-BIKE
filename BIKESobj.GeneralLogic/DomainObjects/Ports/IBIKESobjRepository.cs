using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BIKESobj.DomainObjects.Ports
{
    public interface IReadOnlyBIKESobjRepository
    {
        Task<bikeobj> GetBIKESobj(long id);

        Task<IEnumerable<bikeobj>> GetAllBIKESobjs();

        Task<IEnumerable<bikeobj>> QueryBIKESobjs(ICriteria<bikeobj> criteria);

    }

    public interface IBIKESobjRepository
    {
        Task AddBIKESobj(bikeobj bikeobj);

        Task RemoveBIKESobj(bikeobj bikeobj);

        Task UpdateBIKESobj(bikeobj bikeobj);
    }
}
