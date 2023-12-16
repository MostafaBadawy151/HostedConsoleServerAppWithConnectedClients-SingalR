using Microsoft.AspNetCore.SignalR.Client;
using System;
namespace ClientConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:5001/chatHub")
                .Build();

            Connection.StartAsync().Wait();
            Connection.InvokeCoreAsync("SendMessage", args: new[] { "Mostafa", "Hello" });
            Connection.On("ReceiveMessage", (string name, string Message) =>
            {
                Console.WriteLine(name + ":" + Message);
            });
            Console.ReadKey();
        }
    }
}