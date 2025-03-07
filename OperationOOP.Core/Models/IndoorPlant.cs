

namespace OperationOOP.Core.Models
{
    public class IndoorPlant : Plant
    {
        public string Location {get; set;} = string.Empty;

        public override void Water()
        {
           
           LastWatered = DateTime.Now;
        }
        public IndoorPlant()
        {
            CareLevel = CareLevel.Medium;
        }
    }

    
}