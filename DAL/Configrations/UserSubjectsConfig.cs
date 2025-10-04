using Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configrations
{
    public class UserSubjectsConfig : IEntityTypeConfiguration<UserSubject>
    {

        public void Configure(EntityTypeBuilder<UserSubject> builder)
        {
            builder.HasKey(n => new {n.SubjectId, n.UserId});

            builder.HasOne(m=>m.User).WithMany(l=>l.UserSubjects).HasForeignKey(l=>l.UserId).OnDelete(DeleteBehavior.Restrict); ;
            builder.HasOne(m=>m.Subject).WithMany(l=>l.UserSubjects).HasForeignKey(l=>l.SubjectId).OnDelete(DeleteBehavior.Restrict); ;
        }
    }
}
