using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    public class Movie
    {
        public string Title { get; set; }
        public string Catagory { get; set; }
        public Movie(string title, string catagory)
        {
            Title = title;
            Catagory = catagory;
        }
    }
}
