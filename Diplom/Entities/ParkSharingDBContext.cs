using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Diplom.Entities
{
    public partial class ParkSharingDBContext : DbContext
    {
        public ParkSharingDBContext()
        {
        }

        public ParkSharingDBContext(DbContextOptions<ParkSharingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Corporation> Corporations { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-EN58KEA;Database=ParkSharingDB;Trusted_Connection=True;");
            }
        }
    }
}
