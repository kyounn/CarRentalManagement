namespace CarRentalManagement.Domain
{
    public class Vehicles: BaseDomainModel
    {
        public string? LicensePlateNumber { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int ColourId { get; set; }
        public int Year { get; set; }

    }
}
