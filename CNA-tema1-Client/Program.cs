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
            var input = new HelloRequest { Name = "Tim" };

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(input);

            Console.WriteLine(reply.Message);
        }
    }
}
