﻿using fiorellopb101.Models;
using Microsoft.EntityFrameworkCore;

namespace fiorellopb101.Data
  
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfo { get; set; }
    }
}
