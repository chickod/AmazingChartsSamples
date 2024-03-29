﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ACEntities : DbContext
    {
        public ACEntities()
            : base("name=ACEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Patient> Patients { get; set; }
    
        public virtual ObjectResult<Patient> uspGetPatient(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Patient>("uspGetPatient", idParameter);
        }
    
        public virtual ObjectResult<Patient> uspGetPatient(Nullable<int> id, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Patient>("uspGetPatient", mergeOption, idParameter);
        }
    
        public virtual ObjectResult<Patient> uspGetAllPatients()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Patient>("uspGetAllPatients");
        }
    
        public virtual ObjectResult<Patient> uspGetAllPatients(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Patient>("uspGetAllPatients", mergeOption);
        }
    }
}
