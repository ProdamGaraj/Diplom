using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.Entities
{
    public partial class User : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int Role { get; set; } 
        public string Post { get; set; }
        public string Rate { get; set; }
        public virtual ICollection<Form>? Forms { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        [ForeignKey( nameof (Corporation))]
        public int CorporationId { get; set; }
        public virtual Corporation Corporation { get; set; }
        public virtual ICollection<Car>? Cars { get; set; }
    }
}
