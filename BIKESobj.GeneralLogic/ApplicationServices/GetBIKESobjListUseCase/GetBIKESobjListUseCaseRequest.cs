using BIKESobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIKESobj.ApplicationServices.GetLocationListUseCase
{
    public class GetBIKESobjListUseCaseRequest : IUseCaseRequest<GetBIKESobjListUseCaseResponse>
    {
        public string Location { get; private set; }
        public long? BIKESobjId { get; private set; }

        private GetBIKESobjListUseCaseRequest()
        { }

        public static GetBIKESobjListUseCaseRequest CreateAllBIKESobjsRequest()
        {
            return new GetBIKESobjListUseCaseRequest();
        }

        public static GetBIKESobjListUseCaseRequest CreateBIKESobjRequest(long bikesobjId)
        {
            return new GetBIKESobjListUseCaseRequest() { BIKESobjId = bikesobjId };
        }
        public static GetBIKESobjListUseCaseRequest CreateBIKESobjsRequest(string pathlocation)
        {
            return new GetBIKESobjListUseCaseRequest() { Location = pathlocation };
        }
    }
}
