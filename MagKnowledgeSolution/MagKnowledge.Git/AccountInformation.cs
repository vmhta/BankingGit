//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagKnowledge.Git
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountInformation
    {
        public int Id { get; set; }
        public bool IsCurrent { get; set; }
        public int UserId { get; set; }
        public double Balance { get; set; }
    
        public virtual UserDetail UserDetail { get; set; }
    }
}
