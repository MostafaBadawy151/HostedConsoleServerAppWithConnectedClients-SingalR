using System;
using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Tasks;
using MVCClientApp.Models;

namespace MVCClientApp.Services
{
    public class ChatService
    {
        private readonly HubConnection _hubConnection;

        public event Action<string, string> MessageReceived;

        public ChatService()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/chatHub")
                .Build();    
        }
        public async Task StartConnection()
        {
            await _hubConnection.StartAsync();
            Console.WriteLine("Hub Connection Started");
        }
        public async Task StopConnection()
        {
            await _hubConnection.StopAsync();
            Console.WriteLine("Hub Connection Stopped");
        }

        public async Task CreateDepartment(Department department)
        {
            await _hubConnection.InvokeAsync("CreateDepartment", department);
        }
    }

}
