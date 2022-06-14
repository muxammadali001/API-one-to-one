using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace TaxiDrivers.Models;

public class NewDriver
{
    [Key]
    public Guid id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Age { get; set; }

}    