using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Domain.Interfaces
{
    public interface INoteRepository
    {
      //Task<int> AddNotes(ManageNoteModel manageNoteModel);
        Task<CommonResponse> AddNotes(ManageNoteModel manageNoteModel);
        Task<CommonResponse> DeleteNotes(ManageNoteDeleteModel manageNoteDeleteModel);  
        Task<IEnumerable<ManageNoteDerivedModel>> GetNotes(ManageNoteSearchModel manageNoteSearchModel);  
    }
}