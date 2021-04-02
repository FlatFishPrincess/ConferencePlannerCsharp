using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;

namespace BackEnd.Data
{
    public class BackEndContext : DbContext
    {
        public BackEndContext (DbContextOptions<BackEndContext> options)
            : base(options)
        {
        }

        public DbSet<BackEnd.Models.Speaker> Speaker { get; set; }

        public DbSet<BackEnd.Models.Session> Session { get; set; }
    }
}
