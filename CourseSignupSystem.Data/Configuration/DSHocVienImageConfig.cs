using CourseSignupSystem.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignupSystem.Data.Configuration
{
    public class DSHocVienImageConfig : IEntityTypeConfiguration<DSHocVienImage>
    {
        public void Configure(EntityTypeBuilder<DSHocVienImage> builder)
        {
            builder.ToTable("DSHocVienImage");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.DuongDanAnh).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.TenAnh).HasMaxLength(200);
            builder.HasOne(x => x.DSHocVien).WithMany(x => x.dSHocVienImages).HasForeignKey
                (x => x.DSHocVienID);
        }
    }
}
