using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentInfoApp.Domain;
using StudentInfoApp.Model;

namespace StudentInfoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        public StudentController()
        {
            this.studentDomain = new StudentDomain();
        }

        [HttpPost]
        public IActionResult Post(Student  student)
        {
            studentDomain.Add(student);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(Student student)
        {
            studentDomain.Update(student);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            studentDomain.Delete(id);
            return Ok();
        }
        private StudentDomain studentDomain { get; set; }
    }
}
