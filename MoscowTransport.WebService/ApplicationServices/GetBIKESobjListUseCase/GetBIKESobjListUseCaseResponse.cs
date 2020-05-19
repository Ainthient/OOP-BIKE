using BIKESobj.DomainObjects;
using BIKESobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIKESobj.ApplicationServices.GetBIKESobjListUseCase
{
    public class GetBIKESobjListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<DomainObjects.BIKESobj> BIKESobj { get; }

        public GetBIKESobjListUseCaseResponse(IEnumerable<DomainObjects.BIKESobj> bikesObj) => BIKESobj = bikesObj;
    }
}
