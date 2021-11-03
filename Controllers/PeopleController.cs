using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        /// <summary>
        /// This is where Info of People reside
        /// </summary>
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Time", Lastname = "Corey", Id = 1 });
            people.Add(new Person { FirstName = "Armie", Lastname = "Hammer", Id = 2 });
            people.Add(new Person { FirstName = "Anne", Lastname = "Derek", Id = 3 });
            people.Add(new Person { FirstName = "Bo", Lastname = "Monroe", Id = 4 });
        }
       /// <summary>
       /// Firstnames of all users
       /// Uses a custom Route method
       /// 
       /// </summary>
       /// <returns></returns>
        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirsNames()
        {
            List<string> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }


        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person value)
        {
            people.Add(value);
        }

   /// <summary>
   /// This method is not working yet.
   /// </summary>
   /// <param name="id"></param>
        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
