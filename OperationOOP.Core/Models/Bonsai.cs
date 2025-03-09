namespace OperationOOP.Core.Models;
public class Bonsai : Plant //Ärver från Plant
{
    
    public string Species { get; set; } = string.Empty;
    public int AgeYears { get; set; }
    public BonsaiStyle Style { get; set; }
    public DateTime LastPruned{get; set;}

    public override void Water()// Uppdaterar senaste vattningstidpunkt
    {
       LastWatered = DateTime.Now;
    }
    public Bonsai() //Konstruktor som sätter vårdninvån
    {
        CareLevel = CareLevel.Hard;
    }

}

public enum BonsaiStyle
{
    Chokkan,    // Formal Upright
    Moyogi,     // Informal Upright
    Shakan,     // Slanting
    Kengai,     // Cascade
    HanKengai   // Semi-cascade
}

