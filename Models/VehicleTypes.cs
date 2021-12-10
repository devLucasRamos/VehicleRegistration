using System;
using System.Linq;

namespace VehicleRegistration.Models
{
    public class VehicleTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Owner> Owners { get; set; } = new List<Owner>();

        public VehicleTypes()
        {

        }

        public VehicleTypes(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddOwner(Owner owner)
        {
            Owners.Add(owner);
        }
    }
}
