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
        private string filePath;

        private Books book;
        public BookReaderScreen(string filePath)
        {
            InitializeComponent();
            this.filePath= filePath;
            LoadBookContent();
        }

        private void LoadBookContent()
        {
            
        }
    }
}
