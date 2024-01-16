using System;
public class SBAccount
{
    public int AccountNumber 
    { get; 
      set; 
    }
    public string? CustomerName 
    { 
        get; 
        set; 
    }
    public string? CustomerAddress 
    
    { 
        get; 
        set; 
    }
    public decimal CurrentBalance 
    { 
        get; 
        set; 
    }
    public override string ToString()
    {
        return $"AccountNumber {AccountNumber}, Name={CustomerName},Address={CustomerAddress},Balance={CurrentBalance}";
    }
}



public class SBTransaction
{
    public int TransactionId 
    { 
        get; 
        set; 
    }
    public DateTime TransactionDate 
    { 
        get; 
        set; 
    }
    public int AccountNumber 
    { 
        get; 
        set; 
    }
    public decimal Amount 
    { 
        get; 
        set; 
    }
    public string? TransactionType 
    { 
        get; 
        set; 
    }
}
