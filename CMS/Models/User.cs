using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            Reactions = new HashSet<Reaction>();
        }

        public int UserId { get; set; }
        public string Fullname { get; set; }
        public int? StaffId { get; set; }
        public int RoleId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Reaction> Reactions { get; set; }
    }
}
