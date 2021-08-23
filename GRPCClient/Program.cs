using System;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace GRPCClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            AppContext.SetSwitch(
                    "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("http://localhost:5000");
            var client = new Game.GameClient(channel);
            Console.WriteLine("ROCK PAPER SCISSORS! Please type your move!");
            var playerMove = Console.ReadLine().ToUpper();
            var reply = await client.PlayGameAsync(
                              new GameRequest { Move = playerMove });
            var computerMove = reply.Message;

            string result;

            if (playerMove == computerMove)
            {
                result = "DRAW";
            }
            else if (
                ( playerMove == "PAPER" && computerMove == "ROCK" ) ||
                ( playerMove == "SCISSORS" && computerMove == "PAPER" ) ||
                ( playerMove == "ROCK" && computerMove == "SCISSORS" )
               )
            {
                result = "WIN";
            }
            else if ( playerMove == "ROCK" || playerMove == "SCISSORS" || playerMove == "PAPER" )
            {
                result = "LOSE";
            }
            else
            {
                result = "INVALID MOVE";
            }

            Console.WriteLine($"Your Move: {playerMove}. Computer Move: {computerMove}. Result: {result}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
