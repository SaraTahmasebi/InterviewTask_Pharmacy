using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ViewModels.General
{
    public class CountryViewModel  : BaseEntityViewModel
    {
        public CountryViewModel(Guid ownerId) : base(ownerId)
        {
        }
        [DisplayName("کد")]
        public int? CountryCode { get; set; }
        [DisplayName("وضعیت")]
        public bool? Status { get; set; }
        public  virtual List<CityViewModel> Cities { get; set; }
    }
}
