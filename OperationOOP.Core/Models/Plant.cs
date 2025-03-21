

namespace OperationOOP.Core.Models
{
    public enum CareLevel //Enum som definierar olika vårdnivåer
    {
        Easy,
        Medium,
        Hard
    }
    public abstract class Plant
    {
        public int Id{get; set;}
        public string Name{get; set;} = string.Empty;
        public CareLevel CareLevel{get; set;}
        public DateTime LastWatered{get; set;}    

        public abstract void Water();
    }
}