using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GRPCServer
{
    public class GameService : Game.GameBase
    {
        private readonly ILogger<GameService> _logger;
        public GameService(ILogger<GameService> logger)
        {
            _logger = logger;
        }


        // public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        public override Task<EvaluateGame> PlayGame(GameRequest request, ServerCallContext context)
        {
            return Task.FromResult(new EvaluateGame
            {
                Message = "Your move: " + request.Move + ". Computer move: SCISSORS"
            });
                
        }
     }
}
