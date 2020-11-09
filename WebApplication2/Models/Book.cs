using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string AuthorName { get; set; }
        public int price { get; set; }
    }
}