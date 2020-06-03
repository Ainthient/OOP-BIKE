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

        public async Task<bikeobj> GetBIKESobj(long id)
            => await _databaseGateway.GetBIKESobj(id);

        public async Task<IEnumerable<bikeobj>> GetAllBIKESobjs()
            => await _databaseGateway.GetAllBIKESobjs();

        public async Task<IEnumerable<bikeobj>> QueryBIKESobjs(ICriteria<bikeobj> criteria)
            => await _databaseGateway.QueryBIKESobjs(criteria.Filter);

        public async Task AddBIKESobj(bikeobj bikeobj)
            => await _databaseGateway.AddBIKESobj(bikeobj);

        public async Task RemoveBIKESobj(bikeobj bikeobj)
            => await _databaseGateway.RemoveBIKESobj(bikeobj);

        public async Task UpdateBIKESobj(bikeobj bikeobj)
            => await _databaseGateway.UpdateBIKESobj(bikeobj);
    }
}
