using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public class Country  : BaseEntity
    {
        public Country(Guid ownerId) : base(ownerId)
        {
        }
        public Country() : this(Guid.NewGuid())
        {
        }
        [Required(ErrorMessage = "کد کشور را وارد نمائید")]
        [DisplayName("کد")]
        public int CountryCode { get; set; }
        [DisplayName("وضعیت")]
        public bool Status { get; set; }
        public  virtual List<City> Cities { get; set; }
    }
}
