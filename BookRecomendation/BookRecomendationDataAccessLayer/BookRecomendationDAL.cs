using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookRecomendationDTO;

namespace BookRecomendationDataAccessLayer
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class BookRecomendationDAL
    {
        SqlCommand command;
        SqlConnection connection;
        BookRecomendationContext bookContext;
        public BookRecomendationDAL()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Books"].ConnectionString);
           }



        public int FetchReviewsForBook(BookDTO dto)
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "uspAddReview";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@book_isbn", dto.isbn);
                command.Parameters.AddWithValue("@rating", dto.rating);
                command.Parameters.AddWithValue("@review", dto.review);
                SqlParameter retunVal = new SqlParameter();
                retunVal.Direction = ParameterDirection.ReturnValue;
                retunVal.SqlDbType= SqlDbType.Int;
                command.Parameters.Add(retunVal);
                return Convert.ToInt32(retunVal.Value);

            }
            catch (Exception)
            {
                return 99;
            }
        }

        public List<BookDTO> SaveReviewForBookToDB()
        {
            var result= bookContext.Books.ToList();
            List<BookDTO> lstBook = new List<BookDTO>();
            foreach(var book in result)
            {
                lstBook.Add(new BookDTO
                {
                    isbn = book.book_isbn,
                    edition = book.book_edition,
                });
               
            }
            return lstBook;
        }

}
}
