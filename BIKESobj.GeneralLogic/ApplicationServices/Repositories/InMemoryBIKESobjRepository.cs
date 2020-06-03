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
        private readonly List<bikesobj> _bikesobjs = new List<bikesobj>();

        public InMemoryBIKESobjRepository(IEnumerable<bikesobj> bikesobjs = null)
        {
            if (bikesobjs != null)
            {
                _bikesobjs.AddRange(bikesobjs);
            }
        }

        public Task AddBIKESobj(bikesobj bikesobj)
        {
            _bikesobjs.Add(bikesobj);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<bikesobj>> GetAllBIKESobjs()
        {
            return Task.FromResult(_bikesobjs.AsEnumerable());
        }

        public Task<bikesobj> GetBIKESobj(long id)
        {
            return Task.FromResult(_bikesobjs.Where(pn => pn.Id == id).FirstOrDefault());
        }

        public Task<IEnumerable<bikesobj>> QueryBIKESobjs(ICriteria<bikesobj> criteria)
        {
            return Task.FromResult(_bikesobjs.Where(criteria.Filter.Compile()).AsEnumerable());
        }

        public Task RemoveBIKESobj(bikesobj bikesobj)
        {
            _bikesobjs.Remove(bikesobj);
            return Task.CompletedTask;
        }

        public Task UpdateBIKESobj(bikesobj bikesobj)
        {
            var foundBIKESobj = GetBIKESobj(bikesobj.Id).Result;
            if (foundBIKESobj == null)
            {
                AddBIKESobj(bikesobj);
            }
            else
            {
                if (foundBIKESobj != bikesobj)
                {
                    _bikesobjs.Remove(foundBIKESobj);
                    _bikesobjs.Add(bikesobj);
                }
            }
            return Task.CompletedTask;
        }
    }
}
