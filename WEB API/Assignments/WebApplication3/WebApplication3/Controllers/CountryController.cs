using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CountryController : ApiController
    {
        List<Country> list = new List<Country>()
        {
            new Country{countryCapital="Delhi", countryId=1,countryName="India"},
            new Country{countryCapital="Canberra", countryId=2,countryName="Australia"}
        };
        [HttpGet]
        public IEnumerable<Country> getAll()
        {
            return list;
        }
        [HttpPost]
        public IEnumerable<Country> Create(Country country)
        {
            list.Add(country);
            return list;
        }
        [HttpPut]
        public IEnumerable<Country> Update(int id,[FromUri] int cid, string name, string capital)
        {
            Country c = new Country { countryId = cid, countryName = name, countryCapital = capital };
            list[id - 1] = c;
            return list;

            
        }
        [HttpDelete]
        public IEnumerable<Country> Delete(int id)
        {
            list.RemoveAt(id-1);

            return list;
        }

    }
}
