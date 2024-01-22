using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace flightmvc.Models;

public partial class IvyUser
{
    //[Required(ErrorMessage ="Please enter a id")]
    public int Id { get; set; }

   [Required(ErrorMessage ="Please enter a valid Email address")]
   [DataType(DataType.EmailAddress,ErrorMessage ="Please enter a valid email address")]
    public string Email { get; set; } = null!;

    [StringLength(maximumLength:20,MinimumLength =8,ErrorMessage ="Username should be minimum of 8 charcater and maximum 20")]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage ="Password is required")]
    public string Password { get; set; } = null!;
}
