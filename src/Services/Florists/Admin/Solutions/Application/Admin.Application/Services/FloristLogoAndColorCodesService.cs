using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.DTO.Request;
using Admin.Application.Interfaces;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
namespace Admin.Application.Services
{
    public class FloristLogoAndColorCodesService : IFloristLogoAndColorCodesService
    {
        private readonly IFloristLogoAndColorCodesRepoditory _iFloristLogoAndColorCodesRepoditory;

        public FloristLogoAndColorCodesService(IFloristLogoAndColorCodesRepoditory iFloristLogoAndColorCodesRepoditory)
        {
            _iFloristLogoAndColorCodesRepoditory = iFloristLogoAndColorCodesRepoditory;
           
        }
        public async Task<IEnumerable<FloristLogoAndColorCodesModel>> FloristLogoAndColorCodes(FloristLogoandColorSendModel floristLogoandColorSendModel)
        {
            return await _iFloristLogoAndColorCodesRepoditory.FloristLogoAndColorCodes(floristLogoandColorSendModel);
        }
    }
}