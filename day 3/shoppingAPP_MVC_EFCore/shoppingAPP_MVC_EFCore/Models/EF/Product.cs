using System;
using System.Collections.Generic;

namespace shoppingAPP_MVC_EFCore.Models.EF;

public partial class Product
{
    public int PId { get; set; }

    public string? PName { get; set; }

    public string? PCategory { get; set; }

    public int? PPrice { get; set; }

    public bool? PIsInStock { get; set; }

    public int? PMinimumOrderQty { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
