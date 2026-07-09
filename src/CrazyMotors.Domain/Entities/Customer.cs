using CrazyMotors.Domain.Common;

namespace CrazyMotors.Domain.Entities;

public class Customer : BaseEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public string? Address { get; set; }

    // Un cliente puede tener muchos vehículos
    public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}