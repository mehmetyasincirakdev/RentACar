using Core.Entities;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        // DTO - Data transfer object
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
       
    }
}
