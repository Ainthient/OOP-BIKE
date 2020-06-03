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
        private readonly IReadOnlyBIKESobjRepository _bikesobjRepository;

        public ReadOnlyBIKESobjRepositoryDecorator(IReadOnlyBIKESobjRepository bikesobjRepository)
        {
            _bikesobjRepository = bikesobjRepository;
        }

        public virtual async Task<IEnumerable<bikesobj>> GetAllBIKESobjs()
        {
            return await _bikesobjRepository?.GetAllBIKESobjs();
        }

        public virtual async Task<bikesobj> GetBIKESobj(long id)
        {
            return await _bikesobjRepository?.GetBIKESobj(id);
        }

        public virtual async Task<IEnumerable<bikesobj>> QueryBIKESobjs(ICriteria<bikesobj> criteria)
        {
            return await _bikesobjRepository?.QueryBIKESobjs(criteria);
        }
    }
}
