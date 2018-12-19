using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Post 
    {
        public Person Author { get; private set; }
        public string Message { get; private set; }
        public DateTime DateAndTimeOfPosting { get; private set; }
    }
}
