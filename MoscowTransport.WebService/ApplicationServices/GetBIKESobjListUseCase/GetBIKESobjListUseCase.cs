using System.Threading.Tasks;
using System.Collections.Generic;
using BIKESobj.DomainObjects;
using BIKESobj.DomainObjects.Ports;
using BIKESobj.ApplicationServices.Ports;

namespace BIKESobj.ApplicationServices.GetBIKESobjListUseCase
{
    public class GetBIKESobjListUseCase : IGetBIKESobjListUseCase
    {
        private readonly IReadOnlyBIKESobjRepository _readOnlyBIKESobjRepository;

        public GetBIKESobjListUseCase(IReadOnlyBIKESobjRepository readOnlyBIKESobjRepository) 
            => _readOnlyBIKESobjRepository = readOnlyBIKESobjRepository;

        public async Task<bool> Handle(GetBIKESobjListUseCaseRequest request, IOutputPort<GetBIKESobjListUseCaseResponse> outputPort)
        {
            IEnumerable<DomainObjects.BIKESobj> bikesObjs = null;
            if (request.BIKESobjId != null)
            {
                var bikesObj = await _readOnlyBIKESobjRepository.GetBIKESobj(request.BIKESobjId.Value);
                bikesObjs = (bikesObj != null) ? new List<DomainObjects.BIKESobj>() { bikesObj } : new List<DomainObjects.BIKESobj>();
                
            }
            else if (request.Location != null)
            {
                bikesObjs = await _readOnlyBIKESobjRepository.QueryBIKESobj(new LocationCriteria(request.Location));
            }
            else
            {
                bikesObjs = await _readOnlyBIKESobjRepository.GetAllBIKESobjs();
            }
            outputPort.Handle(new GetBIKESobjListUseCaseResponse(bikesObjs));
            return true;
        }
    }
}
