using System;
using System.Collections.Generic;

namespace Diplom.Entities
{
    public partial class Corporation : Entity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int AdminId { get; set; }
        public string? Users { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
