using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models.Infrastructure;
using ViewModels.General;

namespace PharmacyApi.Infrastructure
{
    public class CountryController : CrudControllerBase<CountryViewModel,Country, CountryController>
    {
        private readonly IMapper _mapper;
        public CountryController(
            ILogger<CountryController> logger,
               IMapper mapper) : base(logger, mapper)
        {
            _mapper = mapper;
        }


        [HttpGet]
        public override async Task<dynamic> List(int? pageNumber, int? pageSize, bool? paging,
        string? orderBy, string? direction, string? search)
        {
            return await base.List(pageNumber, pageSize, paging, orderBy, direction, search);
        }

        [HttpPost]
        public override async Task<dynamic> Create(Country country)
        {
            return await base.Create(country);
        }

        [HttpPost, Route("List")]
        public override async Task<dynamic> CreateList(IEnumerable<Country> countries)
        {
            return await base.CreateList(countries);
        }

        [HttpPut("{id}")]
        public override async Task<dynamic> Update(Guid id, Country country)
        {
            return await base.Update(id, country);
        }

        [HttpPatch("{id}")]
        public override async Task<dynamic> UpdateItem(Guid id, CountryViewModel countryVM)
        {
            return await base.UpdateItem(id, countryVM);
        }

        [HttpDelete("{id}")]
        public override async Task<dynamic> Delete(Guid id)
        {
            return await base.Delete(id);
        }
    }
}
