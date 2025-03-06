

namespace OperationOOP.Core.Models
{
    public class OutdoorPLant : Plant
    {
        public string ClimateZone {get; set;} = string.Empty;

        public override void Water()
        {
            LastWatered = DateTime.Now;
        }
    }
}