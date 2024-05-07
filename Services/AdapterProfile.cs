using AutoMapper;
using Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.General;

namespace Services
{
    public class AdapterProfile : Profile
    {
        public AdapterProfile()
        { 
            CreateMap<CountryViewModel, Country>().ReverseMap();

            CreateMap<CityViewModel, City>().ReverseMap();
        }
    }
}
