using leaverequest.Datas;
using leaverequest.Models;
using leaverequest.Repository.IRepository;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimeKit;

namespace leaverequest.Repository.Repository
{
    public class loginRepository : IloginRepository
    {
        private readonly ApplicationDbcontext _dbcontext;
        public loginRepository(ApplicationDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public  ActionResult <login> Authenticate([FromBody]login login)
        {
            var user =  _dbcontext.Login.FirstOrDefault(x => x.username == login.username && x.password==login.password);
            if (user== null)
            {
                return null;
            }

            return user;
           
            
        }

        public async Task Create([FromBody] login login)
        {
           await _dbcontext.Login.AddAsync(login);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<login>> GetAll()
        {
           return await _dbcontext.Login.ToListAsync();
        }

        public async Task Save()
        {
            await _dbcontext.SaveChangesAsync();
        }
        
        public bool Sendmail(string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("laurence.kiehn@ethereal.email"));
            email.To.Add(MailboxAddress.Parse("laurence.kiehn@ethereal.email"));
            email.Subject = "Enter this OTP number to reset your password";
            email.Body=new TextPart(MimeKit.Text.TextFormat.Html) { Text=body };
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.ethereal.email",587,MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate("laurence.kiehn@ethereal.email", "t7J6FKRecENXQHpZXM");
            smtp.Send(email);
            smtp.Disconnect(true);
            return true;

            
        }
        public async Task Createform([FromBody] leaveform leaveform)
        {
            leaveform.Login = null;
          await _dbcontext.Leaveform.AddAsync(leaveform);
            await _dbcontext.SaveChangesAsync();
          
            
        }
       
       

      
    }
}
