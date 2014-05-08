using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IceSubs.Models;

namespace IceSubs.Controllers
{
    public class MediaController : Controller
    {

        MediaRepository repository = new MediaRepository();
      
        public ActionResult Newest()
        {
            IQueryable<Medium> newestMedia = (from item in repository.GetAllMedia()
                                              orderby item.DateAdded descending
                                              select item);
            return View(newestMedia);
        }

        public ActionResult Popular()
        {
          
            IQueryable<Medium> mostPopular = (from item in repository.GetAllMedia()
                                              orderby item.Translation.Downloads descending
                                              select item);
            return View(mostPopular);
        }

        public ActionResult All()
        {
            IQueryable<Medium> allMedia = (from item in repository.GetAllMedia()
                                              orderby item.Title ascending
                                              select item);
            return View(allMedia);
        }

        public ActionResult Movies()
        {
            IQueryable<Medium> movieMedia = (from item in repository.GetAllMedia()
                                                where item.MediaType == "Movie"
                                                orderby item.Title ascending //sorted in alpha order
                                                select item);
            return View(movieMedia);
        }

        public ActionResult TvSeries()
        {
            IQueryable<Medium> movieMedia = (from item in repository.GetAllMedia()
                                                where item.MediaType == "TV Series"
                                                orderby item.Title ascending //sorted in alpha order
                                                select item);
            return View(movieMedia);
        }


        public ActionResult Detail() //detailed view, TODO: implement
        {
            return View();
        }


	}
}