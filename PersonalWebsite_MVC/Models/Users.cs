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
    
    public partial class Users
    {
        public Users()
        {
            this.Blogs = new HashSet<Blogs>();
            this.Comments = new HashSet<Comments>();
        }
    
        public short UserId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
    
        public virtual ICollection<Blogs> Blogs { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual UserDetails UserDetails { get; set; }
    }
}
