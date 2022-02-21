using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Reaction
    {
        public int ReactionId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int UserId { get; set; }
        public int IdeaId { get; set; }

        public virtual Idea Idea { get; set; }
        public virtual User User { get; set; }
    }
}
