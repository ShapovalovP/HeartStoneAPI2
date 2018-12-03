using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartStoneAPI.Models
{
    public class Partie
    {
        public int Id { get; set; }
      

        public virtual List<Joueur> Joueurs { get; set; }
        public virtual List<Deck> Decks { get; set; }
        public virtual List<Tour> Tours { get; set; }
    }
}