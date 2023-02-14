using Boake_BackEnd.Models;
using System.Collections.Generic;

namespace Boake_BackEnd.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Book> Books { get; set; }

    }
}
