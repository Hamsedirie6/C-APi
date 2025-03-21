﻿namespace OperationOOP.Api.Endpoints;
public class CreateBonsai : IEndpoint
{
    public static void MapEndpoint(IEndpointRouteBuilder app) => app
        .MapPost("/bonsais", Handle)
        .WithSummary("Bonsai trees");

    public record Request(
        string Name,
        string Species,
        int AgeYears,
        DateTime LastWatered,
        BonsaiStyle Style,
        CareLevel CareLevel
        );
    public record Response(int id);

    private static Ok<Response> Handle(Request request, IDatabase db)
    {
        var bonsai = new Bonsai();

        bonsai.Id = db.Bonsais.Any()
            ? db.Bonsais.Max(bonsai => bonsai.Id) + 1
            : 1;
        bonsai.Name = request.Name;
        bonsai.Species = request.Species;
        bonsai.AgeYears = request.AgeYears;
        bonsai.LastWatered = request.LastWatered;
        bonsai.Style = request.Style;
        bonsai.CareLevel = request.CareLevel;

        db.Bonsais.Add(bonsai);

        return TypedResults.Ok(new Response(bonsai.Id));
    }
}

