using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookForm
{
    public class Book
    {
        private string _bookName;
        public string BookName
        {
            get { return _bookName; }
            set
            {
                if (value.Trim().Length>2)
                {
                    _bookName = value;
                }
                else
                {
                    throw new ArgumentException("Book name can not be less 2 chars");
                }
            }      
        }

        public int ISBNumber { get; set; }
        public byte BookPrice { get; set; }
        public int GenreId { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            return $"{BookName} {ISBNumber} {BookPrice} {Genre}";
        }
    }
}
