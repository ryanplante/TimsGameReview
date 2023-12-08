using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorReview.Models
{
    public class RatingModel
    {
        public int Id { get; set; }
        public int CustID { get; set; }
        public int GameID { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
    }
}
