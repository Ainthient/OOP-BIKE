using BIKESobj.DomainObjects;
using BIKESobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIKESobj.ApplicationServices.GetLocationListUseCase
{
    public class GetBIKESobjListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<bikesobj> BIKESobjs { get; }

        public GetBIKESobjListUseCaseResponse(IEnumerable<bikesobj> bikesobjs) => BIKESobjs = bikesobjs;
    }
}
