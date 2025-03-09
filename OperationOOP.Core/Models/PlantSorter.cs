

namespace OperationOOP.Core.Models
{
    //Sorterar växter efter hur snart de behöver vattnas
    public class PlantSorter
    {
        public static List<Plant> SortByWateringNeed(List<Plant> plants)
        {
            return plants.OrderBy(p => WateringSchedule.GetNextWatteringDate(p)).ToList();
        }
    }
}