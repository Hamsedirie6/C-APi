

namespace OperationOOP.Core.Models
{
    public class PlantSorter
    {
        public static List<Plant> SortByWateringNeed(List<Plant> plants)
        {
            return plants.OrderBy(p => WateringSchedule.GetNextWatteringDate(p)).ToList();
        }
    }
}