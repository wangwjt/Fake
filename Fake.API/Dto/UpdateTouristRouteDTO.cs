using System.ComponentModel.DataAnnotations;

namespace Fake.API.Dto
{
    public class UpdateTouristRouteDTO
    {
        [Required(ErrorMessage = "title不允许为空!")]
        [MaxLength(64)]
        public string Title { get; set; }
        [Required(ErrorMessage = "描述不允许为空!")]
        [MaxLength(200)]
        public string Desc { get; set; }

        public decimal OriginalPrice { get; set; }

        public long? DiscountPresent { get; set; }

        public UpdateTouristRouteDTO()
        {
        }

        public UpdateTouristRouteDTO(string title, string desc, decimal originalPrice, long? discountPresent)
        {
            Title = title;
            Desc = desc;
            OriginalPrice = originalPrice;
            DiscountPresent = discountPresent;
        }
    }
}
