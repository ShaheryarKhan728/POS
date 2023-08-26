using System;
using System.Collections.Generic;

namespace Point_Of_Sale.Models;

public partial class Account
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public string? UserId { get; set; }

    public string? Password { get; set; }

    public string? Logo { get; set; }
}
