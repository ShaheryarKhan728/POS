using System;
using System.Collections.Generic;

namespace Point_Of_Sale.Models;

public partial class AccountsUser
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public string? AccountType { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }
}
