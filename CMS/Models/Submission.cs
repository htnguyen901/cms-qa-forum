using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Submission
    {
        public Submission()
        {
            Ideas = new HashSet<Idea>();
        }

        public int SubmissionId { get; set; }
        public string SubmissionName { get; set; }
        public string SubmissionDescription { get; set; }
        public DateTime? ClosureDate { get; set; }
        public DateTime? FinalClosureDate { get; set; }

        public virtual ICollection<Idea> Ideas { get; set; }
    }
}
