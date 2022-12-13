using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using TAO.Phone.Directory.Business.Abstract;
using TAO.Phone.Directory.Business.Constans;
using TAO.Phone.Directory.Entity.Concrete;
using TAO_Core.Utilities.Results;
using TAO_Core.Utilities.Results.Abstract;
using TAO_Core.Utilities.Results.Concrete;

namespace TAO.Phone.Directory.Business.Concrete
{
  public class MailManager : IMailService
  {
    public IResult Add(Mail mail)
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Person>> GetAll()
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Person>> GetByBody(string subject)
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Person>> GetBySentDate(DateTime sentDate)
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Person>> GetBySentTo(string sentTo)
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Person>> GetBySubject(string subject)
    {
      throw new NotImplementedException();
    }

    public IResult SendMail(Mail mail)
    {

      string mailClient = "smtp.office365.com"; //smtp client

      
        SmtpClient smtpClient = new SmtpClient();
        MailMessage mailMessage = new MailMessage();
        mailMessage.To.Add(mail.SentTo);

        if (mail.CC != null)
        {
          mailMessage.CC.Add(mail.CC);
        }
        if (mail.FilePath != null)
        {
          Attachment attachment = new Attachment(mail.FilePath, MediaTypeNames.Application.Octet);
          mailMessage.Attachments.Add(attachment);
        }


        mailMessage.From = new MailAddress(mail.Sender);
        mailMessage.Subject = mail.Subject;
        mailMessage.IsBodyHtml = true;
        mailMessage.Body = mail.Body;

        NetworkCredential networkCredential = new NetworkCredential(mail.Sender, mail.Password);
        smtpClient.Credentials = networkCredential;
        smtpClient.Port = 587;
        smtpClient.Host = mailClient;
        smtpClient.EnableSsl = true;
        smtpClient.Send(mailMessage);

        smtpClient = null;
        mailMessage = null;
        networkCredential = null;


        return new SuccessResult(Messages.MailSent);
      
    }
  }

}

