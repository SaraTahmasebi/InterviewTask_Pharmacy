using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.General
{
    public class BaseEntityViewModel
    {
        public BaseEntityViewModel(Guid ownerId)
        {
            OwnerId = ownerId;
            LastUpdatedBy = ownerId;
            DateAdded = DateTime.Now;
            LastUpdateDate = DateAdded;
        }
        
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime DateAdded { get; set; }
        public Guid LastUpdatedBy { get; set; }
        public DateTime  LastUpdateDate { get; set; } 
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public string? PersianName { get; set; }

    }
}
