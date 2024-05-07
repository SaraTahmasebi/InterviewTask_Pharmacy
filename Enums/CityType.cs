using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{ 
    public enum CityType
    {
        [Description("شهری")]
        Urban = 1,
        [Description("روستایی")]
        Rural = 2,
        [Description("شهر کوچک")]
        SmallCity = 3
    }
}
