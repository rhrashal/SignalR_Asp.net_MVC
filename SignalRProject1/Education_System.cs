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
    
    public partial class Education_System
    {
        public int Education_System_Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Student_Type_Id { get; set; }
        public Nullable<int> School_Version_Id { get; set; }
        public Nullable<int> Brunch_Id { get; set; }
        public Nullable<int> Shift_Id { get; set; }
    
        public virtual Brunch Brunch { get; set; }
        public virtual School_Version School_Version { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual Student_Type Student_Type { get; set; }
    }
}
