using System;
using System.Collections.Generic;

namespace Diplom.Entities
{
    public partial class User:AuditableEntity
    {
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Role { get; set; }
        public string Post { get; set; } = null!;
        public string Rate { get; set; } = null!;
        public int Forms { get; set; }
        public int Corporation { get; set; }

        public virtual Corporation CorporationNavigation { get; set; } = null!;
    }
}
