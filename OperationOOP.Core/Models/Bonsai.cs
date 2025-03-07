namespace OperationOOP.Core.Models;
public class Bonsai : Plant
{
    
    public string Species { get; set; } = string.Empty;
    public int AgeYears { get; set; }
    public BonsaiStyle Style { get; set; }
    public DateTime LastPruned{get; set;}

    public override void Water()
    {
       LastWatered = DateTime.Now;
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

