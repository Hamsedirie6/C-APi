

namespace OperationOOP.Api.Endpoints
{
    public class GetPlantsByCarelevel : IEndpoint
    {
        public static void MapEndpoint(IEndpointRouteBuilder app) => app
        .MapGet("plants/CareLevel/{CareLevel}", Handle)
        .WithSummary("Get plants by CareLevel");

        public record Response(int id, string Name, DateTime LastWatered, CareLevel CareLevel);
        public static List<Response> Handle (CareLevel careLevel, IDatabase db)
        {
             var filteredPlants = PlantFilter.GetPlantsByCareLevel(db.Plants, careLevel)
             .Select(p => new Response(
                p.Id,
                p.Name,
                p.LastWatered,
                p.CareLevel
                ))
             .ToList();

           

             return filteredPlants;
        }
    }
}