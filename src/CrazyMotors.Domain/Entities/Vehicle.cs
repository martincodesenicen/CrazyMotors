using CrazyMotors.Domain.Common;

namespace CrazyMotors.Domain.Entities;

public class Vehicle : BaseEntity
{
    public required string LicensePlate { get; set; } // Patente / Dominio
    public required string Brand { get; set; }        // Ej: Ford
    public required string Model { get; set; }        // Ej: Focus
    public int Year { get; set; }
    public int Mileage { get; set; }

    // Relación con el Client
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
}