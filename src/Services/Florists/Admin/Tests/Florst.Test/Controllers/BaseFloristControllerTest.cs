using AutoMapper;
using Bloomrunner.Florist.Api.Controllers;
using Florists.Application.Interfaces;
using Florists.Domain.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Florst.Test.Controllers
{
    public abstract class BaseFloristControllerTest
    {
        protected readonly FloristController controller;
        protected readonly IEnumerable<FloristModel> Items;
        protected readonly Mock<IFloristService> MockService;

        protected BaseFloristControllerTest(IEnumerable<FloristModel> items)
        {
            Items = items;
            MockService = new Mock<IFloristService>();
            MockService.Setup(st => st.GetFlorists()).ReturnsAsync(Items);
            controller = new FloristController(MockService.Object);
        }
    }
}
