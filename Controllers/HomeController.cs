using Microsoft.AspNetCore.Mvc;
using Poem.Models;

namespace Poem.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Hello()
    {
      Poems myPoem = new Poems();
      myPoem.SetRecipient("Jill");
      return View(myPoem);
    }

    [Route("/goodbye")]
    public string Goodbye() { return "Hope you had a good time";}

    [Route("/photos")]
    public ActionResult FavoritePhotos()
    {
      return View();
    }

    // [Produces("text/html")]
    // [Route("/")]
    // public string Poem() {
    //   return
      // "<!DOCTYPE html>" +
      // "<html>" +
      // "<head>" +
      //   "<title>Hello Friend!</title>" +
      //   "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>" +
      //   "<link rel='stylesheet' href=/css/styles.css'>" +
      // "</head>" +
      // "<body>" +
      //   "<h1>The Game of Life</h1><br>" +
      //   "<p>The hardest lessons learned in life</p>" +
      //   "<p>Are dealt and earned with grief.</p>" +
      //   "<p>A hundred spans of pain and strife;</p>" +
      //   "<p>A stretch of lost belief</p><br>" +
      //
      //   "<p>No matter what, or why, or when,</p>" +
      //   "<p>Or how, and who's to blame</p>" +
      //   "<p>It comes around, and comes again,</p>" +
      //   "<p>And always hurts the same</p><br>" +
      //
      //   "<p>I've failed a thousand times before.</p>" +
      //   "<p>I've felt my chances fall.</p>" +
      //   "<p>But I'd rather fail a thousand more</p>" +
      //   "<p>Than never try at all</p><br>" +
      //
      //   "<p>GB2017</p>" +
      //   "<br>" +
      //   "<p><a href='/photos'> PS, here are some of my favorite pictures that I have taken</a></p>" +
      // "</body>" +
      // "</html>";
    }
    //
    // [Produces("text/html")]
    // [Route("/photos")]
    // public string Photos()
    // {
    //   return
    //   "<!DOCTYPE html>" +
    //   "<html>" +
    //     "<head>" +
    //       "<title>Hello Friend!</title>" +
    //       "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>" +
    //     "</head>" +
    //     "<body>" +
    //       "<h1>Favorite Photos</h1>" +
    //       "<ul>" +
    //         "<li><img src='img/pikeplace.jpg'></li>" +
    //         "<li><img src='img/bracketts.jpg'></li>" +
    //         "<li><img src='img/amazon.jpg'></li>" +
    //       "</ul>" +
    //     "</body>" +
    //   "</html>";
    // }
  }
