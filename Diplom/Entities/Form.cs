using System;
using System.Collections.Generic;

namespace Diplom.Entities
{
    public partial class Form : Entity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
