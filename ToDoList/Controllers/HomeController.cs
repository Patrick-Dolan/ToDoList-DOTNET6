using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Item starterItem = new Item("Add first item to To Do List");
      return View(starterItem);
    }
  }
}