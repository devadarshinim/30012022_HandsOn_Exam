using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookReviewsAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookRecomendationDTO;

namespace BookReviewsAPI.Controllers.Tests
{
    [TestClass()]
    public class BookReviewsControllerTests
    {
        [TestMethod()]
        public void GetRatingsForBookTest()
        {
            List<BookDTO> LST = new List<BookDTO>();
            BookDTO fakedata = new BookDTO();
            fakedata.isbn = 123;
            fakedata.review = "gooood";
            fakedata.rating = 7;
            LST.Add(fakedata);
            Mock<Ib> mockobj = new Mock<Ib>;
            mockobj.setup(x=> x.ShowReviewsForBook()).Returns(LST);
            //
        }
    }
}