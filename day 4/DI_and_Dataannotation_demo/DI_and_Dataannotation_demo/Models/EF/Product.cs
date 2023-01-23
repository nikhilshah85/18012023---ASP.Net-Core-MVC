using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DI_and_Dataannotation_demo.Models.EF;

public partial class Product
{

    [DisplayName("Product ID")]
    public int PId { get; set; }

    [DisplayName("Product")]
    [StringLength(20,MinimumLength =4, ErrorMessage ="Invalid Product Name")]
    [Required(ErrorMessage = "Cannot be left blank")]
    public string? PName { get; set; }

    [DisplayName("Category")]
    [Required(ErrorMessage = "Cannot be left blank")]
    public string? PCategory { get; set; }

    [DisplayName("Offer Price")]
    [Required(ErrorMessage = "Cannot be left blank")]
    [Range(10,2000,ErrorMessage ="Please enter price between 10 and 2000 only")]
    public int? PPrice { get; set; }

    [DisplayName("Available")]
    public bool? PIsInStock { get; set; }

    [DisplayName("Minimum Order Qty")]
    [Required(ErrorMessage ="Cannot be left blank")]
    [Range(1,20,ErrorMessage="Minimum should be 1")]
    public int? PMinimumOrderQty { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
