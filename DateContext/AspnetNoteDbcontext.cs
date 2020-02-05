using kdhhome.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kdhhome.DateContext
{
    public class AspnetNoteDbcontext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=T;Database=AspNetNoteDb;User Id=sa;Password=asd123;");
        }
    }
}
