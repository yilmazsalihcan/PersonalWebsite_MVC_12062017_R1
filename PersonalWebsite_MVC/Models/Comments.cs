//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalWebsite_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        public short CommentId { get; set; }
        public Nullable<short> UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
