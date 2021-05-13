using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AuthIdentityServer.Models;
using AuthIdentityServer.Models.AccountViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AuthIdentityServer.data;
using Microsoft.EntityFrameworkCore;

namespace AuthIdentityServer.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _Context;
        public RegisterController(UserManager<ApplicationUser> userManager, AppDbContext Context)
        {
            _userManager = userManager;
            _Context = Context;
        }

        // [HttpGet]
        // [MapToApiVersion("1.1")]
        // public async Task<ActionResult> Get()
        // {
        //   var Values = await _Context.AspNetUsers.ToListAsync();
        //   return Ok(Values);
        // }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Register(RegisterDTO model)
        {
            var user = new ApplicationUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.FirstName,
                Email = model.Email,
                Country = model.Country,
                State = model.State,
                City = model.City,
                ZipCode = model.ZipCode,
                Street = model.Street,
                ProfileImage = model.ProfileImage
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded) return Ok();
            return Ok();
        }
    }
}