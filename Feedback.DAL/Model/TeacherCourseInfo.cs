//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Feedback.DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeacherCourseInfo
    {
        public int Id { get; set; }
        public Nullable<int> TeacherId { get; set; }
        public Nullable<int> CourseId { get; set; }
    
        public virtual CourseInfo CourseInfo { get; set; }
        public virtual TeacherInfo TeacherInfo { get; set; }
    }
}
