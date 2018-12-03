using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartStoneAPI.Models
{
    public class Joueur
    {
        public int Id { get; set; }
       // public virtual Deck Deck { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Partie Partie { get; set; }
    }
}