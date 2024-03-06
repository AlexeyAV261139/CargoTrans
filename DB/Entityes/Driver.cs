using System;
using System.Collections.Generic;

namespace DB.Entities;

public partial class Driver
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Phone { get; set; }

    public virtual ICollection<ActiveRoute> ActiveRoutes { get; set; } = new List<ActiveRoute>();
}
