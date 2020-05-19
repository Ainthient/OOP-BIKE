using BIKESobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIKESobj.ApplicationServices.GetBIKESobjListUseCase
{
    public class GetBIKESobjListUseCaseRequest : IUseCaseRequest<GetBIKESobjListUseCaseResponse>
    {
        public string Location { get; private set; }
        public long? BIKESobjId { get; private set; }

        private GetBIKESobjListUseCaseRequest()
        { }

        public static GetBIKESobjListUseCaseRequest CreateAllBIKESobjRequest()
        {
            return new GetBIKESobjListUseCaseRequest();
        }

        public static GetBIKESobjListUseCaseRequest CreateBIKESobjRequest(long bikesObjId)
        {
            return new GetBIKESobjListUseCaseRequest() { BIKESobjId = bikesObjId };
        }
        public static GetBIKESobjListUseCaseRequest CreateLocationBIKESobjRequest(string bikesObjs)
        {
            return new GetBIKESobjListUseCaseRequest() { Location = bikesObjs };
        }
    }
}
