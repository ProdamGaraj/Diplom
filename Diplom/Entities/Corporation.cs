using System;
using System.Collections.Generic;

namespace Diplom.Entities
{
    public partial class Corporation : Entity
    {
        public string Name { get; set; }
        public int AdminId { get; set; }
        public virtual ICollection<User>? Users { get; set; }
        public int ParkingPlaces { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
