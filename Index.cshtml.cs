using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieHW.Pages
{
    public class IndexModel : PageModel
    {
        public  List<Movies1> MyMovies { get; set; } = new List<Movies1>();
        public string MainTitle2 { get; set; }
        public string[] Movies2 { get; set; }

        public void OnGet()
        {
            MyMovies.Add(new Movies1
            {
                MovieId = 23,
                Title = "Black Panther",
                Director = "Onomatopoeia",
                Rating = 98
            });
            MyMovies.Add(new Movies1
            {
                MovieId = "2345jweiouhwekl2j3",
                Title = " Igodo",
                Director = "Boye Bright",
                Rating = 45
            });
            MyMovies.Add(new Movies1
            {
                MovieId = 456,
                Title = "The gods are not to be Blamed",
                Director = "Wole Soyinka",
                Rating = 80.3
            });

            MainTitle2 = "Movie Time!";
            Movies2 = new string[] { "Black Panther", "Igodo", "The gods are not to be Blamed" };
        }
    }
}
