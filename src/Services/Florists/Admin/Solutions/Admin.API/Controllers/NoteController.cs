using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Admin.API.Infrastructure.CustomMapper;
using Admin.Application.DTO.Request;
using Admin.Application.Interfaces;
using Admin.Domain.Models.Admin;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Admin.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;
        public NoteController(INoteService noteService)
        {
           _noteService = noteService;

        }
        [HttpGet]         
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] ManageNoteSearchModel manageNoteSearchModel)
        {
            var listNote = await _noteService.GetNotes(manageNoteSearchModel);
            return Ok(listNote);
        }
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] ManageNoteDTO model)
        {

           ManageNoteModel Note = new DTOMapper<ManageNoteDTO, ManageNoteModel>().Serialize(model);
           var response = await _noteService.AddNotes(Note);
           
           return Ok(response);
        }
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Delete([FromQuery] ManageNoteDeleteModel manageNoteDeleteModel)
        {
           var response = await _noteService.DeleteNotes(manageNoteDeleteModel);
           return Ok(response);
        }
    }
}