using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRichard.Models
{
    public class BookModel
    {
        public int IDNO;
        public string Chapter;

        public BookModel(int id, string chapter)
        {
            IDNO = id;
            Chapter = chapter;
        }
    }
}