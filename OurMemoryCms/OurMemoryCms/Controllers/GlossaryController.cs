// https://auth0.com/blog/how-to-build-and-secure-web-apis-with-aspnet-core-3/

using Microsoft.AspNetCore.Mvc;
using OurMemoryWebApi.Data;
using OurMemoryWebApi.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace OurMemoryWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GlossaryController : ControllerBase
    {
        [HttpPost]
        public ActionResult Post(GlossaryModel glossaryItem)
        {
            var existingGlossaryItem = Glossary.Data
                
                .Find(item =>
                    item.Term.Equals(glossaryItem.Term, StringComparison.InvariantCultureIgnoreCase));

            if (existingGlossaryItem != null)
            {
                return Conflict("Cannot create the term because it already exists.");
            }
            else
            {
                Glossary.Data.Add(glossaryItem);
                var resourceUrl = Path.Combine(Request.Path.ToString(), Uri.EscapeUriString(glossaryItem.Term));
                return Created(resourceUrl, glossaryItem);
            }
        }

        [HttpGet]
        public ActionResult<List<GlossaryModel>> Get()
        {
            return Ok(Glossary.Data);
        }

        [HttpGet]
        [Route("{term}")]
        public ActionResult<GlossaryModel> Get(string term)
        {
            var glossaryItem = Glossary.Data.Find(item =>
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

        [HttpPut]
        public ActionResult Put(GlossaryModel    glossaryItem)
        {
            var existingGlossaryItem = Glossary.Data.Find(item =>
            item.Term.Equals(glossaryItem.Term, StringComparison.InvariantCultureIgnoreCase));

            if (existingGlossaryItem == null)
            {
                return BadRequest("Cannot update a non-existing term.");
            }
            else
            {
                existingGlossaryItem.Definition = glossaryItem.Definition;
                return Ok();
            }
        }

        [HttpDelete]
        [Route("{term}")]
        public ActionResult Delete(string term)
        {
            var glossaryItem = Glossary.Data.Find(item =>
                   item.Term.Equals(term, StringComparison.InvariantCultureIgnoreCase));

            if (glossaryItem == null)
            {
                return NotFound();
            }
            else
            {
                Glossary.Data.Remove(glossaryItem);
                return NoContent();
            }
        }
    }
}