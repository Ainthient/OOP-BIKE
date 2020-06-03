using BIKESobj.ApplicationServices.Ports.Cache;
using BIKESobj.DomainObjects;
using BIKESobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BIKESobj.InfrastructureServices.Repositories
{
    public class NetworkBIKESobjRepository : NetworkRepositoryBase, IReadOnlyBIKESobjRepository
    {
        private readonly IDomainObjectsCache<bikeobj> _bikeobjCache;

        public NetworkBIKESobjRepository(string host, ushort port, bool useTls, IDomainObjectsCache<bikeobj> bikeobjCache)
            : base(host, port, useTls)
            => _bikeobjCache = bikeobjCache;

        public async Task<bikeobj> GetBIKESobj(long id)
            => CacheAndReturn(await ExecuteHttpRequest<bikeobj>($"bikeobjs/{id}"));

        public async Task<IEnumerable<bikeobj>> GetAllBIKESobjs()
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<bikeobj>>($"bikeobjs"), allObjects: true);

        public async Task<IEnumerable<bikeobj>> QueryBIKESobjs(ICriteria<bikeobj> criteria)
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<bikeobj>>($"bikeobjs"), allObjects: true)
               .Where(criteria.Filter.Compile());


        private IEnumerable<bikeobj> CacheAndReturn(IEnumerable<bikeobj> bikeobjs, bool allObjects = false)
        {
            if (allObjects)
            {
                _bikeobjCache.ClearCache();
            }
            _bikeobjCache.UpdateObjects(bikeobjs, DateTime.Now.AddDays(1), allObjects);
            return bikeobjs;
        }

        private bikeobj CacheAndReturn(bikeobj bikeobj)
        {
            _bikeobjCache.UpdateObject(bikeobj, DateTime.Now.AddDays(1));
            return bikeobj;
        }
    }
}
