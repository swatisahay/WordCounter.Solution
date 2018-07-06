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
      return RedirectToAction("Index");
    }


  }
}
