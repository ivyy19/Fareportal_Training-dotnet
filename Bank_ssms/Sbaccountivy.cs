using System;
using System.Collections.Generic;

namespace ssmsbank.Models;

public partial class Sbaccountivy
{
    public int AccountNumber { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerAddress { get; set; }

    public decimal? CurrentBalance { get; set; }

    public virtual ICollection<Sbtransactionsivy> Sbtransactionsivies { get; set; } = new List<Sbtransactionsivy>();
}
