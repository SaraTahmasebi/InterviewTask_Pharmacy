using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Infrastructure;
using Services;
using ViewModels.General;

namespace PharmacyApi.Infrastructure
{
    public class CityController : CrudControllerBase<CityViewModel, City, CityController>
    {
        private readonly IMapper _mapper;

        public CityController(
            ILogger<CityController> logger,
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
        public override async Task<dynamic> Create(City city)
        {

            if (!await EntityExists<Country>(city.CountryId))
            {
                var resultModel = new ApiResponseViewModel(false);
                resultModel.AddErrorMessage("Cannot Find Item Please Refresh Page");
                return resultModel;
            }

            return await base.Create(city);
        }

        [HttpPost, Route("List")]
        public override async Task<dynamic> CreateList(IEnumerable<City> cities)
        {
            foreach (var city in cities)
            {
                if (!await EntityExists<Country>(city.CountryId))
                {
                    var resultModel = new ApiResponseViewModel(false);
                    resultModel.AddErrorMessage("Cannot Find CountryId For CityName : " + city.Name);
                    return resultModel;
                }
            }
            return await base.CreateList(cities);
        }

        [HttpPut("{id}")]
        public override async Task<dynamic> Update(Guid id, City city)
        {
            return await base.Update(id, city);
        }

        [HttpPatch("{id}")]
        public override async Task<dynamic> UpdateItem(Guid id, CityViewModel cityVM)
        {
            return await base.UpdateItem(id, cityVM);
        }

        [HttpDelete("{id}")]
        public override async Task<dynamic> Delete(Guid id)
        {
            return await base.Delete(id);
        }
    }
}
