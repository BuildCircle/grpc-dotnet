# Build Circle Rock Paper Scissors gRPC Kata

## How to run

Begin by building and running the gRPC server. By default this will run on port 5000. This server will be the computer against which you can play. It will generate a move from three options: "ROCK", "PAPER" or "SCISSORS".

Build and run the gRPC client. It is in charge of sending game requests to the server, and will evaluate the result of your game once the server has provided its move. This client is a console app that will ask you for an input. Valid inputs are any variation of "Rock", "Paper" or "Scissors", case-insensitive.
