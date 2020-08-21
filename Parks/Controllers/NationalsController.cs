using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Parks.Models;
using Microsoft.EntityFrameworkCore;

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

    // GET api/states
    [HttpGet]
    public ActionResult<IEnumerable<National>> Get()
    {
      return _db.Nationals.ToList();
    }

    // POST api/states
    [HttpPost]
    public void Post([FromBody] National state)
    {
      _db.Nationals.Add(state);
      _db.SaveChanges();
    }

    // GET api/states
    [HttpGet("{id}")]
    public ActionResult<National> Get(int id)
    {
      return _db.Nationals.FirstOrDefault(entry => entry.NationalId == id);
    }

    // PUT api/states
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] National state)
    {
      state.NationalId = id;
      _db.Entry(state).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/states
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var stateToDelete = _db.Nationals.FirstOrDefault(entry => entry.NationalId == id);
      _db.Nationals.Remove(stateToDelete);
      _db.SaveChanges();
    }
  }
}