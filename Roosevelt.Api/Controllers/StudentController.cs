using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Roosevelt.Api.Models;
using System.IO;
using System;
using LumenWorks.Framework.IO.Csv;

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
                Console.WriteLine("Starting import CSV!");
                using (CsvReader csv = new CsvReader(new StreamReader("with_teacher.csv"), true))
                {
                    while(csv.ReadNextRecord())
                    {
                        _context.Students.Add(new Student {
                            Id=csv[0],
                            first_name=csv[1],
                            last_name=csv[2],
                            age=csv[3],
                            parent_1=csv[4],
                            parent_2=csv[5],
                            phone=csv[6],
                            attendance=csv[7],
                            days_membership=csv[8],
                            teacher_name=csv[9],
                            school=csv[10],
                            grade_year=csv[11],
                            y_summer_read=csv[12],
                            y_star_grade_equivalent=csv[13],
                            y_star_percentile=csv[14],
                            y_star_irl=csv[15]
                        });
                    }
                }
                _context.SaveChanges();
                Console.WriteLine("Finished importing CSV!");
            }
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAll()
        {
            return _context.Students.ToList();
        }

        [HttpGet("{teacher_name}", Name = "GetStudentByTeacher")]
        public ActionResult<List<Student>> GetbyTeacher(string teacher_name)
        {
            return _context.Students.Where(s => s.teacher_name == teacher_name).ToList();
        }
    }
}