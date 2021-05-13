using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using Microsoft.Extensions.Configuration;

namespace Admin.Data.GenericRepository
{
    public class FloristLogoAndColorCodesRepository : GenericRepository, IFloristLogoAndColorCodesRepoditory
    {
        public FloristLogoAndColorCodesRepository(IConfiguration configuration) : base(configuration)
        {

        }
         public async Task<IEnumerable<FloristLogoAndColorCodesModel>> FloristLogoAndColorCodes(FloristLogoandColorSendModel floristLogoandColorSendModel)
        {
            return await Query<FloristLogoAndColorCodesModel>("Pdt.GetFloristLogoAndColorCodes",floristLogoandColorSendModel);
        }
    }
}