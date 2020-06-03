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
        private readonly IDomainObjectsCache<bikeobj> _bikeobjsCache;

        public CachedReadOnlyBIKESobjRepository(IReadOnlyBIKESobjRepository bikeobjRepository, 
                                             IDomainObjectsCache<bikeobj> bikeobjsCache)
            : base(bikeobjRepository)
            => _bikeobjsCache = bikeobjsCache;

        public async override Task<bikeobj> GetBIKESobj(long id)
            => _bikeobjsCache.GetObject(id) ?? await base.GetBIKESobj(id);

        public async override Task<IEnumerable<bikeobj>> GetAllBIKESobjs()
            => _bikeobjsCache.GetObjects() ?? await base.GetAllBIKESobjs();

        public async override Task<IEnumerable<bikeobj>> QueryBIKESobjs(ICriteria<bikeobj> criteria)
            => _bikeobjsCache.GetObjects()?.Where(criteria.Filter.Compile()) ?? await base.QueryBIKESobjs(criteria);

    }
}
