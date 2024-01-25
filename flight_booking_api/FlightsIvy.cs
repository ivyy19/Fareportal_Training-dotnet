using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace flightmvc.Models;

public partial class FlightsIvy
{
    [Required]
    public int FlightId { get; set; }

    [Required]
    public string FlightName { get; set; } = null!;

    [Required]
    public string Source { get; set; } = null!;

    [Required]
    public string Destination { get; set; } = null!;

    [Required(ErrorMessage ="Please numeric value")]
    public decimal Rate { get; set; }

    public virtual ICollection<BookingIvy> BookingIvies { get; set; } = new List<BookingIvy>();
}
