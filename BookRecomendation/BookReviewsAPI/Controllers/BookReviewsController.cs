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
        Ib ibobj;
        public BookReviewsController() : this(new BookRecomendationBL())
        { }
        public BookReviewsController(Ib blobj)
        {
            blobj = ibobj;
        }
        [HttpGet]
        public HttpResponseMessage GetRatingsForBook()
        {
            try
            {
                List<BookDTO> list = ibobj.ShowReviewsForBook();
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
