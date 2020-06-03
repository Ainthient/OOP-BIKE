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
        private readonly List<bikeobj> _bikeobjs = new List<bikeobj>();

        public InMemoryBIKESobjRepository(IEnumerable<bikeobj> bikeobjs = null)
        {
            if (bikeobjs != null)
            {
                _bikeobjs.AddRange(bikeobjs);
            }
        }

        public Task AddBIKESobj(bikeobj bikeobj)
        {
            _bikeobjs.Add(bikeobj);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<bikeobj>> GetAllBIKESobjs()
        {
            return Task.FromResult(_bikeobjs.AsEnumerable());
        }

        public Task<bikeobj> GetBIKESobj(long id)
        {
            return Task.FromResult(_bikeobjs.Where(pn => pn.Id == id).FirstOrDefault());
        }

        public Task<IEnumerable<bikeobj>> QueryBIKESobjs(ICriteria<bikeobj> criteria)
        {
            return Task.FromResult(_bikeobjs.Where(criteria.Filter.Compile()).AsEnumerable());
        }

        public Task RemoveBIKESobj(bikeobj bikeobj)
        {
            _bikeobjs.Remove(bikeobj);
            return Task.CompletedTask;
        }

        public Task UpdateBIKESobj(bikeobj bikeobj)
        {
            var foundBIKESobj = GetBIKESobj(bikeobj.Id).Result;
            if (foundBIKESobj == null)
            {
                AddBIKESobj(bikeobj);
            }
            else
            {
                if (foundBIKESobj != bikeobj)
                {
                    _bikeobjs.Remove(foundBIKESobj);
                    _bikeobjs.Add(bikeobj);
                }
            }
            return Task.CompletedTask;
        }
    }
}
