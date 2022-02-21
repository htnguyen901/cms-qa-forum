using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Idea
    {
        public Idea()
        {
            Comments = new HashSet<Comment>();
            Files = new HashSet<File>();
            Reactions = new HashSet<Reaction>();
        }

        public int IdeaId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int SubmissionId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Submission Submission { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<Reaction> Reactions { get; set; }
    }
}
