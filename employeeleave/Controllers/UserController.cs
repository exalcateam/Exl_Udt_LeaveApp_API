using leaverequest.Datas;
using leaverequest.Models;
using leaverequest.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace leaverequest.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly IloginRepository _loginRepository;
        
        public UserController(IloginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<IActionResult> Create(login login)
        {
            await _loginRepository.Create(login);
            return Ok(login);


        }
        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetAll()
        {
           var user= await _loginRepository.GetAll();
            return Ok(user);
        }
        [HttpPost("authenticate")]

        public ActionResult <login> Authenticate([FromBody] login login)
        {
           return  _loginRepository.Authenticate(login);
    

        }
        [HttpPost("sendmail")]
        public bool Sendmail(string body )
        {
            return _loginRepository.Sendmail(body);
        }
        /*  [HttpDelete]
          public ActionResult DeleteByid(int id)
          {
              if (id == 0)
              {
                  return BadRequest();
              }
              var user = _dbcontext.Login.Find(id);
              if(user == null)
              {
                  return NotFound();
              }
              _dbcontext.Login.Remove(user);
              _dbcontext.SaveChanges();
              return Ok();
          }*/
        /*[HttpPut]
        [ProducesResponseType(200)]
        public ActionResult<login> Update([FromBody] login log)
        {
            _dbcontext.Login.Update(log);
            _dbcontext.SaveChanges();
            return Ok(log);
        }*/
        [HttpPost("createform")]
       
        public async Task<IActionResult> Create([FromBody]leaveform leaveform)
        {
            await _loginRepository.Createform(leaveform);
            return Ok(leaveform);


        }
       

    }
}
