using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversistetAPI.Data;
using UniversistetAPI.Models;

namespace UniversistetAPI.Controllers
{
    [ApiController]
    [Route("api/groups")]
    public class GroupController : Controller
    {
        private MainContext _context;

        public GroupController(MainContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Group>>> Get()
        {
            return Ok(await _context.Groups.ToListAsync());

        }

        [HttpGet("{id}")]
        public Group GetById(int id)
        {
            var group = _context.Groups.Where(x => x.Id == id).SingleOrDefault();

            return group;
        }

        [HttpPost]
        public Group AddGroup(Group group)
        {
            _context.Groups.Add(group);
            _context.SaveChanges();

            return group;
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteGroup(int id)
        {
            _context.Groups.Remove(_context.Groups.Where(x => x.Id == id).SingleOrDefault());
            _context.SaveChanges();
            return Ok();
        }
    }
}
