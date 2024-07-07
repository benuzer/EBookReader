using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookReader
{
    public class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public Image CoverImage { get; set; }
        public string Category { get; set; }
        public string ContentFilePath { get; set; }

   }
}
