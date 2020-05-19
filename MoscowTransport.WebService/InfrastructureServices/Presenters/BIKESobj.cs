using BIKESobj.ApplicationServices.GetBIKESobjListUseCase;
using System.Net;
using Newtonsoft.Json;
using BIKESobj.ApplicationServices.Ports;

namespace BIKESobj.InfrastructureServices.Presenters
{
    public class BIKESobjListPresenter : IOutputPort<GetBIKESobjListUseCaseResponse>
    {
        public JsonContentResult ContentResult { get; }

        public BIKESobjListPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(GetBIKESobjListUseCaseResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.NotFound);
            ContentResult.Content = response.Success ? JsonConvert.SerializeObject(response.BIKESobj) : JsonConvert.SerializeObject(response.Message);
        }
    }
}
