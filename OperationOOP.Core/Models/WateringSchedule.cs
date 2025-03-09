

namespace OperationOOP.Core.Models
{
    //Bevattningsschema för olika växttyper
    public class WateringSchedule
    {
        //Returnerar dagar tills nästa vattning beroende på växttyp
        public static int GetDaysUntilNextWattering(Plant plant)
        {
            if(plant is Bonsai) return 3;
            if(plant is IndoorPlant) return 5;
            if(plant is OutdoorPlant) return 7;
            return 7;
        }
         // beräknar datumet för nästa vattning baserat på senaste vattning och intervall
        public static DateTime GetNextWatteringDate(Plant plant)
        {
            return plant.LastWatered.AddDays(GetDaysUntilNextWattering(plant));
        }
    }
}