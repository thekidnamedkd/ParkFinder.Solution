using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Parks.Models;
using Microsoft.EntityFrameworkCore;

namespace Parks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StatesController : ControllerBase
  {
    private ParksContext _db;

    public StatesController(ParksContext db)
    {
      _db = db;
    }

    // GET api/states
    [HttpGet]
    public ActionResult<IEnumerable<State>> Get()
    {
      return _db.States.ToList();
    }

    // POST api/states
    [HttpPost]
    public void Post([FromBody] State state)
    {
      _db.States.Add(state);
      _db.SaveChanges();
    }

    // GET api/states
    [HttpGet("{id}")]
    public ActionResult<State> Get(int id)
    {
      return _db.States.FirstOrDefault(entry => entry.StateId == id);
    }

    // PUT api/states
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] State state)
    {
      state.StateId = id;
      _db.Entry(state).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/states
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var stateToDelete = _db.States.FirstOrDefault(entry => entry.StateId == id);
      _db.States.Remove(stateToDelete);
      _db.SaveChanges();
    }
  }
}