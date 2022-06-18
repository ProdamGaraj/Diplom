using System;
using System.Collections.Generic;

namespace Diplom.Entities
{
    public partial class Form:AuditableEntity
    {
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
