using BIKESobj.DomainObjects;
using BIKESobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BIKESobj.ApplicationServices.GetBIKESobjListUseCase
{
    public class LocationCriteria : ICriteria<DomainObjects.BIKESobj>
    {
        public string Location { get; }      /*save filtration criteria*/

        public LocationCriteria(string location) /*get criteria and save as class member*/
            => Location = location;

        public Expression<Func<DomainObjects.BIKESobj, bool>> Filter
            => (bikes => bikes.Location == Location); /*Filter*/
    }
}
