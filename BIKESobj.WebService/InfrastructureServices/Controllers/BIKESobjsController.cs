using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BIKESobj.DomainObjects;
using BIKESobj.ApplicationServices.GetPathLocationListUseCase;
using BIKESobj.InfrastructureServices.Presenters;

namespace BIKESobj.InfrastructureServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BIKESobjsController : ControllerBase
    {
        private readonly ILogger<BIKESobjsController> _logger;
        private readonly IGetBIKESobjListUseCase _getBIKESobjListUseCase;

        public BIKESobjsController(ILogger<BIKESobjsController> logger,
                                IGetBIKESobjListUseCase getBIKESobjListUseCase)
        {
            _logger = logger;
            _getBIKESobjListUseCase = getBIKESobjListUseCase;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllBIKESobjs()
        {
            var presenter = new BIKESobjListPresenter();
            await _getBIKESobjListUseCase.Handle(GetBIKESobjListUseCaseRequest.CreateAllBIKESobjsRequest(), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("{bikeobjId}")]
        public async Task<ActionResult> GetBIKESobj(long bikeobjId)
        {
            var presenter = new BIKESobjListPresenter();
            await _getBIKESobjListUseCase.Handle(GetBIKESobjListUseCaseRequest.CreateBIKESobjRequest(bikeobjId), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("pathlocation/{pathlocation}")]
        public async Task<ActionResult> GetPathLocationBIKESobjs(string pathlocation)
        {
            var presenter = new BIKESobjListPresenter();
            await _getBIKESobjListUseCase.Handle(GetBIKESobjListUseCaseRequest.CreateBIKESobjsRequest(pathlocation), presenter);
            return presenter.ContentResult;
        }
    }
}
