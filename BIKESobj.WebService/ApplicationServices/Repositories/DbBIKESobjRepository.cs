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

        public async Task<bikesobj> GetBIKESobj(long id)
            => await _databaseGateway.GetBIKESobj(id);

        public async Task<IEnumerable<bikesobj>> GetAllBIKESobjs()
            => await _databaseGateway.GetAllBIKESobjs();

        public async Task<IEnumerable<bikesobj>> QueryBIKESobjs(ICriteria<bikesobj> criteria)
            => await _databaseGateway.QueryBIKESobjs(criteria.Filter);

        public async Task AddBIKESobj(bikesobj bikesobj)
            => await _databaseGateway.AddBIKESobj(bikesobj);

        public async Task RemoveBIKESobj(bikesobj bikesobj)
            => await _databaseGateway.RemoveBIKESobj(bikesobj);

        public async Task UpdateBIKESobj(bikesobj bikesobj)
            => await _databaseGateway.UpdateBIKESobj(bikesobj);
    }
}
