﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SampleMVCApp.Models
{
    public class SampleMVCAppContext : DbContext
    {
        public SampleMVCAppContext (DbContextOptions<SampleMVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<SampleMVCApp.Models.Person> Person { get; set; }
    }
}
