using Florist.Service.Test.Data;
using Florist.Service.Test.Data.ClassData;
using Florists.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Florist.Service.Test
{
    public class UpdateFloristTestCases : BaseFloristServiceTest
    {
        public UpdateFloristTestCases()
        {

        }
        [Theory]
        [ClassData(typeof(FloristClassData))]
        public void DeleteFlorist_Must_Return_Integer_Result(int id, FloristUpdateModel model)
        {
            int Response = floristService.UpdateFlorist(id, model).Result;
            Assert.IsType<int>(Response);
        }
    }
}
