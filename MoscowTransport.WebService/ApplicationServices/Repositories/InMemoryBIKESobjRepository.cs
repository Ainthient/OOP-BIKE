using BIKESobj.DomainObjects;
using BIKESobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BIKESobj.ApplicationServices.Repositories
{
    public class InMemoryBIKESobjRepository : IReadOnlyBIKESobjRepository,
                                             IBIKESobjRepository 
    {
        private readonly List<DomainObjects.BIKESobj> _bikesObjs = new List<DomainObjects.BIKESobj>();

        public InMemoryBIKESobjRepository(IEnumerable<DomainObjects.BIKESobj> bikesObjs = null)
        {
            if (bikesObjs != null)
            {
                _bikesObjs.AddRange(bikesObjs);
            }
        }

        public Task AddBIKESobj(DomainObjects.BIKESobj bikesObj)
        {
            _bikesObjs.Add(bikesObj);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<DomainObjects.BIKESobj>> GetAllBIKESobjs()
        {
            return Task.FromResult(_bikesObjs.AsEnumerable());
        }

        public Task<DomainObjects.BIKESobj> GetBIKESobj(long id)
        {
            return Task.FromResult(_bikesObjs.Where(r => r.Id == id).FirstOrDefault());
        }

        public Task<IEnumerable<DomainObjects.BIKESobj>> QueryBIKESobj(ICriteria<DomainObjects.BIKESobj> criteria)
        {
            return Task.FromResult(_bikesObjs.Where(criteria.Filter.Compile()).AsEnumerable());
        }

        public Task RemoveBIKESobj(DomainObjects.BIKESobj bikesObj)
        {
            _bikesObjs.Remove(bikesObj);
            return Task.CompletedTask;
        }

        public Task UpdateBIKESobj(DomainObjects.BIKESobj bikesObj)
        {
            var foundBIKESobj = GetBIKESobj(bikesObj.Id).Result;
            if (foundBIKESobj == null)
            {
                AddBIKESobj(bikesObj);
            }
            else
            {
                if (foundBIKESobj != bikesObj)
                {
                    _bikesObjs.Remove(foundBIKESobj);
                    _bikesObjs.Add(bikesObj);
                }
            }
            return Task.CompletedTask;
        }
    }
}
