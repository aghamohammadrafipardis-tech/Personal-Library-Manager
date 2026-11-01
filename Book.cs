using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni_project
{
    public class Book
    {
       
            public int ID { get; set; }
            public int UserID { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string Genre { get; set; }
            public int Year { get; set; }
            public string Status { get; set; }
            public int Rating { get; set; }
            public string Notes { get; set; }
            public string CoverPath { get; set; }
        }
    
}
