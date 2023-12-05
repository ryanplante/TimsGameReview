using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class GameRatingModel
    {
        public int CustID { get; set; }

        public int GameID { get; set; }

        public float Rating { get; set; }

        public string Review { get; set; }
    }
}
