using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public interface IMovie
    {
        public string Nconst { get; set; }

        public string Tconst { get; set; }

        public string MovieTitle { get; set; }

        public string Country { get; set; }

        public decimal? AverageRating { get; set; }

        public int? NumVotes { get; set; }

        public string TitleType { get; set; }

        public int? StartYear { get; set; }

        public int? RuntimeMinutes { get; set; }

        public string Genres { get; set; }
    }
}
