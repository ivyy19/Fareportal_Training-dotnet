using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace flightmvc.Models;

public partial class BookingIvy
{
    public int BookingId { get; set; }

    [Display(Name ="Flight Id")]
    public int? FlightId { get; set; }

    [Display(Name ="Customer Id")]
    public int? CustomerId { get; set; }

    [Display(Name ="Booking Date")]
    public DateTime? BookingDate { get; set; }

    [Display(Name ="Number of Passengers")]
    [Required(ErrorMessage ="Atleast 1 passenger should be there")]
    [Range(minimum:1,maximum:20)]
    public int NoOfPassengers { get; set; }

    [Display(Name ="Total Cost")]
    public decimal TotalCost { get; set; }

    public string Source { get; set; } = null!;

    public string Destination { get; set; } = null!;

public virtual CustomerIvy? Customer { get; set; }

    public virtual FlightsIvy? Flight { get; set; }

   


}
