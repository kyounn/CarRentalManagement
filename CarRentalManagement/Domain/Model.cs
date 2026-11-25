namespace CarRentalManagement.Domain
{
    public class Model : BaseDomainModel

    { 
        public string? Name { get; set; }
        public DateTime DateCreated { get; internal set; }
        public DateTime DateUpdated { get; internal set; }
    }
}
