using System;
using System.Collections.Generic;

namespace Point_Of_Sale.Models;

public partial class Payment
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public int? TransactionId { get; set; }

    public string? PaymentType { get; set; }

    public string? PaymentBy { get; set; }

    public DateTime? PaymentOn { get; set; }

    public decimal? AccountsReceivable { get; set; }
}
