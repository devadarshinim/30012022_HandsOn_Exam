using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookRecomendationDataAccessLayer;
using BookRecomendationDTO;

namespace BookRecomendationBusinessLayer
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required. 
    public class BookRecomendationBL:Ib
    {
        BookRecomendationDAL dal;
        public BookRecomendationBL()
        {
            dal= new BookRecomendationDAL();
        }

        public List<BookDTO> ShowReviewsForBook()
        {
            return dal.SaveReviewForBookToDB();
        }


        public int AddReviewForBook(BookDTO dto)
        {
            return dal.FetchReviewsForBook(dto);


        }
      
    }
}
