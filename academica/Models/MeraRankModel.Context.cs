﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace academica.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MeraRankDBEntities : DbContext
    {
        public MeraRankDBEntities()
            : base("name=MeraRankDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<accreditation_type> accreditation_type { get; set; }
        public virtual DbSet<accreditation_value> accreditation_value { get; set; }
        public virtual DbSet<activation_keys> activation_keys { get; set; }
        public virtual DbSet<arrear_marks> arrear_marks { get; set; }
        public virtual DbSet<board> boards { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<cm> cms { get; set; }
        public virtual DbSet<college> colleges { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<course> courses { get; set; }
        public virtual DbSet<course_mapping> course_mapping { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<department_mapping> department_mapping { get; set; }
        public virtual DbSet<@event> events { get; set; }
        public virtual DbSet<feature> features { get; set; }
        public virtual DbSet<feedback> feedbacks { get; set; }
        public virtual DbSet<grade> grades { get; set; }
        public virtual DbSet<grade_scale> grade_scale { get; set; }
        public virtual DbSet<graduation> graduations { get; set; }
        public virtual DbSet<main_modules> main_modules { get; set; }
        public virtual DbSet<mark> marks { get; set; }
        public virtual DbSet<medium> media { get; set; }
        public virtual DbSet<member_settings> member_settings { get; set; }
        public virtual DbSet<member> members { get; set; }
        public virtual DbSet<modules_features> modules_features { get; set; }
        public virtual DbSet<MRCorporate> MRCorporates { get; set; }
        public virtual DbSet<newsletter> newsletters { get; set; }
        public virtual DbSet<organization_type> organization_type { get; set; }
        public virtual DbSet<orgnization> orgnizations { get; set; }
        public virtual DbSet<rank> ranks { get; set; }
        public virtual DbSet<refered_emails> refered_emails { get; set; }
        public virtual DbSet<search> searches { get; set; }
        public virtual DbSet<search_terms> search_terms { get; set; }
        public virtual DbSet<semester> semesters { get; set; }
        public virtual DbSet<sslc_12th_marks> sslc_12th_marks { get; set; }
        public virtual DbSet<sslc_12th_settings> sslc_12th_settings { get; set; }
        public virtual DbSet<state> states { get; set; }
        public virtual DbSet<stream> streams { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sub_modules> sub_modules { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<subject_mapping> subject_mapping { get; set; }
        public virtual DbSet<subscription> subscriptions { get; set; }
        public virtual DbSet<support_complaints> support_complaints { get; set; }
        public virtual DbSet<support_type> support_type { get; set; }
        public virtual DbSet<university> universities { get; set; }
        public virtual DbSet<university_course_mapping> university_course_mapping { get; set; }
        public virtual DbSet<university_department_mapping> university_department_mapping { get; set; }
        public virtual DbSet<university_type> university_type { get; set; }
        public virtual DbSet<user_access_rights> user_access_rights { get; set; }
        public virtual DbSet<user_activity_log> user_activity_log { get; set; }
        public virtual DbSet<user_admin> user_admin { get; set; }
        public virtual DbSet<user_mapping> user_mapping { get; set; }
        public virtual DbSet<user_members> user_members { get; set; }
        public virtual DbSet<User_registration> User_registration { get; set; }
        public virtual DbSet<user_roles> user_roles { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<subject_mapping_settings> subject_mapping_settings { get; set; }
    
        public virtual int pro_user_registration(string email_id, string first_name, string last_name, string user_type, ObjectParameter result, ObjectParameter activation_key)
        {
            var email_idParameter = email_id != null ?
                new ObjectParameter("email_id", email_id) :
                new ObjectParameter("email_id", typeof(string));
    
            var first_nameParameter = first_name != null ?
                new ObjectParameter("first_name", first_name) :
                new ObjectParameter("first_name", typeof(string));
    
            var last_nameParameter = last_name != null ?
                new ObjectParameter("last_name", last_name) :
                new ObjectParameter("last_name", typeof(string));
    
            var user_typeParameter = user_type != null ?
                new ObjectParameter("user_type", user_type) :
                new ObjectParameter("user_type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pro_user_registration", email_idParameter, first_nameParameter, last_nameParameter, user_typeParameter, result, activation_key);
        }
    }
}
