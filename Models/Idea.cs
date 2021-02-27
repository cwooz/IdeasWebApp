using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeasWebApp.Models
{
    public class Idea
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public Idea()
        {

        }
    }
}
