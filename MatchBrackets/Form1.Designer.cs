namespace MatchBrackets
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchBracketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPasteFormula = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCountOpenBrackets = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCountCloseBrackets = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButtonMatch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopyFormula = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 379);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.Controls.Add(this.lblInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOutput, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtOutput, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(6, 3);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(118, 13);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Paste your formula here";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(6, 189);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Output";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.matchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtInput
            // 
            this.txtInput.AcceptsReturn = true;
            this.txtInput.AcceptsTab = true;
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(6, 26);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(788, 160);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.AcceptsReturn = true;
            this.txtOutput.AcceptsTab = true;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(6, 212);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(788, 160);
            this.txtOutput.TabIndex = 3;
            // 
            // matchToolStripMenuItem
            // 
            this.matchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchBracketsToolStripMenuItem});
            this.matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            this.matchToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.matchToolStripMenuItem.Text = "Match";
            // 
            // matchBracketsToolStripMenuItem
            // 
            this.matchBracketsToolStripMenuItem.Name = "matchBracketsToolStripMenuItem";
            this.matchBracketsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.matchBracketsToolStripMenuItem.Text = "Match Brackets";
            this.matchBracketsToolStripMenuItem.Click += new System.EventHandler(this.matchBracketsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonMatch,
            this.toolStripButtonPasteFormula,
            this.toolStripButtonCopyFormula});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(308, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // toolStripButtonPasteFormula
            // 
            this.toolStripButtonPasteFormula.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPasteFormula.Image")));
            this.toolStripButtonPasteFormula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPasteFormula.Name = "toolStripButtonPasteFormula";
            this.toolStripButtonPasteFormula.Size = new System.Drawing.Size(102, 22);
            this.toolStripButtonPasteFormula.Text = "Paste Formula";
            this.toolStripButtonPasteFormula.Click += new System.EventHandler(this.toolStripButtonPasteFormula_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCountOpenBrackets,
            this.toolStripStatusLabelCountCloseBrackets});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabelCountOpenBrackets
            // 
            this.toolStripStatusLabelCountOpenBrackets.Name = "toolStripStatusLabelCountOpenBrackets";
            this.toolStripStatusLabelCountOpenBrackets.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabelCountOpenBrackets.Text = " ";
            // 
            // toolStripStatusLabelCountCloseBrackets
            // 
            this.toolStripStatusLabelCountCloseBrackets.Name = "toolStripStatusLabelCountCloseBrackets";
            this.toolStripStatusLabelCountCloseBrackets.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripButtonMatch
            // 
            this.toolStripButtonMatch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMatch.Image")));
            this.toolStripButtonMatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMatch.Name = "toolStripButtonMatch";
            this.toolStripButtonMatch.Size = new System.Drawing.Size(61, 22);
            this.toolStripButtonMatch.Text = "Match";
            this.toolStripButtonMatch.Click += new System.EventHandler(this.toolStripButtonMatch_Click);
            // 
            // toolStripButtonCopyFormula
            // 
            this.toolStripButtonCopyFormula.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopyFormula.Image")));
            this.toolStripButtonCopyFormula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopyFormula.Name = "toolStripButtonCopyFormula";
            this.toolStripButtonCopyFormula.Size = new System.Drawing.Size(102, 22);
            this.toolStripButtonCopyFormula.Text = "Copy Formula";
            this.toolStripButtonCopyFormula.Click += new System.EventHandler(this.toolStripButtonCopyFormula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Match Brackets";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchBracketsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPasteFormula;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCountOpenBrackets;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCountCloseBrackets;
        private System.Windows.Forms.ToolStripButton toolStripButtonMatch;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopyFormula;
    }
}

