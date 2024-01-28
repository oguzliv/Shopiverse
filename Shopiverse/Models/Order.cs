using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopiverse.Models;

public class Order
{
    public int id { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; }
}
