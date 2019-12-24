using Microsoft.AspNetCore.Mvc;
using OurMemoryWebApi.Data;
using OurMemoryWebApi.Models;
using System;
using System.Collections.Generic;

namespace OurMemoryWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GlossaryController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<GlossaryModel>> Get()
        {
            return Ok(Glossary.GetList());
        }

        [HttpGet]
        [Route("{term}")]
        public ActionResult<GlossaryModel> Get(string term)
        {
            var glossaryItem = Glossary.GetList().Find(item =>
                    item.Term.Equals(term, StringComparison.InvariantCultureIgnoreCase));

            if (glossaryItem == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(glossaryItem);
            }
        }
    }
}