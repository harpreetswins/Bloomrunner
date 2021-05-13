using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models.Admin;

namespace Admin.Domain.Interfaces
{
    public interface IFloristLogoAndColorCodesRepoditory
    {
          Task<IEnumerable<FloristLogoAndColorCodesModel>> FloristLogoAndColorCodes(FloristLogoandColorSendModel floristLogoandColorSendModel);
    }
}