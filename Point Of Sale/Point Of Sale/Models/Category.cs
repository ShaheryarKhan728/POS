using System;
using System.Collections.Generic;

namespace Point_Of_Sale.Models;

public partial class Category
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public string? Name { get; set; }
}
