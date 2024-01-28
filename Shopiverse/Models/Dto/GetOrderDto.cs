using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopiverse.Models.Dto;

public class GetOrderDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
