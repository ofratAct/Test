using System;
using System.Collections.Generic;

namespace App.DataAccess.Entities;

public partial class User
{
    public Guid UserId { get; set; }

    public string? Name { get; set; }

    public string? LastName { get; set; }
}
