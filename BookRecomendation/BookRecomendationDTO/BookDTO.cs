using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecomendationDTO
{
    public class BookDTO
    {
        public int isbn { get; set; }
        public string title { get; set; }
        public int edition { get; set; }
        public int rating { get; set; }
        public string review { get; set; }

    }
}
