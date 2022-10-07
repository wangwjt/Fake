using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fake.API.Dto
{
    public class AddTouristRouteDTO : IValidatableObject
    {
        public AddTouristRouteDTO()
        {
        }

        public AddTouristRouteDTO(string title, string desc, decimal originalPrice, long? discountPresent)
        {
            Title = title;
            Desc = desc;
            OriginalPrice = originalPrice;
            DiscountPresent = discountPresent;
        }
        [Required(ErrorMessage ="title不允许为空")]
        [MaxLength(64)]
        public string Title { get; set; }
        [Required(ErrorMessage = "描述不允许为空")]
        [MaxLength(200)]
        public string Desc { get; set; }

        public decimal OriginalPrice { get; set; }

        public long? DiscountPresent { get; set; }

        // 可自定义补充数据校验逻辑
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Title == Desc)
            {
                // 错误信息，错误路径
                yield return new ValidationResult("名称与描述不能相同", new[]{ "AddTouristRouteDTO" });
            }
        }
    }
}
