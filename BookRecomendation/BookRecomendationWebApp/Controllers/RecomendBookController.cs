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
        public ActionResult(BookViewModel bookModel)
        {
            try
            {
                BookDTO bookDTO = new BookDTO();
                bookDTO.isbn = bookModel.isbn;
                bookDTO.rating = bookModel.rating;
                bookDTO.review= bookDTO.review;
                int result= 
            }
        }

        public void DisplayResultsUsingWebAPI()
        {

        }
    }
}