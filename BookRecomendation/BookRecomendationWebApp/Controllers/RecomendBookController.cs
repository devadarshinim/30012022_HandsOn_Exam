using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BookRecomendationBusinessLayer;
using BookRecomendationDTO;
using BookRecomendationWebApp.Models;
using Newtonsoft.Json;

namespace BookRecomendationWebApp.Controllers
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class RecomendBookController : Controller
    {
        BookRecomendationBL blobj;
        public RecomendBookController()
        {
            blobj= new BookRecomendationBL();
        }
        // GET: RecomendBook
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult AddReviews()
        {
            try
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult AddReviews(BookViewModel bookModel)
        {
            try
            {
                BookDTO bookDTO = new BookDTO();
                bookDTO.isbn = bookModel.isbn;
                bookDTO.rating = bookModel.rating;
                bookDTO.review= bookDTO.review;
                int result= blobj.AddReviewForBook(bookDTO);
                if(result==0)
                {
                    return View();
                }
                else
                {
                    return View("Error");
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        public void DisplayResultsUsingWebAPI()
        {

        }
    }
}