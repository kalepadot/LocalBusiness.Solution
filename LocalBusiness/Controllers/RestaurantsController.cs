using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RestaurantsController : ControllerBase
  {
    private LocalBusinessContext _db;

    public RestaurantsController(LocalBusinessContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> Get(string name, string type)
    {
      var query = _db.Restaurants.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }      

      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }
    [HttpGet("{id}")]
    public ActionResult<Restaurant> Get(int id)
    {
      return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
    } 
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Restaurant restaurant)
    {
        restaurant.RestaurantId = id;
        _db.Entry(restaurant).State = EntityState.Modified;
        _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var restaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
      _db.Restaurants.Remove(restaurantToDelete);
      _db.SaveChanges();
    }
  }
}