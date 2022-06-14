using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace TaxiDrivers.Entities;

public class Driver
{
    [Key]
    public Guid id { get; set; }
    public Guid Id { get; internal set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Age { get; set; }

}   