//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public string UserId { get; set; }
        public Nullable<int> IdeaId { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Idea Idea { get; set; }
    }
}
