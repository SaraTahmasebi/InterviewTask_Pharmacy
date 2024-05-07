using Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewModels.General;

namespace ViewModels.General
{
    public class CityViewModel  : BaseEntityViewModel
    {
        public CityViewModel(Guid ownerId) : base(ownerId)
        { 
        }   
     
        [DisplayName("کد")]
        public int? CityCode { get; set; }
        [DisplayName("وضعیت")]
        public bool? Status { get; set; }
        [DisplayName("نوع")]
        public CityType? Type { get; set; }
        public Guid CountryId { get; set; }
        public CountryViewModel Country { get; set; }

    }
}
