using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleRESTServer.Models;

namespace SimpleRESTServer.Controllers
{
    public class PersonController : ApiController
    {
        // GET: api/Person
        public IEnumerable<string> Get()
        {
            return new string[] { "Person1", "Person2" };
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            Person osoba = new Person();

            osoba.ID = 1;
            osoba.FirstName = "Almir";
            osoba.LastName = "Garic";
            osoba.PayRate = 10000;
            osoba.StartDate =DateTime.Parse("06/01/2017");
            osoba.EndDate = DateTime.Parse("06/01/2018");

            return osoba;
        }

        // POST: api/Person
        public void Post([FromBody]Person value)
        {
            PersonPersistence pp = new PersonPersistence();
            long id;
            id = pp.SavePerson(value);
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
