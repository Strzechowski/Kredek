using RafalStrzechowskiLab5.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace RafalStrzechowskiLab5.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
        private static readonly List <StudentDto> _students;

        

        static StudentsController()
        {
            _students = new List<StudentDto>
            {
             new StudentDto {Id = 1, FirstName = "Jan", LastName = "Kowalski", City = "Wrocław" },
             new StudentDto { Id = 2, FirstName = "Maciej", LastName = "Nowak", City = "Kraków"  },
             new StudentDto { Id = 3, FirstName = "Adam", LastName = "zięba", City = "Warszawa" }
            };
        }

        [HttpGet, Route("")]
        [ResponseType(typeof(List<StudentDto>))]
        public IHttpActionResult Get()
        {
            return Ok(_students);
        }

        [HttpGet, Route("{id:int}", Name = "GetStudent")]
        [ResponseType(typeof(StudentDto))]
        public IHttpActionResult Get(int id)
        {
            var student = _students.SingleOrDefault(x => x.Id == id);

            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost, Route("")]
        public IHttpActionResult Post([FromBody]StudentDto student)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var maxId = _students.Max(x => x.Id);
            student.Id = ++maxId;

            _students.Add(student);

            return CreatedAtRoute("GetStudent", new { id = student.Id }, student);
        }

        [HttpPut, Route("{id:int}")]
        public IHttpActionResult Put([FromBody]StudentDto student, int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var studentToEdit = _students.SingleOrDefault(x => x.Id == id);
            if (studentToEdit == null)
            {
                return NotFound();
            }
            studentToEdit.FirstName = student.FirstName;
            studentToEdit.LastName = student.LastName;
            studentToEdit.City = student.City;

            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpDelete, Route("{id:int}")]
        public IHttpActionResult Delete (int id)
        {
            var student = _students.SingleOrDefault(x => x.Id == id);
            if(student == null)
            {
                return NotFound();
            }
            _students.Remove(student);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
