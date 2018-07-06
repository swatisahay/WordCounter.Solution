using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }


      }
      [TestClass]
      public class WordCounterControllerTest
      {
        [TestMethod]
          public void Index_HasCorrectModelType_WordCounterList()
          {
              //Arrange
              WordCounterController controller = new WordCounterController();
              IActionResult actionResult = controller.Index();
              ViewResult indexView = controller.Index() as ViewResult;

              //Act
              var result = indexView.ViewData.Model;

              //Assert
              Assert.IsInstanceOfType(result, typeof(List<RepeatCounter>));
          }

    }
}
