using Microsoft.EntityFrameworkCore;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Data
{
    public class DBEscuelaMVCContext : DbContext
    {
        public DBEscuelaMVCContext(DbContextOptions<DBEscuelaMVCContext> options) : base(options) { }

        public DbSet<Aula> Aulas { get; set; }

    }
}
