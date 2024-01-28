using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopiverse.Models;

public class User
{
    public int id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Province { get; set; }
    public string District { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Address { get; set; }

}
