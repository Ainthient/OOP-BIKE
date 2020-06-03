using BIKESobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIKESobj.ApplicationServices.GetPathLocationListUseCase
{
    public class GetBIKESobjListUseCaseRequest : IUseCaseRequest<GetBIKESobjListUseCaseResponse>
    {
        public string PathLocation { get; private set; }
        public long? BIKESobjId { get; private set; }

        private GetBIKESobjListUseCaseRequest()
        { }

        public static GetBIKESobjListUseCaseRequest CreateAllBIKESobjsRequest()
        {
            return new GetBIKESobjListUseCaseRequest();
        }

        public static GetBIKESobjListUseCaseRequest CreateBIKESobjRequest(long bikeobjId)
        {
            return new GetBIKESobjListUseCaseRequest() { BIKESobjId = bikeobjId };
        }
        public static GetBIKESobjListUseCaseRequest CreateBIKESobjsRequest(string pathlocation)
        {
            return new GetBIKESobjListUseCaseRequest() { PathLocation = pathlocation };
        }
    }
}
