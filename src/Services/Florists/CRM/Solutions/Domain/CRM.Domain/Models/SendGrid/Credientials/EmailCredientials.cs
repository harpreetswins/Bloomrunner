using System.Configuration;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
namespace CRM.Domain.Models.SendGrid
{
    public class EmailCredientials
    {
        public string ApiKey { get; set; }
        public string SendFrom { get; set; }
        public string UserName { get; set; }
        public Dictionary<string, string> Templates { get; set; }

    }
}
