

namespace OperationOOP.Core.Models
{
    public class OutdoorPlant : Plant // Ärver från Plant
    {
        public string ClimateZone {get; set;} = string.Empty;

        public override void Water() // Uppdaterar senaste vattningstidpunkt
        {
            LastWatered = DateTime.Now;
        }

        public OutdoorPlant() //Konstruktor som sätter vårdninvån
        {
            CareLevel = CareLevel.Easy;
        }
    }
}