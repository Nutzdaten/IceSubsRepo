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
      
        public ActionResult Newest()
        {
            MediaRepository repository = new MediaRepository();

            IQueryable<Medium> newestMedia = (from item in repository.GetAllMedia()
                                              orderby item.DateAdded descending
                                              select item);
            return View(newestMedia);
        }

        public ActionResult Popular()
        {
            //need to use union here 
            //no connection between media and rating...
            return View();
        }

        public ActionResult All()
        {
            MediaRepository repository = new MediaRepository();
            IQueryable<Medium> AllMedia = (from item in repository.GetAllMedia()
                                              orderby item.Title ascending
                                              select item);
            return View(AllMedia);
        }

        public ActionResult Movies()
        {
            MediaRepository repository = new MediaRepository();
            IQueryable<Medium> MovieMedia = (from item in repository.GetAllMedia()
                                                where item.MediaType == "Movie"
                                                orderby item.Title ascending //sorted in alpha order
                                                select item);
            return View(MovieMedia);
        }

        public ActionResult TvSeries()
        {
            MediaRepository repository = new MediaRepository();
            IQueryable<Medium> MovieMedia = (from item in repository.GetAllMedia()
                                                where item.MediaType == "TV Series"
                                                orderby item.Title ascending //sorted in alpha order
                                                select item);
            return View(MovieMedia);
            return View();
        }


        public ActionResult Detail() //detailed view
        {
            return View();
        }


	}
}