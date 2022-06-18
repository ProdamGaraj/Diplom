using System;
using System.Collections.Generic;

namespace Diplom.Entities
{
    public partial class Car:AuditableEntity
    {
        public int UserId { get; set; }
    }
}
