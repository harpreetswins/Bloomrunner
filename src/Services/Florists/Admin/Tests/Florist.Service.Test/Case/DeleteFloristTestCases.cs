using Florist.Service.Test.Data;
using Florist.Service.Test.Data.ClassData;
using Florists.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Florist.Service.Test
{
    public class DeleteFloristTestCases : BaseFloristServiceTest
    {
        public DeleteFloristTestCases()
        {

        }
        [Theory]
        [InlineData(200)]
        public void DeleteFlorist_Must_Return_Integer_Type_Result(int Id)
        {
            var Response = floristService.DeleteFlorist(Id).Result;
            Assert.IsType<int>(Response);
        }
    }
}
