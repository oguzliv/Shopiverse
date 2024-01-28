using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopiverse.Models;

public class Product
{
    public int id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int Stock { get; set; }
}
