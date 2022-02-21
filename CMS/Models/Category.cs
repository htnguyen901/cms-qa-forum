using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Category
    {
        public Category()
        {
            Ideas = new HashSet<Idea>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public virtual ICollection<Idea> Ideas { get; set; }
    }
}
