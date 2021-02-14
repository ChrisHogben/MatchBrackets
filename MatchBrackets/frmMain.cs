using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MatchBrackets
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        #endregion menu

        public string GetInput() => txtInput.Text;

        public void SetInput(string input)
        {
            txtInput.Text = input;
        }

        public string GetOutput() => txtOutput.Text;
        private void SetOutput(string output)
        {
            txtOutput.Text = output;
        }
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
            txtOutput.IncreaseFontSize();
        }

        private void toolStripButton1DecreaseFontSize_Click(object sender, EventArgs e)
        {
           txtOutput.DecreaseFontSize();
        }
        private void toolStripButton1DecreaseFontSize_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                txtOutput.SetFontSize(txtInput.Font.Size);
            }
        }

        #endregion tool strip buttons



        private void PasteFormula()
        {
            if (!Clipboard.ContainsText()) return;
            var text = Clipboard.GetText();
            SetInput(text);
            
        }

        private void CopyFormula()
        {
            Clipboard.Clear();
            Clipboard.SetText(GetOutput());
        }


        private void MatchBracketsUp()
        {
            var input = GetInput();
            var bracketContents = MatchBrackets.ProcessText(input);

            var output = Formatter.Format(bracketContents);
            SetOutput(output);

            DescribeInput(input, bracketContents);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            MatchBracketsUp();
        }

        private void DescribeInput(string input, IEnumerable<BracketContent>bracketContents)
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
                var deepestLevel = bracketContents.DeepestLevel();
                toolStripStatusLabelDeepestLevel.Text = "Deepest Level " + deepestLevel;
            }
            else
            {
                toolStripStatusLabelDeepestLevel.Text = "";
            }
            
        }

        
    }
}
