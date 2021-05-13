using CRM.Application.DTO.Request;
using CRM.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CRM.API.Infrastructure.Mappers.Customer
{
    public class CustomerMap : Profile
    {
        public CustomerMap()
        {
            CreateMap<CustomerDTO, CustomerModel>().ReverseMap();
            // CreateMap<string, List<FloristItems>>().ReverseMap();
        }
    }
}
