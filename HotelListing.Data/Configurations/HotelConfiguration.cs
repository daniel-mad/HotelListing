using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                 new Hotel
                 {
                     Id = 1,
                     Name = "The Princess",
                     Address = "Eilat",
                     CountryId = 1,
                     Rating = 4.5
                 },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Sandals Resort and Spa",
                     Address = "Negrl",
                     CountryId = 2,
                     Rating = 4.3
                 },
                 new Hotel
                 {
                     Id = 3,
                     Name = "Grand Paladium",
                     Address = "Naussa",
                     CountryId = 3,
                     Rating = 4
                 }
                );
        }
    }
}
