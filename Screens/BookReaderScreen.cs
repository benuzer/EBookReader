using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookReader
{
    public partial class BookReaderScreen : Form
    {

        private Books book;
        public BookReaderScreen(Books selectedBook)
        {
            InitializeComponent();
            book = selectedBook;
            LoadBookContent();
        }

        private void LoadBookContent()
        {
            
        }
    }
}
