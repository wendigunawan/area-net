using Area.Api.Models;

namespace Area.Api.Services
{
    public interface IProvinceService
    {
        public Task<Province> GetById(string id);
        
        public Task<Province> GetByCode(string code);

        public Task<List<Province>> Find();
    }
}
