using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class News
    {
        public String Title { get;}
        public String Content { get;}

        public News(String title, String content)
        {
            Title = title;
            Content = content;
        }
    }
}
