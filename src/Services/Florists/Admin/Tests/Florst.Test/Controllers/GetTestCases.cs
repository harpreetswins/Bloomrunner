using Florists.Domain.Models;
using Florst.Test.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Florst.Test.Controllers
{
    public class GetTestCases : BaseFloristControllerTest
    {
        private static IEnumerable<FloristModel> Items = MockFloristItems.GetFloristItems();
        public GetTestCases() : base(Items)
        {

        }
        [Fact]
        public async Task GetMethodShouldBeOfTypeIEnumerableFloristModel()
        {
            var result = await controller.Get();
            var okObject = Assert.IsType<OkObjectResult>(result);
            Assert.IsAssignableFrom<IEnumerable<FloristModel>>((IEnumerable<FloristModel>)okObject.Value);
        }
        [Fact]
        public async Task GetMethodShouldReturnOkStatus()
        {
            var result = await controller.Get();
            var okObject = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, okObject.StatusCode);
        }
        [Fact]
        public async Task GetMethodShouldReturnList()
        {
            var result = await controller.Get();
            var okObject = Assert.IsType<OkObjectResult>(result);
            var list = Assert.IsAssignableFrom<IEnumerable<FloristModel>>((IEnumerable<FloristModel>)okObject.Value);
            Assert.Equal(2, list.ToList().Count);
        }
    }
}
