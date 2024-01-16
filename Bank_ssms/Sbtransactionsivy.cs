using System;
using System.Collections.Generic;

namespace ssmsbank.Models;

public partial class Sbtransactionsivy
{
    public int TransactionId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public int? AccountNumber { get; set; }

    public decimal? Amount { get; set; }

    public string? TransactionType { get; set; }

    public virtual Sbaccountivy? AccountNumberNavigation { get; set; }
}
