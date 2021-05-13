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
    public class DeleteTestCases : BaseFloristControllerTest
    {
        private static IEnumerable<FloristModel> Items = MockFloristItems.GetFloristItems();
        public DeleteTestCases() : base(Items)
        {

        }
        [Fact]
        public async Task Delete_Should_Return_OK()
        {
            var DtoModel = new FloristOrderDTO();
            var result = await controller.Post(DtoModel);
            var okObject = Assert.IsType<OkResult>(result);
        }
    }
}
