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
  public interface IPersonService
  {
    IResult Add(Person person);
    IResult Delete(Person person);
    IResult Update(Person person);
    IDataResult<List<Person>> GetAll();
    IDataResult<List<Person>> GetByFirstName(string firstName);
    IDataResult<List<Person>> GetByLastName(string lastName);
    IDataResult<List<Person>> GetByPhoneNumber(string phoneNumber);
    IDataResult<List<Person>> GetByUrl(string url);
    IDataResult<List<Person>> GetByAddress(string address);
    IDataResult<List<Person>> GetByEmail(string email);


  }
}
