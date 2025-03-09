

namespace OperationOOP.Core.Models
{
    // Filtrerar växter baserat på deras vårdnivå
    public class PlantFilter 
    {
        public static List<Plant> GetPlantsByCareLevel(List<Plant> plants, CareLevel careLevel)
        {
            return plants.Where(p => p.CareLevel == careLevel).ToList();
        }
    }
}