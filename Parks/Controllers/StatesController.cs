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

    // GET api/nationals/stateid#
    [HttpGet("{StateId}")]
    public ActionResult<State> Get(int stateId)
    {
        return _db.States.FirstOrDefault(entry => entry.StateId == stateId);
    }


    // GET api/states/search
    [HttpGet ("search")]
    public ActionResult<IEnumerable<State>> Get(int stateId, string stateParkName, string stateName, int stateParkYear)
    {
      var query = _db.States.AsQueryable();
      if (stateId != 0)
      {
        query = query.Where(entry => entry.StateId == stateId);
      }
      if (stateParkName != null)
      {
        query = query.Where(entry => entry.StateParkName == stateParkName);
      }
      if (stateName != null)
      {
        query = query.Where(entry => entry.StateName == stateName);
      }
      if (stateParkYear != 0)
      {
        query = query.Where(entry => entry.StateParkYear == stateParkYear);
      }

      return query.ToList();
    }

      //GET api/states/pages
    [HttpGet ("pages")]
    public async Task<IActionResult> GetAll([FromQuery] UrlQuery urlQuery)
    {
        var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
        var pagedData = _db.States
          .OrderBy(thing => thing.StateId)
          .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
          .Take(validUrlQuery.PageSize);
        return Ok(pagedData);
    }

    // POST api/states
    [HttpPost]
    public void Post([FromBody] State state)
    {
      _db.States.Add(state);
      _db.SaveChanges();
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