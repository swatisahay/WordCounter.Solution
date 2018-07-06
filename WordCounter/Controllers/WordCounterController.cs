using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/RepeatCounter")]
    public ActionResult Index()
    {
      List<RepeatCounter> allWords = RepeatCounter.GetAll();
      return View(allWords);
    }
    [HttpGet("/RepeatCounter/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/RepeatCounter")]
    public ActionResult Create()
    {
      RepeatCounter newWord = new RepeatCounter(Request.Form["word"],Request.Form["sentence"]);
      List<RepeatCounter> allWords = RepeatCounter.GetAll();
      return View("Index", allWords);
    }
    // [HttpGet("/Places/{id}")]
    // public ActionResult Details(int id)
    // {
    //   PlacesObject place = PlacesObject.Find(id);
    //   return View(place);
    // }
    // [HttpPost("/Places/delete")]
    // public ActionResult DeleteAll()
    // {
    //   PlacesObject.ClearAll();
    //   return View();
    // }

  }
}
