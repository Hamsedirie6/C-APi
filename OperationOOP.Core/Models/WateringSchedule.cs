

namespace OperationOOP.Core.Models
{
    public class WateringSchedule
    {
        public static int GetDaysUntilNextWattering(Plant plant)
        {
            if(plant is Bonsai) return 3;
            if(plant is IndoorPlant) return 5;
            if(plant is OutdoorPlant) return 7;
            return 7;
        }
        public static DateTime GetNextWatteringDate(Plant plant)
        {
            return plant.LastWatered.AddDays(GetDaysUntilNextWattering(plant));
        }
    }
}