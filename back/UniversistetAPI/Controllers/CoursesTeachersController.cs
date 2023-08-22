using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversistetAPI.Data;
using UniversistetAPI.Models;

namespace UniversistetAPI.Controllers
{
    [Route("api/course_teachers")]
    [ApiController]
    public class CoursesTeachersController : ControllerBase
    {
        private MainContext _context;
        public CoursesTeachersController(MainContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseStudent>>> Get()
        {
            return Ok(await _context.CourseTeachers.ToListAsync());
        }

        [HttpPost]
        public Course AddCourseForTeacher(int idTeacher, int idCourse )
        {
            var teacher = _context.Teachers.FirstOrDefault(t => t.Id == idTeacher);
            var course = _context.Courses.FirstOrDefault(c => c.Id == idCourse);

            if (teacher == null || course == null)
            {
                // Обработайте ситуацию, если учитель или курс с заданными идентификаторами не найдены.
                // Возможно, верните сообщение об ошибке или сгенерируйте исключение.
            }

            var teacherCourse = new CourseTeacher
            {
                TeacherId = idTeacher,
                CourseId = idCourse
            };
            _context.CourseTeachers.Add(teacherCourse);
            _context.SaveChanges();


            return course;
        }

    }
}
