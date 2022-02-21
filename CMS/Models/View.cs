using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class View
    {
        public DateTime? LastVisitedDate { get; set; }
        public int UserId { get; set; }
        public int IdeaId { get; set; }

        public virtual Idea Idea { get; set; }
        public virtual User User { get; set; }
    }
}
