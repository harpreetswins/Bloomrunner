using System;
using System.ComponentModel.DataAnnotations;

namespace Admin.Domain.Models.Admin
{
    public class NoteModel
    {
        public string GlobalNotes { get; set; }       
    }
    public class NoteDParmModel
    {
        public int nid { get; set; }
        public int notestype { get; set; }
        public int sourceid { get; set; }
        public string modifiedBy { get; set; }
        
    }
    public class ManageNoteModel
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public string Notetype { get; set; }
        [Required]
        public int SourceId { get; set; }
        [Required]
        public string Notes { get; set; }
        [Required]
        public string CreatedBy { get; set; }
    }
    public class ManageNoteDerivedModel:ManageNoteModel
    {
        public int NotesId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
    public class ManageNoteDeleteModel 
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public int NotesId { get; set; }
        [Required]
        public string DeletedBy { get; set; }
    }
    public class ManageNoteSearchModel
    {
        [Required]
         public int FloristId { get; set; }
         [Required]
        public int LocationId { get; set; }
        [Required]
        public string Notetype { get; set; }
        public int SourceId { get; set; }
    }
    public class ManageNoteResponse
    {
         [Required]
        public int FloristId { get; set; }
         [Required]
        public int LocationId { get; set; }

    }
}