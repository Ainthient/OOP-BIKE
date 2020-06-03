using System;
using System.Collections.Generic;
using System.Text;
using BIKESobj.ApplicationServices.Interfaces;

namespace BIKESobj.ApplicationServices.GetLocationListUseCase
{
    public interface IGetBIKESobjListUseCase 
        : IUseCase<GetBIKESobjListUseCaseRequest, GetBIKESobjListUseCaseResponse>
    {
    }
}
