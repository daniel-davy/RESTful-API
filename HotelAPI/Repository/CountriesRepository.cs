using HotelAPI.Contracts;
using HotelAPI.Data;

namespace HotelAPI.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        public CountriesRepository(HotelDbContext context) : base(context)
        {

        }
    }
}
