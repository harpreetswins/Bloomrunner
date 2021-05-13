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
namespace Solution.Controllers
{

    public class ChangePasswordController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;       
        public ChangePasswordController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;            
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return Ok();
        }

       [HttpPost("ChangePassword")]
         public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
         {
             if (ModelState.IsValid)
             {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    return RedirectToAction("Login");
                }
                var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                         ModelState.AddModelError(model.OldPassword, error.Description);
                    }
                     return Ok(result);
                }
               return Ok("1");
            }
            return Ok(model);
        }
    }
}