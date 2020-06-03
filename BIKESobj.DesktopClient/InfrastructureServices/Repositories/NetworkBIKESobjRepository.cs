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
        private readonly IDomainObjectsCache<bikesobj> _bikesobjCache;

        public NetworkBIKESobjRepository(string host, ushort port, bool useTls, IDomainObjectsCache<bikesobj> bikesobjCache)
            : base(host, port, useTls)
            => _bikesobjCache = bikesobjCache;

        public async Task<bikesobj> GetBIKESobj(long id)
            => CacheAndReturn(await ExecuteHttpRequest<bikesobj>($"bikesobjs/{id}"));

        public async Task<IEnumerable<bikesobj>> GetAllBIKESobjs()
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<bikesobj>>($"bikesobjs"), allObjects: true);

        public async Task<IEnumerable<bikesobj>> QueryBIKESobjs(ICriteria<bikesobj> criteria)
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<bikesobj>>($"bikesobjs"), allObjects: true)
               .Where(criteria.Filter.Compile());


        private IEnumerable<bikesobj> CacheAndReturn(IEnumerable<bikesobj> bikesobjs, bool allObjects = false)
        {
            if (allObjects)
            {
                _bikesobjCache.ClearCache();
            }
            _bikesobjCache.UpdateObjects(bikesobjs, DateTime.Now.AddDays(1), allObjects);
            return bikesobjs;
        }

        private bikesobj CacheAndReturn(bikesobj bikesobj)
        {
            _bikesobjCache.UpdateObject(bikesobj, DateTime.Now.AddDays(1));
            return bikesobj;
        }
    }
}
