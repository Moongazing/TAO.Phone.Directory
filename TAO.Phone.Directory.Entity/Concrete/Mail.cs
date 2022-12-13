using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO_Core.Entities;

namespace TAO.Phone.Directory.Entity.Concrete
{
  public class Mail:IEntity
  {
    public Guid Id { get; set; }
    public string Sender { get; set; }
    public string Password { get; set; }
    public string SentTo { get; set; }
    public string CC { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public string FilePath { get; set; }
    public DateTime SentDate { get; set; }
    public bool Success { get; set; }
  }
}
