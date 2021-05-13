using Florists.Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Florist.Service.Test.Data.ClassData
{
    public class FloristClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
             //   new FloristModel { Amount = 100, FlowerType = "Lily" }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

