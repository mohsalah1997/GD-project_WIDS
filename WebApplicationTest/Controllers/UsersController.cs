using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest.Data;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }
        // GET: api/Alert
        [HttpGet]
        public IEnumerable<user> Get() => _context.tbl_login.ToList();
        [Route("email/{i}")]
        [HttpPost]
        public IActionResult Post(int i)
        {
            var entity = _context.tbl_login.FirstOrDefault(item => item.user_id == i);
            if (entity != null)
            {
                // Answer for question #2

                // Make changes on entity
                entity.status = 1;


                // Update entity in DbSet
              _context.tbl_login.Update(entity);

                // Save changes in database
                _context.SaveChanges();
            }

            return Ok();
        }
    }
}