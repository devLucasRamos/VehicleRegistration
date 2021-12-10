using System.Linq;
namespace VehicleRegistration.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public VehicleTypes VehicleTypes { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public Owner()
        {

        }

        public Owner(int id, string name, string email, DateTime date, VehicleTypes vehicleTypes)
        {
            Id = id;
            Name = name;
            Email = email;
            Date = date;
            VehicleTypes = vehicleTypes;
        }
        public void AddVehicles(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
        public void RemoveVehicles(Vehicle vehicle)
        {
            Vehicles.Remove(vehicle);
        }
        public double AllVehicles(DateTime initial, DateTime final)
        {
            return Vehicles.Where(vehicle => vehicle.Date >= initial && vehicle.Date <= final).Sum(vehicle => vehicle.Price);
        }
    }
}
