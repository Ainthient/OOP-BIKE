using BIKESobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Xunit;
using BIKESobj.ApplicationServices.GetPathLocationListUseCase;
using System.Linq.Expressions;
using BIKESobj.ApplicationServices.Ports;
using BIKESobj.DomainObjects.Ports;
using BIKESobj.ApplicationServices.Repositories;

namespace BIKESobj.WebService.Core.Tests
{
    public class GetBIKESobjListUseCaseTest
    {
        private InMemoryBIKESobjRepository CreateBIKESobjRepository()
        {
            var repo = new InMemoryBIKESobjRepository(new List<bikeobj> {
                new bikeobj { Id = 1, PathWeidth = "Библиотека имени Ленина", Name = "Успенский собор"},
                new bikeobj { Id = 2, PathWeidth = "Библиотека имени Ленина", Name = "Архангельский собор"},
                new bikeobj { Id = 3, PathWeidth = "Библиотека имени Ленина", Name = "Благовещенский собор"},
                new bikeobj { Id = 4, PathWeidth = "Библиотека имени Ленина", Name = "Патриаршие палаты с церковью Двенадцати апостолов"},
            });
            return repo;
        }
        [Fact]
        public void TestGetAllBIKESobj()
        {
            var useCase = new GetBIKESobjListUseCase(CreateBIKESobjRepository());
            var outputPort = new OutputPort();
                        
            Assert.True(useCase.Handle(GetBIKESobjListUseCaseRequest.CreateAllBIKESobjsRequest(), outputPort).Result);
            Assert.Equal<int>(4, outputPort.BIKESobjs.Count());
            Assert.Equal(new long[] { 1, 2, 3, 4 }, outputPort.BIKESobjs.Select(mp => mp.Id));
        }

        [Fact]
        public void TestGetAllBIKESobjsFromEmptyRepository()
        {
            var useCase = new GetBIKESobjListUseCase(new InMemoryBIKESobjRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetBIKESobjListUseCaseRequest.CreateAllBIKESobjsRequest(), outputPort).Result);
            Assert.Empty(outputPort.BIKESobjs);
        }

        [Fact]
        public void TestGetBIKESobj()
        {
            var useCase = new GetBIKESobjListUseCase(CreateBIKESobjRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetBIKESobjListUseCaseRequest.CreateBIKESobjRequest(2), outputPort).Result);
            Assert.Single(outputPort.BIKESobjs, pn => 2 == pn.Id);
        }

        [Fact]
        public void TestTryGetNotExistingBIKESobj()
        {
            var useCase = new GetBIKESobjListUseCase(CreateBIKESobjRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetBIKESobjListUseCaseRequest.CreateBIKESobjRequest(999), outputPort).Result);
            Assert.Empty(outputPort.BIKESobjs);
        }
      
    }

    class OutputPort : IOutputPort<GetBIKESobjListUseCaseResponse>
    {
        public IEnumerable<bikeobj> BIKESobjs { get; private set; }

        public void Handle(GetBIKESobjListUseCaseResponse response)
        {
            BIKESobjs = response.BIKESobjs;
        }
    }
}
