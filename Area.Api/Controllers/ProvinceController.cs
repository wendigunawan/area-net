using Area.Api.Models;
using Area.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Area.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IProvinceService _provinceService;
        
        public ProvinceController(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }
        
        [HttpGet]
        [Route(template:"{id}")]
        public async Task<Province> GetProvince(string id)
        {
            return await _provinceService.GetById(id);
        }
        
        [HttpGet]
        [Route(template:"find")]
        public async Task<List<Province>> FindProvince()
        {
            return await _provinceService.Find();
        }
    }
}