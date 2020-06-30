using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HueControlBlazorExampleWebApp.Models
{
    public class ConnectedClient
    {
        public string Id { get; }

        public ConnectedClient(string id)
        {
            Id = id;
        }
    }
}
