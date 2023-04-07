using leaverequest.Datas;
using leaverequest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace leaverequest.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class UserController : Controller
    {
       private readonly ApplicationDbcontext _dbcontext;
        public UserController(ApplicationDbcontext dbcontext) 
        {
            _dbcontext= dbcontext;
        }
        [HttpPost]
        [ProducesResponseType(200)]
        public ActionResult<login> create([FromBody] login log)
        {
            _dbcontext.Login.Add(log);
            _dbcontext.SaveChanges();
            return Ok();
        }
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult <List<login>> GetAll()
        {
            return _dbcontext.Login.ToList();
        }
        [HttpPost("authenticate")]
        [ProducesResponseType(200)]
        public ActionResult<login> Authenticate([FromBody] login log)
        {
            if(log == null) {
                return BadRequest(); 
            }
           
            var user=_dbcontext.Login.FirstOrDefault(x=>x.username==log.username && x.password==log.password);
            if (user.username!=log.username && user.username!=log.username)
            {
                return NotFound();
            }
            /* return Ok(new { message = "login sucess" });*/
            return Ok(user);

        }   
        [HttpDelete]
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
        }
        [HttpPut]
        [ProducesResponseType(200)]
        public ActionResult<login> Update([FromBody] login log)
        {
            _dbcontext.Login.Update(log);
            _dbcontext.SaveChanges();
            return Ok(log);
        }



    }
}
