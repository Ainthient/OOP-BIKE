using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BIKESobj.DomainObjects;
using BIKESobj.ApplicationServices.GetBIKESobjListUseCase;
using BIKESobj.InfrastructureServices.Presenters;

namespace BIKESobj.InfrastructureServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BIKESobjController : ControllerBase
    {
        private readonly ILogger<BIKESobjController> _logger;
        private readonly IGetBIKESobjListUseCase _getBIKESobjListUseCase;

        public BIKESobjController(ILogger<BIKESobjController> logger,
                                IGetBIKESobjListUseCase getBIKESobjListUseCase)
        {
            _logger = logger;
            _getBIKESobjListUseCase = getBIKESobjListUseCase;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllBIKESobj()
        {
            var presenter = new BIKESobjListPresenter();
            await _getBIKESobjListUseCase.Handle(GetBIKESobjListUseCaseRequest.CreateAllBIKESobjRequest(), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("{bikesObjId}")]
        public async Task<ActionResult> GetBIKESobj(long bikesObjId)
        {
            var presenter = new BIKESobjListPresenter();
            await _getBIKESobjListUseCase.Handle(GetBIKESobjListUseCaseRequest.CreateBIKESobjRequest(bikesObjId), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("Locations/{location}")]
        public async Task<ActionResult> GetLocationFilter(string location)
        {
            var presenter = new BIKESobjListPresenter();
            await _getBIKESobjListUseCase.Handle(GetBIKESobjListUseCaseRequest.CreateLocationBIKESobjRequest(location), presenter);
            return presenter.ContentResult;
        }
    }
}
