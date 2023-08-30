using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversistetAPI.Data;
using UniversistetAPI.Models;

namespace UniversistetAPI.Controllers
{
    [Route("api/group_students")]
    [ApiController]
    public class GroupsStudentsController : ControllerBase
    {
        private MainContext _context;
        public GroupsStudentsController(MainContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupStudent>>> Get()
        {
            return Ok(await _context.GroupStudents
                            .Include(x=>x.Student)
                            .Include(x=>x.Group)
                            .ToListAsync());
        }


        [HttpPost]
        public IActionResult AddGroupForStudent(int idStudent, int idGroup)
        {
            if (_context.Students.Where(x => x.Id == idStudent).SingleOrDefault() is null)
                return Content("Студент не найден");
            if (_context.Groups.Where(x => x.Id == idGroup).SingleOrDefault() is null)
                return Content("Группа не найдена");

            var newGroupStudent = new GroupStudent();
            newGroupStudent.CourseId = idGroup;
            newGroupStudent.StudentId = idStudent;

            var group = _context.Groups.Where(x => x.Id == idGroup).SingleOrDefault();

            _context.GroupStudents.Add(newGroupStudent);
            _context.SaveChanges();

            return Content($"Курс {group} успешно");
        }
    }
}