using System.Threading.Tasks;
using System.Collections.Generic;
using BIKESobj.DomainObjects;
using BIKESobj.DomainObjects.Ports;
using BIKESobj.ApplicationServices.Ports;

namespace BIKESobj.ApplicationServices.GetLocationListUseCase
{
    public class GetBIKESobjListUseCase : IGetBIKESobjListUseCase
    {
        private readonly IReadOnlyBIKESobjRepository _readOnlyBIKESobjRepository;

        public GetBIKESobjListUseCase(IReadOnlyBIKESobjRepository readOnlyBIKESobjRepository) 
            => _readOnlyBIKESobjRepository = readOnlyBIKESobjRepository;
        
        public async Task<bool> Handle(GetBIKESobjListUseCaseRequest request, IOutputPort<GetBIKESobjListUseCaseResponse> outputPort)
        {
            IEnumerable<bikesobj> bikesobjs = null;
            if (request.BIKESobjId != null)
            {
                var bikesobj = await _readOnlyBIKESobjRepository.GetBIKESobj(request.BIKESobjId.Value);
                bikesobjs = (bikesobj != null) ? new List<bikesobj>() { bikesobj } : new List<bikesobj>();
                
            }
            else if (request.Location != null)
            {
                bikesobjs = await _readOnlyBIKESobjRepository.QueryBIKESobjs(new LocationCriteria(request.Location));
            }
            else
            {
                bikesobjs = await _readOnlyBIKESobjRepository.GetAllBIKESobjs();
            }
            outputPort.Handle(new GetBIKESobjListUseCaseResponse(bikesobjs));
            return true;
        }
    }
}
