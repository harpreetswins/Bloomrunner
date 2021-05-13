using Admin.Application.DTO.Request;
using Admin.Domain.Models.Admin;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.API.Infrastructure.Mappers.Admin
{
    public class AdminMap : Profile
    {
        public AdminMap()
        {
            CreateMap<AdminDTO, AdminModel>().ReverseMap();
        }
    }
}
