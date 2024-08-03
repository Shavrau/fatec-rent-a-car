namespace Rent.A.Car
{
    public class Vehicicle
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public int Seats { get; set; }
        public string Category { get; set; }
        public string Model { get; set; }
        public string Fuel { get; set; }
    }
}
