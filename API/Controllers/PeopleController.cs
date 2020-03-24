using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        public PeopleController()
        {
            people.Add(new Person { Name = "Gibran", Lastname = "Turbi", ID = 1, Carrera = "Software"});
            people.Add(new Person { Name = "Oswald", Lastname = "Moreno", ID = 2, Carrera = "Multimedia"});
            people.Add(new Person { Name = "Manuel", Lastname = "Salcedo", ID = 3, Carrera = "Mecatronica"});
            people.Add(new Person { Name = "Edward", Lastname = "Colon", ID = 4, Carrera = "Redes"});
            people.Add(new Person { Name = "Nestor", Lastname = "Velasquez", ID = 5, Carrera = "Sonido"});
        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.ID == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person value)
        {
            people.Add(value);
        }

        //// PUT: api/People/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE: api/People/5
        //public void Delete(int id)
        //{

        //}
    }
}
