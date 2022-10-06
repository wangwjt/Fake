namespace Fake.API.Dto
{
    public class AddTouristRouteDTO
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

        public string Title { get; set; }

        public string Desc { get; set; }

        public decimal OriginalPrice { get; set; }

        public long? DiscountPresent { get; set; }
    }
}
