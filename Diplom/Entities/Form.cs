using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.Entities
{
    public partial class Form : Entity
    {
        public DateTime Date { get; set; }

        [ForeignKey(nameof (User))]
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
