using Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Infrastructure
{
    public class City : BaseEntity 
    {
        public City(Guid ownerId) : base(ownerId)
        { 
        }
        public City() : this(Guid.NewGuid())
        {
        }

        [Required(ErrorMessage = "کد شهر را وارد نمائید")]
        [DisplayName("کد")]
        public int CityCode { get; set; }
        [DisplayName("وضعیت")]
        public bool Status { get; set; }

        [Required(ErrorMessage = "نوع شهر را وارد نمائید")]
        [DisplayName("نوع")]
        public CityType Type { get; set; }
        public Guid CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }

    }
}
