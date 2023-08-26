using System;
using System.Collections.Generic;

namespace Point_Of_Sale.Models;

public partial class SaleMaster
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? TotalQuantity { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
