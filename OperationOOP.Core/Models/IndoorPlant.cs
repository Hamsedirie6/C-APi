

namespace OperationOOP.Core.Models
{
    public class IndoorPlant : Plant // Ärver från plant
    {
        public string Location {get; set;} = string.Empty;

        public override void Water() // Uppdaterar senaste vattningstidpunkt
        {
           
           LastWatered = DateTime.Now;
        }
        public IndoorPlant() //Konstruktor som sätter vårdninvån
        {
            CareLevel = CareLevel.Medium;
        }
    }

    
}