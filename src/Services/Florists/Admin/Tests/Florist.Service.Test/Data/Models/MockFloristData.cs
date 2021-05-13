using Florists.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Florist.Service.Test.Data
{
    public static class MockFloristData
    {
        public static IEnumerable<FloristModel> MockFlorstData()
        {
            IEnumerable<FloristModel> items = new List<FloristModel>()
            {
                //new FloristModel (){ Name="Yellow",Amount=100,FlowerType="Lily",OrderDate=DateTime.Now },
                //new FloristModel (){ Name="Green",Amount=200, FlowerType="Marigold",OrderDate=DateTime.Now }
            };
            return items;
        }
    }
}
