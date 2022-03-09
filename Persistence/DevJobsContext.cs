using DevJobs.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevJobs.API.Persistence
{
    public class DevJobsContext : DbContext
    {
        public DevJobsContext(DbContextOptions<DevJobsContext> options) : base(options)
        {
            
        }
        public DbSet<JobVacancy> JobVacancies {get;set;}
        public DbSet<JobApplication> JobApplications { get; set;}
        
        // configura classe pra tabelas
        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<JobVacancy>(e =>{
                e.HasKey(jobs => jobs.Id);
                e.ToTable("tb_JobVacancies");

                e.HasMany(jv => jv.Applications)
                .WithOne()
                .HasForeignKey(jobApp => jobApp.IdJob)
                .OnDelete(DeleteBehavior.Restrict);
            });
            builder.Entity<JobApplication>(e =>{
                e.HasKey(jobs => jobs.Id);
            });
        }
    }
}