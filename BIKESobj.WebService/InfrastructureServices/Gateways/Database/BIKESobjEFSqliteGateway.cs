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
        private readonly BIKESobjContext _bikeobjContext;

        public BIKESobjEFSqliteGateway(BIKESobjContext BIKESobjContext)
            => _bikeobjContext = BIKESobjContext;

        public async Task<bikeobj> GetBIKESobj(long id)
           => await _bikeobjContext.BIKESobjs.Where(b => b.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<bikeobj>> GetAllBIKESobjs()
            => await _bikeobjContext.BIKESobjs.ToListAsync();
          
        public async Task<IEnumerable<bikeobj>> QueryBIKESobjs(Expression<Func<bikeobj, bool>> filter)
            => await _bikeobjContext.BIKESobjs.Where(filter).ToListAsync();

        public async Task AddBIKESobj(bikeobj bikeobj)
        {
            _bikeobjContext.BIKESobjs.Add(bikeobj);
            await _bikeobjContext.SaveChangesAsync();
        }

        public async Task UpdateBIKESobj(bikeobj bikeobj)
        {
            _bikeobjContext.Entry(bikeobj).State = EntityState.Modified;
            await _bikeobjContext.SaveChangesAsync();
        }

        public async Task RemoveBIKESobj(bikeobj bikeobj)
        {
            _bikeobjContext.BIKESobjs.Remove(bikeobj);
            await _bikeobjContext.SaveChangesAsync();
        }

    }
}
