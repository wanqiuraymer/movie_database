using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_database_lab
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public int SearchNumber {  get; set; }

        public Movie(string title, string category, int searchNumber, int year) 
        { 
            this.Title = title;
            this.Category = category;
            this.Year = year;
            this.SearchNumber = searchNumber;
        }


    }
}
