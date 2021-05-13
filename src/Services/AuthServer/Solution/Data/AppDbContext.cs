using AuthIdentityServer.Models;
using AuthIdentityServer.Models.AccountViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static AuthIdentityServer.Models.AccountViewModels.RegisterDTO;

namespace AuthIdentityServer.data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
       // public DbSet<RegisterDTODerived> AspNetUsers { get; set; }
    }
}
