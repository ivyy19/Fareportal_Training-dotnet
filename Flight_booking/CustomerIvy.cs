using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Build.Framework;

namespace flightmvc.Models;

public partial class CustomerIvy
{
   
    [Display(Name ="Customer ID")]
    
    public int CustomerId { get; set; }

    [Display(Name ="Customer Name")]
    public string CustomerName { get; set; } = null!;

    [Display(Name ="Customer Location")]
    public string Location { get; set; } = null!;

    public virtual ICollection<BookingIvy> BookingIvies { get; set; } = new List<BookingIvy>();
}
