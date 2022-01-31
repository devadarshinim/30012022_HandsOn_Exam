﻿using System;
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
                retunVal.ParameterDirection=

            }
            catch (Exception)
            {
                return 99;
            }
        }

        public void SaveReviewForBookToDB()
        {
        }

}
}
