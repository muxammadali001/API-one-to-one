using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;
using TaxiDrivers.Entities.Enums;

namespace TaxiDrivers.Entities;

    public class Car
    {
        [Key]
        public Guid id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Number { get; set; }
        public Enums.ECarType Type { get; set; }
    }          