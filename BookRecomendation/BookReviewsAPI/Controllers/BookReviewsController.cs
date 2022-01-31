using BookRecomendationBusinessLayer;
using BookRecomendationDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookReviewsAPI.Controllers
{
    public class BookReviewsController : ApiController
    {
        BookRecomendationBL blobj;
        public BookReviewsController()
        {
            blobj = new BookRecomendationBL();
        }
        [HttpGet]
        public HttpResponseMessage GetRatingsForBook()
        {
            try
            {
                List<BookDTO> list = blobj.ShowReviewsForBook();
                if (list.Count > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, list);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.OK, "error");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.OK, "Catch");
            }
        }
    }
}
