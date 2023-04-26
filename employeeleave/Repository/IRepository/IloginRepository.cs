using leaverequest.Models;
using Microsoft.AspNetCore.Mvc;

namespace leaverequest.Repository.IRepository
{
    public interface IloginRepository
    {

        public Task<List<login>> GetAll();
        public Task Create(login login);
        public ActionResult<login> Authenticate([FromBody] login login);
        public bool Sendmail(string body);
        public Task Createform(leaveform leaveform);

        public Task Save();
    }  
}
