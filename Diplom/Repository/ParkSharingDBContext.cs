using System;
using System.Collections.Generic;
using Diplom.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Diplom.Repository
{
    public partial class ParkSharingDBContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Corporation> Corporations { get; set; } = null!;
        public virtual DbSet<Form> Forms { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        public ParkSharingDBContext(DbContextOptions<ParkSharingDBContext> options)
    : base(options)
        {
        }
    }
}