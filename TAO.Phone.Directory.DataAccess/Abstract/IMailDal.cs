using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Phone.Directory.Entity.Concrete;
using TAO_Core.DataAccess;

namespace TAO.Phone.Directory.DataAccess.Abstract
{
  public interface IMailDal:IEntityRepository<Mail>
  {
  }
}
