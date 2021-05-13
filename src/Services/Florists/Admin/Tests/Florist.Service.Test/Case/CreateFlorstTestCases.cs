using Florist.Service.Test.Data;
using Florist.Service.Test.Data.ClassData;
using Florists.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Florist.Service.Test
{
    public class CreateFlorstTestCases : BaseFloristServiceTest
    {
        public CreateFlorstTestCases()
        {

        }

        [Fact]
        public void IsAvailable_Should_Return_True()
        {
            Assert.True(floristService.IsAvailable());
        }
        [Theory]
        [InlineData(5, 5)]
        [InlineData(6, 4)]
        public void Calculation_Must_Return_Appropriate_Result(int a, int b)
        {
            Assert.Equal(10, floristService.Calculation(a, b));
        }
        [Theory]
        [ClassData(typeof(FloristClassData))]
        public void AddFlorist_Must_Return_Integer_Result(FloristModel model)
        {
            int Id = floristService.AddFlorist(model).Result;
            Assert.IsType<int>(Id);
        }


    }
}
