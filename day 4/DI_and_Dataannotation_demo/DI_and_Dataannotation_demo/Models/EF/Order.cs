using System;
using System.Collections.Generic;

namespace DI_and_Dataannotation_demo.Models.EF;

public partial class Order
{
    public int OId { get; set; }

    public DateTime? ODate { get; set; }

    public string? OStatus { get; set; }

    public int? OPid { get; set; }

    public int? OAmount { get; set; }

    public virtual Product? OP { get; set; }
}
