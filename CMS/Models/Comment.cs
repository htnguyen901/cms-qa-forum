using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Comment
    {
        public string Content { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int UserId { get; set; }
        public int IdeaId { get; set; }
        public int CommentId { get; set; }

        public virtual Idea Idea { get; set; }
        public virtual User User { get; set; }
    }
}
