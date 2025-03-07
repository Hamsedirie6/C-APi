using OperationOOP.Core.Models;
using OperationOOP.Core.Data;

namespace OperationOOP.Api.Endpoints
{
    public class GetAllPlants : IEndpoint
    {
        public static void MapEndpoint(IEndpointRouteBuilder app) => app
        .MapGet("/plants", Handle)
        .WithSummary("Get all plants");

        public record Response(int id, string Name, DateTime LastWatered, string Type);
        

        private static List<Response> Handle (IDatabase db)
        {
           var plants = db.Plants?.Select(p => new Response(p.Id, p.Name, p.LastWatered, p.GetType().Name))
           .ToList();
           return plants ?? new List<Response>();
        }


    }
}