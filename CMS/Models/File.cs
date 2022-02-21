using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class File
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModified { get; set; }
        public int IdeaId { get; set; }

        public virtual Idea Idea { get; set; }
    }
}
