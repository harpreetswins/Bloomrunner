using System.Collections.Generic;

namespace Admin.Application.DTO.Request
{
    public class NoteDTO
    {
        public List<Note> GlobalNotes { get; set; } 
    }


    public class Note 
    {
        public string Notes { get; set; }
    }
    public class ManageNoteDTO
    {
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string Notetype { get; set; }
        public int SourceId { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
    }
}