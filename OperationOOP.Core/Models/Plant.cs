

namespace OperationOOP.Core.Models
{
    public enum CareLevel
    {
        Easy,
        Medium,
        Hard
    }
    public abstract class Plant
    {
        public int Id{get; set;}
        public string Name{get; set;} = string.Empty;
        public CareLevel careLevel{get; set;}
        public DateTime LastWatered{get; set;}    

        public abstract void Water();
    }
}