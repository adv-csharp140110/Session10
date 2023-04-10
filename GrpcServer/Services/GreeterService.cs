using Google.Protobuf;
using Grpc.Core;
using GrpcServer;

namespace GrpcServer.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
        public override Task<CalcResponse> Add(CalcRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CalcResponse()
            {
                Redsult = request.A + request.B
            });
        }

        public override Task<CalcResponse> Sub(CalcRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CalcResponse()
            {
                Redsult = request.A - request.B
            });
        }

        public override Task<CalcResponse> Mul(CalcRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CalcResponse()
            {
                Redsult = request.A * request.B
            });
        }

        public override Task<CalcResponse> Div(CalcRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CalcResponse()
            {
                Redsult = request.A / request.B
            });
        }
    }
}