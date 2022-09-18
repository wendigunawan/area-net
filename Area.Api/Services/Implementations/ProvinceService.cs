using Area.Api.Models;

namespace Area.Api.Services.Implementations
{
    public class ProvinceService : IProvinceService
    {

        private static List<Province> _provinces = new List<Province>()
        {
            new Province()
            {
                Id = "1",
                Code = "P001",
                Name = "Aceh",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Province()
            {
                Id = "2",
                Code = "P002",
                Name = "Jambi",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }

        };

        public async Task<Province> GetById(string id)
        {
            return _provinces.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Province> GetByCode(string code)
        {
            return _provinces.FirstOrDefault(x => x.Code == code);
        }

        public async Task<List<Province>> Find()
        {
            return _provinces;
        }
    }
}
