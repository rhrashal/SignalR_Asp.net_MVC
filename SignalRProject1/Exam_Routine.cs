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
    
    public partial class Exam_Routine
    {
        public int ExamRoutineId { get; set; }
        public Nullable<System.DateTime> ExamDate { get; set; }
        public Nullable<System.TimeSpan> Start_Time { get; set; }
        public Nullable<System.TimeSpan> End_Time { get; set; }
        public Nullable<int> Exam_Id { get; set; }
        public Nullable<int> Subject_Id { get; set; }
        public Nullable<int> Class_Id { get; set; }
        public Nullable<int> Brunch_Id { get; set; }
        public Nullable<int> Shift_Id { get; set; }
    
        public virtual Brunch Brunch { get; set; }
        public virtual Class Class { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
