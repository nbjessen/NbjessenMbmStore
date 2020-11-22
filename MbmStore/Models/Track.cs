using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Track
    {

        //Fields

        //Properties
        public string Title { get; set; }
        public string Composer { get; set; }
        public TimeSpan Length { get; set; }

        //Constructor

       public Track (string title, string composer, TimeSpan length)
        {
            Composer = composer;
            Length = length;
            Title = title;
        }

        //Method
    }
}
