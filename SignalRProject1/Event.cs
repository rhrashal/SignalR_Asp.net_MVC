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
    
    public partial class Event
    {
        public int Event_Id { get; set; }
        public string Event_Name { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public string Event_Controlar { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> Brunch_Id { get; set; }
    
        public virtual Brunch Brunch { get; set; }
    }
}
