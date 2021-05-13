using Bloomrunner.Florist.Application.Services;
using Domain.Core.Bus;
using Florist.Service.Test.Services;
using Florists.Application.Interfaces;
using Florists.Domain.Interfaces;
using Florists.Domain.Models;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Florist.Service.Test
{
    public class BaseFloristServiceTest
    {
        protected readonly IFloristRepository mockFloristService;
        protected readonly FloristService floristService;
        protected readonly Mock<IEventBus> bus;
        public BaseFloristServiceTest()
        {
            mockFloristService = new FloristMockRepository();
            floristService = new FloristService(mockFloristService);
        }
    }
}
