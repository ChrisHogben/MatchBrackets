using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MatchBrackets
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        #endregion menu


        #region tool strip buttons
        private void toolStripButtonPasteFormula_Click(object sender, EventArgs e)
        {
            PasteFormula();
        }

        private void toolStripButtonCopyFormula_Click(object sender, EventArgs e)
        {
            CopyFormula();
        }

        private void toolStripButtonIncreaseFontSize_Click(object sender, EventArgs e)
        {
            txtOutput.Font = new Font(txtOutput.Font.Name, txtOutput.Font.SizeInPoints + 3f);
        }

        private void toolStripButton1DecreaseFontSize_Click(object sender, EventArgs e)
        {
            var currentSize = txtOutput.Font.SizeInPoints;
            if (currentSize < 8) return;
            txtOutput.Font = new Font(txtOutput.Font.Name, txtOutput.Font.SizeInPoints - 3f);
        }

        #endregion tool strip buttons


        private void PasteFormula()
        {
            if (!Clipboard.ContainsText()) return;
            var text = Clipboard.GetText();
            txtInput.Text = text;
            txtOutput.Clear();

            //just paste for now.
            //ProcessMatchBrackets();

            //var output = txtOutput.Text;
            //if (!string.IsNullOrEmpty(output))
            //{
            //    CopyFormula();
            //}

        }

        private void CopyFormula()
        {
            Clipboard.Clear();
            Clipboard.SetText(txtOutput.Text);
        }


        private void ProcessMatchBrackets()
        {
            var bracketContents = MatchBrackets.ProcessText(txtInput.Text);

            var output = Formatter.Format(bracketContents);
            txtOutput.Text = output;
            GenerateStats(txtInput.Text, bracketContents);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            ProcessMatchBrackets();
        }

        private void GenerateStats(string input, IEnumerable<BracketContent>bracketContents)
        {
            var openBrackets = 0;
            var closeBrackets = 0;

   
            foreach (var character in input)
            {
                switch (character)
                {
                    case '(':
                        openBrackets++;
                        break;
                    case ')':
                        closeBrackets++;
                        break;
                }
            }
           
            toolStripStatusLabelCountOpenBrackets.Text = $"({openBrackets}";
            toolStripStatusLabelCountCloseBrackets.Text = $"){closeBrackets}";

            var normalForeColor = Color.Black;
            var highlightForeColor= Color.DarkRed; 
            if (openBrackets == closeBrackets)
            {
                toolStripStatusLabelCountOpenBrackets.ForeColor = normalForeColor;
                toolStripStatusLabelCountCloseBrackets.ForeColor = normalForeColor;
            }
            if (openBrackets>closeBrackets)
            {
                toolStripStatusLabelCountCloseBrackets.ForeColor = highlightForeColor;
            }
            else if (openBrackets < closeBrackets)
            {
                toolStripStatusLabelCountOpenBrackets.ForeColor = highlightForeColor;
            }

            if (openBrackets+closeBrackets!=0)
            {
                var deepestLevel = bracketContents.Max(x => x.Level);
                toolStripStatusLabelDeepestLevel.Text = "Deepest Level " + deepestLevel;
            }
            else
            {
                toolStripStatusLabelDeepestLevel.Text = "";
            }
            
        }

      
    }
}
