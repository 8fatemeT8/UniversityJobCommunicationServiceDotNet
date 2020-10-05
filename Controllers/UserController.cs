using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("{id}")]
        public List<string> GetAlList(int id)
        {
            return new List<string> {"hi" + id, "hello" + id, "hey" + id};
        }
    }
}