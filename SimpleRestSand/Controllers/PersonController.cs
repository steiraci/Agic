using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleRestSand.Models;

namespace SimpleRestSand.Controllers
{
    public class PersonController : ApiController
    {
        // GET: api/Person
        public IEnumerable<string> Get()
        {
            return new string[] { "Person", "Person2" };
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            Person mPerson = new Person();

            mPerson.Affitto = 0;
            mPerson.Nome = "Mario";
            mPerson.Cognome = "rossi";
            mPerson.StardtDate = DateTime.Now.AddDays(-15);
            mPerson.EndDate = DateTime.Now;


            switch (id)
            {
                case 1:
                    mPerson.Nome = "Mario Uno";
                    return mPerson;

                case 2:
                    mPerson.Nome = "Mario Due";
                    return mPerson;

                default:
                    return mPerson; 
            }

            
        }


        // Nel parametro di input ho messo il mio modello definito nella classe Models
        // POST: api/Person
        public void Post([FromBody]Person value)
        {

            if (value.Nome == "Mario")
            {
                string aaa = "1";
            }


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
