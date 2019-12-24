using OurMemoryWebApi.Data;
using OurMemoryWebApi.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace OurMemoryWebApi.Controllers
{
    public class GlossaryController : ApiController
    {
        [HttpGet]
        public List<GlossaryModel> Get()
        {
            return Glossary.GetList();
        }

        [HttpGet]
        public GlossaryModel Get(string term)
        {
            var glossaryItem = Glossary.GetList().Find(item =>
                    item.Term.Equals(term, StringComparison.InvariantCultureIgnoreCase));

            if (glossaryItem == null)
            {
                return null;
            }
            else
            {
                return glossaryItem;
            }
        }
    }
}