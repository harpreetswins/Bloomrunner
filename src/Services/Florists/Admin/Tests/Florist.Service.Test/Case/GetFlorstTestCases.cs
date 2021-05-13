using Florist.Service.Test.Data;
using Florists.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Florist.Service.Test
{
    public class GetFlorstTestCases : BaseFloristServiceTest
    {
        public GetFlorstTestCases()
        {

        }
        [Fact]
        public void GetFlorists_Must_Return_IEnumerable_Type(int id)
        {
            IEnumerable<FloristModel> result = mockFloristService.GetFlorists(id).Result;
            Assert.IsAssignableFrom<IEnumerable<FloristModel>>(result);

        }
        [Fact]
        public void GetFlorists_Must_Return_List(int id)
        {
            IEnumerable<FloristModel> result = mockFloristService.GetFlorists(id).Result;
            Assert.Equal(2, result.ToList().Count);

        }
    }
}
