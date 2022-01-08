using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Context: DbContext
    {
        public Context() : base("Name=Context")
        {

        }
        public DbSet<Kitap> Kitaps { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Odunc> Oduncs { get; set; }
    }
}
