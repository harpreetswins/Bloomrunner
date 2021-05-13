using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using Microsoft.Extensions.Configuration;

namespace Admin.Data.GenericRepository
{
    public class NoteReposiory : GenericRepository, INoteRepository
    {
        public NoteReposiory(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<CommonResponse> AddNotes(ManageNoteModel manageNoteModel)
        {
            return await ExecuteAll<CommonResponse>("Glo.AddManageNotes", manageNoteModel);
        }
        public async Task<CommonResponse> DeleteNotes(ManageNoteDeleteModel manageNoteDeleteModel)
        {
            return await ExecuteAll<CommonResponse>("Glo.DeleteManageNotes", manageNoteDeleteModel);
        }
        public async Task<IEnumerable<ManageNoteDerivedModel>> GetNotes(ManageNoteSearchModel manageNoteSearchModel)
        {
            return await Query<ManageNoteDerivedModel>("Glo.GetManageNotes", manageNoteSearchModel);
        }
    }
}