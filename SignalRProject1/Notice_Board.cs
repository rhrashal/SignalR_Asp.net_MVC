//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SignalRProject1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notice_Board
    {
        public int Notice_Id { get; set; }
        public string Topic_Name { get; set; }
        public string Notice_Body { get; set; }
        public Nullable<System.DateTime> Publish_Date { get; set; }
        public Nullable<int> Class_Id { get; set; }
        public Nullable<int> Brunch_Id { get; set; }
    
        public virtual Brunch Brunch { get; set; }
        public virtual Class Class { get; set; }
    }
}
