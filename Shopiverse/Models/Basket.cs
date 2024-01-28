using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopiverse.Models;

public class Basket
{
    public int id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public int Quantity { get; set; }
}
