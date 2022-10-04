using System;

namespace Fake.API.Models
{
    /// <summary>
    /// 旅游路线dto
    /// </summary>
    public class TouristRoute
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public decimal OriginalPrice { get; set; }
        public double? DiscountPresent { get; set; }
        public DateTime CreateTime { get; set; }

        public TouristRoute()
        {
        }

        public TouristRoute(Guid id, string title, string desc, decimal originalPrice, double? discountPresent, DateTime createTime)
        {
            Id = id;
            Title = title;
            Desc = desc;
            OriginalPrice = originalPrice;
            DiscountPresent = discountPresent;
            CreateTime = createTime;
        }
    }
}