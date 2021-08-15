using Microsoft.EntityFrameworkCore;
using Site1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Database {
    public class DatabaseContext : DbContext {

        public DbSet<Palavra> Palavras { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){
            //EF - Garantir que o banco seja criado pelo EF - Code First
            Database.EnsureCreated();

        }
    }
}
