using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fake.API.Models
{
    /// <summary>
    /// 旅游路线dto
    /// </summary>
    public class TouristRoute
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }
        [Required]
        [MaxLength(64)]
        [Column("title")]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        [Column("desc")]
        public string Desc { get; set; }
        [Column("original_price", TypeName ="decimal(18,2)")]
        public decimal OriginalPrice { get; set; }
        [Column("discount_present")]
        public long? DiscountPresent { get; set; }
        [Column("create_time")]
        public DateTime CreateTime { get; set; }

        public TouristRoute()
        {
        }

        public TouristRoute(string id, string title, string desc, decimal originalPrice, long? discountPresent, DateTime createTime)
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