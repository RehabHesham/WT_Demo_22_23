using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescktopGame.Models
{
    internal class GameScore
    {
        public int Id { get; set; }
        public string PlayerXName { get; set; }
        public int PlayerXScore { get; set; }
        public string PlayerOName { get; set;}
        public int PlayerOScore { get; set; }
        public DateTime GameDate { get; set; }

    }
}
