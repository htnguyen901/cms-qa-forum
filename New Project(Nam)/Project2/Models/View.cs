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
    
    public partial class View
    {
        public string UserId { get; set; }
        public int IdeaId { get; set; }
        public Nullable<System.DateTime> LastVisitedDate { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Idea Idea { get; set; }
    }
}
