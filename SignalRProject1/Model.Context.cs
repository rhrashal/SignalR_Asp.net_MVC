﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolManagementSystemEntities1 : DbContext
    {
        public SchoolManagementSystemEntities1()
            : base("name=SchoolManagementSystemEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admission_Apply> Admission_Apply { get; set; }
        public virtual DbSet<Brunch> Brunches { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Class_Room> Class_Room { get; set; }
        public virtual DbSet<Class_Routine> Class_Routine { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Education_System> Education_System { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Exam_Result> Exam_Result { get; set; }
        public virtual DbSet<Exam_Routine> Exam_Routine { get; set; }
        public virtual DbSet<Gardian> Gardians { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<Notice_Board> Notice_Board { get; set; }
        public virtual DbSet<Police_Station> Police_Station { get; set; }
        public virtual DbSet<Post_Office> Post_Office { get; set; }
        public virtual DbSet<Quota> Quotas { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Rules_Regulations> Rules_Regulations { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<School_Version> School_Version { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Student_Type> Student_Type { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject_Group> Subject_Group { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }
}