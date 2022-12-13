using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Phone.Directory.DataAccess.Abstract;
using TAO.Phone.Directory.Entity.Concrete;
using TAO_Core.DataAccess.EntityFramework;

namespace TAO.Phone.Directory.DataAccess.Concrete.EfEntityFramework
{
  public class EfMailDal:EfEntityRepositoryBase<Mail,PhoneDirectoryContext>,IMailDal
  {

  }
}
