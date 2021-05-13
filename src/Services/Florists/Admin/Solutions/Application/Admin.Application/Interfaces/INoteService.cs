using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Application.Interfaces
{
    public interface INoteService   
    {
        Task<IEnumerable<ManageNoteDerivedModel>> GetNotes(ManageNoteSearchModel manageNoteSearchModel);
        Task<CommonResponse> AddNotes(ManageNoteModel manageNoteModel);
        Task<CommonResponse> DeleteNotes(ManageNoteDeleteModel manageNoteDeleteModel);
    }  
}