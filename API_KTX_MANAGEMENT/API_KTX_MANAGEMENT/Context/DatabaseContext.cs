using API_KTX_MANAGEMENT.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_KTX_MANAGEMENT.Context
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<SinhVien> SinhVien { get; set; }
        public DbSet<Dien> Dien { get; set; }
        public DbSet<Nuoc> Nuoc { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HopDong> HopDong { get; set; }
        public DbSet<Khu> Khu { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
    }
}
