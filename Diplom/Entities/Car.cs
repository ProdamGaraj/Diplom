using System;
using System.Collections.Generic;

namespace Diplom.Entities
{
    public partial class Car:Entity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
