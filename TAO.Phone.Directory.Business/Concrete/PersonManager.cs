using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Phone.Directory.Business.Abstract;
using TAO.Phone.Directory.Business.Constans;
using TAO.Phone.Directory.DataAccess.Abstract;
using TAO.Phone.Directory.Entity.Concrete;
using TAO_Core.Utilities.Results;
using TAO_Core.Utilities.Results.Abstract;
using TAO_Core.Utilities.Results.Concrete;

namespace TAO.Phone.Directory.Business.Concrete
{
  public class PersonManager : IPersonService
  {
    IPersonDal _personDal;
    public PersonManager(IPersonDal personDal)
    {
      _personDal = personDal;
    }

    public IResult Add(Person person)
    {
      _personDal.Add(person);
      return new SuccessResult(Messages.PersonAdded);
    }

    public IResult Delete(Person person)
    {
      _personDal.Delete(person);
      return new SuccessResult(Messages.PersonDeleted);
    }

    public IDataResult<List<Person>> GetAll()
    {
      return new SuccessDataResult<List<Person>>(_personDal.GetAll());
    }

    public IDataResult<List<Person>> GetByAddress(string address)
    {
      return new SuccessDataResult<List<Person>>(_personDal.GetAll(p => p.Address == address));
    }

    public IDataResult<List<Person>> GetByEmail(string email)
    {
      return new SuccessDataResult<List<Person>>(_personDal.GetAll(p => p.Email == email));
    }

    public IDataResult<List<Person>> GetByFirstName(string firstName)
    {
      return new SuccessDataResult<List<Person>>(_personDal.GetAll(p => p.FirstName == firstName));
    }

    public IDataResult<List<Person>> GetByLastName(string lastName)
    {
      return new SuccessDataResult<List<Person>>(_personDal.GetAll(p => p.LastName == lastName));
    }

    public IDataResult<List<Person>> GetByPhoneNumber(string phoneNumber)
    {
      return new SuccessDataResult<List<Person>>(_personDal.GetAll(p => p.PhoneNumber == phoneNumber));
    }

    public IDataResult<List<Person>> GetByUrl(string url)
    {
      return new SuccessDataResult<List<Person>>(_personDal.GetAll(p => p.Url == url));
    }

    public IResult Update(Person person)
    {
      _personDal.Update(person);
      return new SuccessResult(Messages.PersonUpdated);
    }
  }
}
