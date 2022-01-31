using BookRecomendationDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecomendationBusinessLayer
{
    public interface Ib
    {
        List<BookDTO> ShowReviewsForBook();
    }
}
