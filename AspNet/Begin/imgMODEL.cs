using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin.Models
{
    public static class imgMODEL
    {
        public static List<imgItem> images = new List<imgItem>
        {
            new imgItem{ID=1,Title="Cloud",Link="1.jpeg"},
            new imgItem{ID=2,Title="Cloud",Link="2.jpeg"},
            new imgItem{ID=3,Title="Cloud",Link="3.jpeg"},
            new imgItem{ID=4,Title="Cloud",Link="4.jpeg"},
            new imgItem{ID=5,Title="Cloud",Link="5.jpeg"},
            new imgItem{ID=6,Title="Cloud",Link="6.jpeg"},

        };

        public static List<imgItem> GetimgItem() => images;
    }

    public class imgItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
