using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace GrpcGreeterClient
{
    class Program
    {
        //static async Task Main(string[] args)
        //{
        //    // The port number(5001) must match the port of the gRPC server.
        //    //using var channel = GrpcChannel.ForAddress("https://localhost:5001");
        //    using var channel = GrpcChannel.ForAddress("http://127.0.0.1:50051");
        //    var client = new Greeter.GreeterClient(channel);
        //    var reply = await client.SayHelloAsync(
        //                      new HelloRequest { Name = "GreeterClient" });
        //    Console.WriteLine("Greeting: " + reply.Message);
        //    Console.WriteLine("Press any key to exit...");
        //    Console.ReadKey();
        //}

        static void Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            //using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            using var channel = GrpcChannel.ForAddress("http://127.0.0.1:50051");
            var client = new Helloworld.Greeter.GreeterClient(channel);
            var reply = client.SayHello(
                              new Helloworld.HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
