using Bloomrunner.Florist.Application.DTO.Request;
using Florists.Domain.Models;
using Florst.Test.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Florst.Test.Controllers
{
    public class UpdateTestCases : BaseFloristControllerTest
    {
        private static IEnumerable<FloristModel> Items = MockFloristItems.GetFloristItems();
        public UpdateTestCases() : base(Items)
        {

        }
        //not found
        [Fact]
        public async Task Put_Should_Return_OK()
        {
            var DtoModel = new FloristOrderDTO();
            var result = await controller.Post(DtoModel);
            var okObject = Assert.IsType<OkResult>(result);
        }
    }
}
