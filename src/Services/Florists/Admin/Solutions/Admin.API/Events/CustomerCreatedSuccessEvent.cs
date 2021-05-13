using Admin.Application.DTO.Request;
using BuildingBlocks.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.API.Events
{
    [MessageNamespace("adminqueue")]
    public class CustomerCreatedSuccessEvent : IEvent
    {
        public Guid _Id { get; set; }
        public int _StaffId { get; set; }
        public CustomerCreatedSuccessEvent(Guid Id, int staffId)
        {
            _Id = Id;
            _StaffId = staffId;
        }
    }
}
