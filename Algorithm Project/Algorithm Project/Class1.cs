using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Project
{
    class Relation_str
    {
        public int  Direct_Freq;
        public string Common_Movie;
        public Relation_str(string common_movie)
        {
            Direct_Freq = 1;
            Common_Movie = common_movie;
        }
    }
    class path
    {
        public bool VisitedNode;
        public int distance;
        public int Parent;
        public int Undirect_Freq;
        public path()
        {
            Undirect_Freq = 0;
            VisitedNode = false;
            distance = int.MaxValue;
            Parent = 0;
        }
    }
}
