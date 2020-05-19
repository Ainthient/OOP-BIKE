using BIKESobj.ApplicationServices.Ports.Gateways.Database;
using BIKESobj.DomainObjects;
using BIKESobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BIKESobj.ApplicationServices.Repositories
{
    public class DbBIKESobjRepository : IReadOnlyBIKESobjRepository,
                                     IBIKESobjRepository
    {
        private readonly IBIKESobjDatabaseGateway _databaseGateway;

        public DbBIKESobjRepository(IBIKESobjDatabaseGateway databaseGateway)
            => _databaseGateway = databaseGateway;

        public async Task<DomainObjects.BIKESobj> GetBIKESobj(long id)
            => await _databaseGateway.GetBIKESobj(id);

        public async Task<IEnumerable<DomainObjects.BIKESobj>> GetAllBIKESobjs()
            => await _databaseGateway.GetAllBIKESobj();

        public async Task<IEnumerable<DomainObjects.BIKESobj>> QueryBIKESobj(ICriteria<DomainObjects.BIKESobj> criteria)
            => await _databaseGateway.QueryBIKESobj(criteria.Filter);

        public async Task AddBIKESobj(DomainObjects.BIKESobj bikesObj)
            => await _databaseGateway.AddBIKESobj(bikesObj);

        public async Task RemoveBIKESobj(DomainObjects.BIKESobj bikesObj)
            => await _databaseGateway.RemoveBIKESobj(bikesObj);

        public async Task UpdateBIKESobj(DomainObjects.BIKESobj bikesObj)
            => await _databaseGateway.UpdateBIKESobj(bikesObj);
    }
}
