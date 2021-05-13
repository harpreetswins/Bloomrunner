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
    public class PostTestCases : BaseFloristControllerTest
    {
        private new static readonly IEnumerable<FloristModel> Items = MockFloristItems.GetFloristItems();
        public PostTestCases() : base(Items)
        {

        }

        [Fact]
        public async Task Post_Should_Return_OK_Status()
        {
            var DtoModel = new FloristOrderDTO();
            var result = await controller.Post(DtoModel);
            Assert.IsType<OkResult>(result);
        }
    }
}
