using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEducation.Model
{
    public class Education
    {
        //Message id
        public int Id { get; set; }

        //Mesage text
        public string course { get; set; }

        //Message sender
        public string content { get; set; }

        //Message time
        public DateTime time { get; set; }
    }
}
