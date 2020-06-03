using System.Threading.Tasks;
using System.Collections.Generic;
using BIKESobj.DomainObjects;
using BIKESobj.DomainObjects.Ports;
using BIKESobj.ApplicationServices.Ports;

namespace BIKESobj.ApplicationServices.GetPathLocationListUseCase
{
    public class GetBIKESobjListUseCase : IGetBIKESobjListUseCase
    {
        private readonly IReadOnlyBIKESobjRepository _readOnlyBIKESobjRepository;

        public GetBIKESobjListUseCase(IReadOnlyBIKESobjRepository readOnlyBIKESobjRepository) 
            => _readOnlyBIKESobjRepository = readOnlyBIKESobjRepository;
        
        public async Task<bool> Handle(GetBIKESobjListUseCaseRequest request, IOutputPort<GetBIKESobjListUseCaseResponse> outputPort)
        {
            IEnumerable<bikeobj> bikeobjs = null;
            if (request.BIKESobjId != null)
            {
                var bikeobj = await _readOnlyBIKESobjRepository.GetBIKESobj(request.BIKESobjId.Value);
                bikeobjs = (bikeobj != null) ? new List<bikeobj>() { bikeobj } : new List<bikeobj>();
                
            }
            else if (request.PathLocation != null)
            {
                bikeobjs = await _readOnlyBIKESobjRepository.QueryBIKESobjs(new PathLocationCriteria(request.PathLocation));
            }
            else
            {
                bikeobjs = await _readOnlyBIKESobjRepository.GetAllBIKESobjs();
            }
            outputPort.Handle(new GetBIKESobjListUseCaseResponse(bikeobjs));
            return true;
        }
    }
}
