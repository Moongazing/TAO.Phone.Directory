using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Phone.Directory.Entity.Concrete;
using TAO_Core.Utilities.Results;
using TAO_Core.Utilities.Results.Abstract;

namespace TAO.Phone.Directory.Business.Abstract
{
  public interface IMailService
  {
    IResult SendMail(Mail mail);
    IResult Add(Mail mail);
    IDataResult<List<Person>> GetAll();
    IDataResult<List<Person>> GetBySentTo(string sentTo);
    IDataResult<List<Person>> GetBySentDate(DateTime sentDate);
    IDataResult<List<Person>> GetBySubject(string subject);
    IDataResult<List<Person>> GetByBody(string subject);

  }
}
