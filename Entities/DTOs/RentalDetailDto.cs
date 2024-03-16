using Core.Entities;

namespace Entities.DTOs;

public class RentalDetailDto : IDto
{
    public string CarName { get; set; }
    public string BrandName { get; set; }
    public string ColorName { get; set; }
    public string CustomerName { get; set; }
}