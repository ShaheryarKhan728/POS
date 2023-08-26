using System;
using System.Collections.Generic;

namespace Point_Of_Sale.Models;

public partial class Product
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public string? Name { get; set; }

    public string? Sku { get; set; }

    public string? Description { get; set; }

    public int? CategoryId { get; set; }

    public string? BrandName { get; set; }

    public string? SupplierName { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }
}
