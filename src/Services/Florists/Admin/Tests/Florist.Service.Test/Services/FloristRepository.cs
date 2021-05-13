using Florist.Service.Test.Data;
using Florists.Domain.Interfaces;
using Florists.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Florist.Service.Test.Services
{
    public class FloristMockRepository : IFloristRepository
    {
        public async Task<int> AddFlorist(FloristModel florist)
        {
            await Task.Delay(1000);
            return 1;

        }

        public int Calculation(int a, int b)
        {
            return a + b;
        }

        public async Task<int> DeleteFlorist(int Id)
        {
            await Task.Delay(1000);
            return 1;
        }

        public async Task<IEnumerable<FloristModel>> GetFlorists(int id)
        {
            await Task.Delay(1000);
            return MockFloristData.MockFlorstData();
        }

        public Task<IEnumerable<FloristModel>> GetFlorists()
        {
            throw new NotImplementedException();
        }

        public bool IsAvailable()
        {
            return true;
        }

        public async Task<int> UpdateFlorist(FloristUpdateModel florist)
        {
            await Task.Delay(1000);
            return 1;
        }
    }
}
