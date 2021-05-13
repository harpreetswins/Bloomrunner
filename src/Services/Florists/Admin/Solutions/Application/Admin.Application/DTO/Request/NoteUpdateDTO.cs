namespace Admin.Application.DTO.Request
{
    public class NoteUpdateDTO
    {
        public int AttributeId { get; set; }
        public int NotesType { get; set; }
        public string SourceId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
    }
}