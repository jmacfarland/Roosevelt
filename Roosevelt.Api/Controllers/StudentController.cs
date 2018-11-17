using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Roosevelt.Api.Models;

namespace Roosevelt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;

            if (_context.Students.Count() == 0)
            {
                // Populate database
                _context.Students.Add(new Student { first_name = "John" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAll()
        {
            return _context.Students.ToList();
        }

        [HttpGet("{id}", Name = "GetStudent")]
        public ActionResult<Student> GetById(long id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return student;
        }
    }
}