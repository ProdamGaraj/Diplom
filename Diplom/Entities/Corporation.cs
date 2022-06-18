using System;
using System.Collections.Generic;

namespace Diplom.Entities
{
    public partial class Corporation:AuditableEntity
    {
        public Corporation()
        {
            UsersNavigation = new HashSet<User>();
        }
        public string? Name { get; set; }
        public int AdminId { get; set; }
        public string? Users { get; set; }
        public virtual ICollection<User> UsersNavigation { get; set; }
    }
}
