using VehicleRegistration.Models.Enum;

namespace VehicleRegistration.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Maker { get; set; }
        public string CarModel { get; set; }
        public VehicleStatus Status { get; set; }
        public Owner Owner { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(int id, DateTime date, int year, double price, string maker, string carModel, VehicleStatus status, Owner owner)
        {
            Id = id;
            Date = date;
            Year = year;
            Price = price;
            Maker = maker;
            CarModel = carModel;
            Status = status;
            Owner = owner;
        }
    }
}
