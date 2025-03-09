
using System.Reflection.Metadata;
using OperationOOP.Core.Models;
using OperationOOP.Core.Data;

namespace OperationOOP.Api.Endpoints
{
    public class CreatePlant : IEndpoint //Endpoint för att skapa växter
    {
        public static void MapEndpoint(IEndpointRouteBuilder app) => app
        .MapPost("/plants", Handle)
        .WithSummary("Creat a new plant");

        public record Request(string Name, string Type);
        public record Response(int id);

        private static Ok<Response> Handle (Request request, IDatabase db)
        {
            //Skapar växter baserat på typval
            Plant plant = request.Type switch
            {
                "Bonsai" => new Bonsai() {Name = request.Name},
                "IndoorPlant" => new IndoorPlant() {Name = request.Name},
                "OutdoorPlant" => new OutdoorPlant() { Name = request.Name},
                _ => throw new ArgumentException("Invalid plant type")
            };
            //Tilldelar ett inikt ID och uppdaterar senaste vattning
            plant.Id = db.Plants.Any() ? db.Plants.Max(p => p.Id) + 1 : 1;
            plant.LastWatered = DateTime.Now;
            db.Plants.Add(plant);
            return TypedResults.Ok( new Response(plant.Id));
        }

    }
}