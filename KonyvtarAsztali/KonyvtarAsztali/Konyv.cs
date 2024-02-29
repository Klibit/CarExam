using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarAsztali
{
    internal class Konyv
    {
        int id;
        string author;
        int page_count;
        int publish_year;
        string title;

        public int Id { get => id; set => id = value; }
        public string Author { get => author; set => author = value; }
        public int Page_count { get => page_count; set => page_count = value; }
        public int Publish_year { get => publish_year; set => publish_year = value; }
        public string Title { get => title; set => title = value; }

        public Konyv(int id, string author, int page_count, int publish_year, string title)
        {
            Id = id;
            Author = author;
            Page_count = page_count;
            Publish_year = publish_year;
            Title = title;
        }

        public override string ToString()
        {
            return this.author + " " + this.Title;
        }
    }
}
