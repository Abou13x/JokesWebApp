using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public int JokeQuestion { get; set; }
        public int JokeAnswer { get; set; }
        public Joke()
        {

        }
    }
}