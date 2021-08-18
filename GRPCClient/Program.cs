using System;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace GRPCClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5000");
            var client = new Game.GameClient(channel);
            var reply = await client.PlayGameAsync(
                              new GameRequest { Move = "ROCK" });
            Console.WriteLine(reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
