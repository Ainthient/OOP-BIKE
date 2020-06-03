using BIKESobj.DomainObjects;
using BIKESobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIKESobj.ApplicationServices.GetPathLocationListUseCase
{
    public class GetBIKESobjListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<bikeobj> BIKESobjs { get; }

        public GetBIKESobjListUseCaseResponse(IEnumerable<bikeobj> bikeobjs) => BIKESobjs = bikeobjs;
    }
}
