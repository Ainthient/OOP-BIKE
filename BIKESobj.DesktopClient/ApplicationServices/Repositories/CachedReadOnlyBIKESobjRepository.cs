using BIKESobj.ApplicationServices.Ports.Cache;
using BIKESobj.DomainObjects;
using BIKESobj.DomainObjects.Ports;
using BIKESobj.DomainObjects.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BIKESobj.ApplicationServices.Repositories
{
    public class CachedReadOnlyBIKESobjRepository : ReadOnlyBIKESobjRepositoryDecorator
    {
        private readonly IDomainObjectsCache<bikesobj> _bikesobjsCache;

        public CachedReadOnlyBIKESobjRepository(IReadOnlyBIKESobjRepository bikesobjRepository, 
                                             IDomainObjectsCache<bikesobj> bikesobjsCache)
            : base(bikesobjRepository)
            => _bikesobjsCache = bikesobjsCache;

        public async override Task<bikesobj> GetBIKESobj(long id)
            => _bikesobjsCache.GetObject(id) ?? await base.GetBIKESobj(id);

        public async override Task<IEnumerable<bikesobj>> GetAllBIKESobjs()
            => _bikesobjsCache.GetObjects() ?? await base.GetAllBIKESobjs();

        public async override Task<IEnumerable<bikesobj>> QueryBIKESobjs(ICriteria<bikesobj> criteria)
            => _bikesobjsCache.GetObjects()?.Where(criteria.Filter.Compile()) ?? await base.QueryBIKESobjs(criteria);

    }
}
