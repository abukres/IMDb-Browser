using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public interface IActor
    {
        public string Nconst { get; set; }

        public string Tconst { get; set; }

        public string ActorName { get; set; }

        public int? BirthYear { get; set; }

        public int? DeathYear { get; set; }

        public string PrimaryProfession { get; set; }

        public string Country { get; set; }

    }
}
