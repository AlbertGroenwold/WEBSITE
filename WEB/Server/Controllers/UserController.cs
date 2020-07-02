using WEB.Shared;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WEB.Server.src;

namespace WEB.Server.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        UserDataAccessLayer objuser = new UserDataAccessLayer();
        [HttpGet]
        [Route("api/User/Index")]
        public IEnumerable<UsersModel> Index()
        {
            return objuser.GetAllUsers();
        }
        [HttpPost]
        [Route("api/User/Create")]
        public void Create([FromBody] UsersModel user)
        {
            if (ModelState.IsValid) objuser.AddUser(user);
        }
        [HttpGet]
        [Route("api/User/Details/{id}")]
        public UsersModel Details(string id)
        {
            return objuser.GetUserData(id);
        }
        [HttpPut]
        [Route("api/User/Edit")]
        public void Edit([FromBody] UsersModel user)
        {
            if (ModelState.IsValid) objuser.UpdateUser(user);
        }
        [HttpDelete]
        [Route("api/User/Delete/{id}")]
        public void Delete(string id)
        {
            objuser.DeleteUser(id);
        }
    }
}
