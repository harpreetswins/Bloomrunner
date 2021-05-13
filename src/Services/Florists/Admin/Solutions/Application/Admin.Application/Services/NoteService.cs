using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.DTO.Request;
using Admin.Application.Interfaces;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Application.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;
        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }
        public async Task<CommonResponse> AddNotes(ManageNoteModel manageNoteModel)
        {
            return await _noteRepository.AddNotes(manageNoteModel);
        }
        public async Task<CommonResponse> DeleteNotes(ManageNoteDeleteModel manageNoteDeleteModel)
        {
            return await _noteRepository.DeleteNotes(manageNoteDeleteModel);
        }
        public async Task<IEnumerable<ManageNoteDerivedModel>> GetNotes(ManageNoteSearchModel manageNoteSearchModel)
        {
            return await _noteRepository.GetNotes(manageNoteSearchModel);
        }
    }
}