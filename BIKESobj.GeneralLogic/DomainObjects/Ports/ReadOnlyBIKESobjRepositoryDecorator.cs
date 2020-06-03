using BIKESobj.DomainObjects;
using BIKESobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BIKESobj.DomainObjects.Repositories
{
    public abstract class ReadOnlyBIKESobjRepositoryDecorator : IReadOnlyBIKESobjRepository
    {
        private readonly IReadOnlyBIKESobjRepository _bikeobjRepository;

        public ReadOnlyBIKESobjRepositoryDecorator(IReadOnlyBIKESobjRepository bikeobjRepository)
        {
            _bikeobjRepository = bikeobjRepository;
        }

        public virtual async Task<IEnumerable<bikeobj>> GetAllBIKESobjs()
        {
            return await _bikeobjRepository?.GetAllBIKESobjs();
        }

        public virtual async Task<bikeobj> GetBIKESobj(long id)
        {
            return await _bikeobjRepository?.GetBIKESobj(id);
        }

        public virtual async Task<IEnumerable<bikeobj>> QueryBIKESobjs(ICriteria<bikeobj> criteria)
        {
            return await _bikeobjRepository?.QueryBIKESobjs(criteria);
        }
    }
}
