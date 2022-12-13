using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO_Core.Entities;

namespace TAO.Phone.Directory.Entity.Concrete
{
  public class Person :IEntity
  {
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Company { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Url { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Note { get; set; }
  }
}
