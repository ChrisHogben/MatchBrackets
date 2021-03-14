using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchBrackets.BracketsMode
{
    public interface IBracketType
    {
        string OpeningBrackets { get; set; }
        string ClosingBrackets { get; set; }
        string Display { get; set; }

    }
}
