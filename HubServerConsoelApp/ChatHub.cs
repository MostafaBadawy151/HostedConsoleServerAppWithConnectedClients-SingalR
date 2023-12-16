using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubServerConsoelApp
{
    public class ChatHub:Hub
    {
        public async Task CreateDepartment(Department department)
        {
            await Clients.All.SendAsync("CreateDepartment", department);
        }
    }
}
