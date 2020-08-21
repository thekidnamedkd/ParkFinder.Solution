using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Parks.Models;

namespace Parks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NationalsController : ControllerBase
  {
    private ParksContext _db;

    public NationalsController(ParksContext db)
    {
      _db = db;
    }

    // GET api/nationals
    [HttpGet]
    public ActionResult<IEnumerable<National>> Get()
    {
      return _db.Nationals.ToList();
    }

    // GET api/nationals
    [HttpGet("{id}")]
    public ActionResult<National> Get(int id)
    {
      return _db.Nationals.FirstOrDefault(entry => entry.NationalId == id);
    }

    //GET api/nationals/pages
    [HttpGet ("pages")]
    public async Task<IActionResult> GetAll([FromQuery] UrlQuery urlQuery)
    {
        var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
        var pagedData = _db.Nationals
          .OrderBy(thing => thing.NationalId)
          .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
          .Take(validUrlQuery.PageSize);
        return Ok(pagedData);
    }

    // POST api/nationals
    [HttpPost]
    public void Post([FromBody] National state)
    {
      _db.Nationals.Add(state);
      _db.SaveChanges();
    }

    // PUT api/nationals
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] National state)
    {
      state.NationalId = id;
      _db.Entry(state).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/nationals
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var stateToDelete = _db.Nationals.FirstOrDefault(entry => entry.NationalId == id);
      _db.Nationals.Remove(stateToDelete);
      _db.SaveChanges();
    }
  }
}