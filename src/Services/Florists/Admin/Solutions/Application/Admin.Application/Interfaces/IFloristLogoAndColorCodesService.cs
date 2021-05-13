using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.DTO.Request;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Application.Interfaces
{
    public interface IFloristLogoAndColorCodesService
    {
         Task<IEnumerable<FloristLogoAndColorCodesModel>> FloristLogoAndColorCodes(FloristLogoandColorSendModel floristLogoandColorSendModel);
    }
}