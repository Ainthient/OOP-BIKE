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
        private readonly BIKESobjContext _bikesObjContext;

        public BIKESobjEFSqliteGateway(BIKESobjContext bikesObjContext)
            => _bikesObjContext = bikesObjContext;

        public async Task<DomainObjects.BIKESobj> GetBIKESobj(long id)
           => await _bikesObjContext.BIKESobjs.FirstOrDefaultAsync();

        public async Task<IEnumerable<DomainObjects.BIKESobj>> GetAllBIKESobj()
            => await _bikesObjContext.BIKESobjs.ToListAsync();
          
        public async Task<IEnumerable<DomainObjects.BIKESobj>> QueryBIKESobj(Expression<Func<DomainObjects.BIKESobj, bool>> filter)
            => await _bikesObjContext.BIKESobjs.Where(filter).ToListAsync();

        public async Task AddBIKESobj(DomainObjects.BIKESobj bikesObj)
        {
            _bikesObjContext.BIKESobjs.Add(bikesObj);
            await _bikesObjContext.SaveChangesAsync();
        }

        public async Task UpdateBIKESobj(DomainObjects.BIKESobj bikesobj)
        {
            _bikesObjContext.Entry(bikesobj).State = EntityState.Modified;
            await _bikesObjContext.SaveChangesAsync();
        }

        public async Task RemoveBIKESobj(DomainObjects.BIKESobj bikesobj)
        {
            _bikesObjContext.BIKESobjs.Remove(bikesobj);
            await _bikesObjContext.SaveChangesAsync();
        }


       
    }
}
