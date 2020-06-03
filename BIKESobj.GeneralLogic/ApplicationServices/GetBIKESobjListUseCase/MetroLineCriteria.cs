using BIKESobj.DomainObjects;
using BIKESobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BIKESobj.ApplicationServices.GetLocationListUseCase
{
    public class LocationCriteria : ICriteria<bikesobj>
    {
        public string Location { get; }

        public LocationCriteria (string pathlocation)
            => Location = pathlocation;

        public Expression<Func<bikesobj, bool>> Filter
            => (b => b.Width == Location);
    }
}
