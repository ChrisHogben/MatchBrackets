using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchBrackets.BracketsMode
{
    public class MixedBrackets:IBracketType
    {
        public string OpeningBrackets { get; set; } = "([{";
        public string ClosingBrackets { get; set; } = "}])";
        public string Display { get; set; } = "([{}])";
    }
}
