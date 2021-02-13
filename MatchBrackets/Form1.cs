using System;
using System.Drawing;
using System.Windows.Forms;

namespace MatchBrackets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void matchBracketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessMatchBrackets();
        }


        #endregion menu


        #region tool strip buttons
        private void toolStripButtonPasteFormula_Click(object sender, EventArgs e)
        {
            PasteFormula();
        }

        private void toolStripButtonMatch_Click(object sender, EventArgs e)
        {
            ProcessMatchBrackets();
        }

        private void toolStripButtonCopyFormula_Click(object sender, EventArgs e)
        {
            CopyFormula();
        }

      
        #endregion tool strip buttons


        private void PasteFormula()
        {
            if (!Clipboard.ContainsText()) return;
            var text = Clipboard.GetText();
            txtInput.Text = text;
            txtOutput.Clear();

            ProcessMatchBrackets();

            var output = txtOutput.Text;
            if (!string.IsNullOrEmpty(output))
            {
                CopyFormula();
            }

        }

        private void CopyFormula()
        {
            Clipboard.Clear();
            Clipboard.SetText(txtOutput.Text);
        }


        private void ProcessMatchBrackets()
        {
            txtOutput.Text=MatchBrackets.ProcessText(txtInput.Text);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            GenerateStats();
        }

        private void GenerateStats()
        {
            var openBrackets = 0;
            var closeBrackets = 0;

            var formula = txtInput.Text;
            foreach (var character in formula)
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

            
        }

        
    }
}
