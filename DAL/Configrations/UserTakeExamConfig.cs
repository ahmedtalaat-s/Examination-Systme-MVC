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
    internal class UserTakeExamConfig : IEntityTypeConfiguration<UserTakeExam>
    {
        public void Configure(EntityTypeBuilder<UserTakeExam> builder)
        {
            builder.HasKey(n => new { n.UserId, n.ExamId });

            builder.HasOne(m => m.User).WithMany(l => l.UserExams).HasForeignKey(l => l.UserId).OnDelete(DeleteBehavior.Restrict); ;
            builder.HasOne(m => m.Exam).WithMany(l => l.UserExams).HasForeignKey(l => l.ExamId).OnDelete(DeleteBehavior.Restrict); ;
        }
    
    }
}
