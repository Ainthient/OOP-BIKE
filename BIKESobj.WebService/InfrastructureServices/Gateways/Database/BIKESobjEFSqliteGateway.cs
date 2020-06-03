using BIKESobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using BIKESobj.ApplicationServices.Ports.Gateways.Database;

namespace BIKESobj.InfrastructureServices.Gateways.Database
{
    public class BIKESobjEFSqliteGateway : IBIKESobjDatabaseGateway
    {
        private readonly BIKESobjContext _bikesobjContext;

        public BIKESobjEFSqliteGateway(BIKESobjContext BIKESobjContext)
            => _bikesobjContext = BIKESobjContext;

        public async Task<bikesobj> GetBIKESobj(long id)
           => await _bikesobjContext.BIKESobjs.Where(b => b.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<bikesobj>> GetAllBIKESobjs()
            => await _bikesobjContext.BIKESobjs.ToListAsync();
          
        public async Task<IEnumerable<bikesobj>> QueryBIKESobjs(Expression<Func<bikesobj, bool>> filter)
            => await _bikesobjContext.BIKESobjs.Where(filter).ToListAsync();

        public async Task AddBIKESobj(bikesobj bikesobj)
        {
            _bikesobjContext.BIKESobjs.Add(bikesobj);
            await _bikesobjContext.SaveChangesAsync();
        }

        public async Task UpdateBIKESobj(bikesobj bikesobj)
        {
            _bikesobjContext.Entry(bikesobj).State = EntityState.Modified;
            await _bikesobjContext.SaveChangesAsync();
        }

        public async Task RemoveBIKESobj(bikesobj bikesobj)
        {
            _bikesobjContext.BIKESobjs.Remove(bikesobj);
            await _bikesobjContext.SaveChangesAsync();
        }

    }
}
