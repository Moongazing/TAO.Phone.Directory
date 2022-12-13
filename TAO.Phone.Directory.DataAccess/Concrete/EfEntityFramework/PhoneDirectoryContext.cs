
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Phone.Directory.Entity.Concrete;

namespace TAO.Phone.Directory.DataAccess.Concrete.EfEntityFramework
{
  public class PhoneDirectoryContext :DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server =(localdb)\MSSQLLocalDB;Database =PhoneDirectory;Trusted_Connection=true");
    }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Mail> Mails { get; set; }
  }
}
