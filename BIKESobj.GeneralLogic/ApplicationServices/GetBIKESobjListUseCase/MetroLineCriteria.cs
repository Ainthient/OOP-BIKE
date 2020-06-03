using BIKESobj.DomainObjects;
using BIKESobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BIKESobj.ApplicationServices.GetPathLocationListUseCase
{
    public class PathLocationCriteria : ICriteria<bikeobj>
    {
        public string PathLocation { get; }

        public PathLocationCriteria (string pathlocation)
            => PathLocation = pathlocation;

        public Expression<Func<bikeobj, bool>> Filter
            => (b => b.PathWeidth == PathLocation);
    }
}
