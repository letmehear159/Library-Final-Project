//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Final_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class FavouriteBook
    {
        public int id { get; set; }
        public int ISBN { get; set; }
        public string Account { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
