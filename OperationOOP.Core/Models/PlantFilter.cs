

namespace OperationOOP.Core.Models
{
    public class PlantFilter
    {
        public static List<Plant> GetPlantsByCareLevel(List<Plant> plants, CareLevel careLevel)
        {
            return plants.Where(p => p.CareLevel == careLevel).ToList();
        }
    }
}