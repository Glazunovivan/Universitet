using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversistetAPI.Data;
using UniversistetAPI.Models;

namespace UniversistetAPI.Controllers
{
    [Route("api/group_teachers")]
    [ApiController]
    public class GroupsTeachersController : ControllerBase
    {
        private MainContext _context;
        public GroupsTeachersController(MainContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupTeacher>>> Get()
        {
            return Ok(await _context.GroupTeachers.Include(x=>x.Group).Include(x=>x.Teacher)
                            .ToListAsync());
        }

        [HttpPost]
        public IActionResult AddGroupForTeacher(int idTeacher, int idGroup)
        {
            if (_context.Teachers.Where(x => x.Id == idTeacher).SingleOrDefault() is null)
                return Content("Преподаватель не найден");
            if (_context.Groups.Where(x => x.Id == idGroup).SingleOrDefault() is null)
                return Content("Группа не найдена");

            var newGroupTeacher = new GroupTeacher();
            newGroupTeacher.GroupId = idGroup;
            newGroupTeacher.TeacherId = idTeacher;

            var group = _context.Groups.Where(x => x.Id == idGroup).SingleOrDefault();

            _context.GroupTeachers.Add(newGroupTeacher);
            _context.SaveChanges();

            return Content($"Курс {group} успешно");
        }

    }
}

