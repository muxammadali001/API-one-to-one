namespace TaxiDrivers.Entities;

    public class Car
    {
        public Guid id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Number { get; set; }
        public ECarType { get; set; }
    }          