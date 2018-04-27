using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Maled001;

namespace Maled001 {
    public class ProdottiController : ApiController {
        Maled dm = new Maled();
        // GET api/<controller>
        public Prodotto Get(int id) {
            return dm.SearchByCode(id);
        }
        public IEnumerable<Prodotto> Get(string descrizione) {
            return dm.SearchByDescrizione(descrizione);
        }

        // GET api/<controller>/5
        //public string Get(int id) {
        //    return "value";
        //}

        // POST api/<controller>
        public void Post([FromBody]string value) {
        }

        // PUT api/<controller>/5
        public void Put(int id,[FromBody]string value) {
        }

        // DELETE api/<controller>/5
        public void Delete(int id) {
        }
    }
}