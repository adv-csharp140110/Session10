// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcClient;

Console.WriteLine("Hello, World!");


/**
 * https://learn.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start?view=aspnetcore-7.0&tabs=visual-studio
 * Install-Package Grpc.Net.Client
    Install-Package Google.Protobuf
    Install-Package Grpc.Tools
 */

using var channel = GrpcChannel.ForAddress("https://localhost:7055");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "GreeterClient" });
Console.WriteLine("Greeting: " + reply.Message);


var addReply = await client.AddAsync(
                  new CalcRequest { A = 1, B = 5 });
Console.WriteLine("Add: " + addReply.Redsult);


Console.WriteLine("Press any key to exit...");
Console.ReadKey();