using System.Collections.Generic;
using System.Linq;
using MatchBrackets.BracketsMode;

namespace MatchBrackets
{
    public static class MatchBrackets
    {
        private const string IgnoreCharacters = "\t\r\n";

        




        public static List<BracketContent> ProcessText(string formula, IBracketType bracketType)
        {
            
            
            var currentLevel = 0;
            var bracketContents = new List<BracketContent>();
            if (string.IsNullOrWhiteSpace(formula)) return bracketContents;

            var currentBracketContent = bracketContents.CreateNewContentLine(currentLevel);
            
            currentBracketContent.Level = 0;
            foreach(var character in formula)
            {
                if (IgnoreCharacters.Contains(character)) continue;

                //if (character == '(')
                if(bracketType.OpeningBrackets.Contains(character))
                {
                    currentLevel++;
                    //place the bracket on the next line by itself
                    bracketContents.AddBracketLine(currentLevel,character.ToString());
                    
                    currentBracketContent = bracketContents.CreateNewContentLine(currentLevel);
                }
                //else if (character == ')')
                else if(bracketType.ClosingBrackets.Contains(character))
                {

                    //place the bracket on the next line by itself
                    bracketContents.AddBracketLine(currentLevel, character.ToString());
                    
                    currentLevel--;
                    currentBracketContent=bracketContents.CreateNewContentLine(currentLevel);
                }                
                else
                {
                    currentBracketContent.Contents += character.ToString();
                }
            }

            return bracketContents;
        }

       
        
    }
}
