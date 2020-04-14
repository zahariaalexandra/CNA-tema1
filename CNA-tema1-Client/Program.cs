using CNA_tema1_Server;
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace CNA_tema1_Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            
            Console.WriteLine("Please insert your name: ");
            string name = Console.ReadLine();
            await client.SayHelloAsync(new HelloRequest { Message = name });

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
