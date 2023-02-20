namespace PublicApi.Endpoints.Drivers.Car
{
    public class CarCommand
    {
        public int CarBrandId { get; set; }
        public int CarTypeId { get; set; }
        public int CarColorId { get; set; }
        public int ProductionYear { get; set; }
        public string RegistrationCertificate { get; set; }
        public string LicensePlate { get; set; }
        public bool IsDeleted { get; set; }
    }
}