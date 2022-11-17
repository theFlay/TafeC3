namespace AstroProApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTxtBx = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonMidExtreme = new System.Windows.Forms.Button();
            this.buttonMode = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.buttonRange = new System.Windows.Forms.Button();
            this.textBoxOut1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSeqSearch = new System.Windows.Forms.Button();
            this.enterText = new System.Windows.Forms.ToolTip(this.components);
            this.output = new System.Windows.Forms.ToolTip(this.components);
            this.Generate = new System.Windows.Forms.ToolTip(this.components);
            this.binSearch = new System.Windows.Forms.ToolTip(this.components);
            this.range = new System.Windows.Forms.ToolTip(this.components);
            this.edit = new System.Windows.Forms.ToolTip(this.components);
            this.seqSearch = new System.Windows.Forms.ToolTip(this.components);
            this.mode = new System.Windows.Forms.ToolTip(this.components);
            this.sort = new System.Windows.Forms.ToolTip(this.components);
            this.midExtreme = new System.Windows.Forms.ToolTip(this.components);
            this.average = new System.Windows.Forms.ToolTip(this.components);
            this.listBox = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTxtBx
            // 
            this.labelTxtBx.AutoSize = true;
            this.labelTxtBx.Location = new System.Drawing.Point(31, 12);
            this.labelTxtBx.Name = "labelTxtBx";
            this.labelTxtBx.Size = new System.Drawing.Size(56, 13);
            this.labelTxtBx.TabIndex = 0;
            this.labelTxtBx.Text = "Enter Text";
            this.enterText.SetToolTip(this.labelTxtBx, "Please a number(s) for search and edit in text box below");
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(12, 138);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "Data:";
            this.listBox.SetToolTip(this.labelData, "Displays items in arrays");
            this.labelData.Click += new System.EventHandler(this.labelData_Click);
            // 
            // textBoxMain
            // 
            this.textBoxMain.Location = new System.Drawing.Point(12, 28);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(112, 20);
            this.textBoxMain.TabIndex = 2;
            this.enterText.SetToolTip(this.textBoxMain, "Please a number(s) for search and edit");
            this.textBoxMain.TextChanged += new System.EventHandler(this.textBoxMain_TextChanged);
            // 
            // buttonGen
            // 
            this.buttonGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGen.ForeColor = System.Drawing.Color.White;
            this.buttonGen.Location = new System.Drawing.Point(15, 54);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(72, 23);
            this.buttonGen.TabIndex = 3;
            this.buttonGen.Text = "Generate";
            this.Generate.SetToolTip(this.buttonGen, "Click this button to generates random numbers");
            this.buttonGen.UseVisualStyleBackColor = false;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSort.ForeColor = System.Drawing.Color.White;
            this.buttonSort.Location = new System.Drawing.Point(15, 112);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(72, 23);
            this.buttonSort.TabIndex = 4;
            this.buttonSort.Text = "Sort";
            this.sort.SetToolTip(this.buttonSort, "Click this button after generate to sort items in list box");
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(93, 54);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(72, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "BinSearch";
            this.binSearch.SetToolTip(this.buttonSearch, "Click this button to perform Binary Search");
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxMain
            // 
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.Location = new System.Drawing.Point(9, 156);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(237, 368);
            this.listBoxMain.TabIndex = 6;
            this.listBoxMain.SelectedIndexChanged += new System.EventHandler(this.listBoxMain_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(254, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "Status Stip";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(15, 83);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(72, 23);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edit";
            this.edit.SetToolTip(this.buttonEdit, "Click this button to edit items in list box");
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonMidExtreme
            // 
            this.buttonMidExtreme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMidExtreme.ForeColor = System.Drawing.Color.White;
            this.buttonMidExtreme.Location = new System.Drawing.Point(93, 112);
            this.buttonMidExtreme.Name = "buttonMidExtreme";
            this.buttonMidExtreme.Size = new System.Drawing.Size(72, 23);
            this.buttonMidExtreme.TabIndex = 9;
            this.buttonMidExtreme.Text = "Mid-Extreme";
            this.midExtreme.SetToolTip(this.buttonMidExtreme, "Click this button to get mid-extreme");
            this.buttonMidExtreme.UseVisualStyleBackColor = false;
            this.buttonMidExtreme.Click += new System.EventHandler(this.buttonMidExtreme_Click);
            // 
            // buttonMode
            // 
            this.buttonMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMode.ForeColor = System.Drawing.Color.White;
            this.buttonMode.Location = new System.Drawing.Point(174, 83);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(72, 23);
            this.buttonMode.TabIndex = 10;
            this.buttonMode.Text = "Mode";
            this.mode.SetToolTip(this.buttonMode, "Click the button to calculate mode");
            this.buttonMode.UseVisualStyleBackColor = false;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // buttonAverage
            // 
            this.buttonAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAverage.ForeColor = System.Drawing.Color.White;
            this.buttonAverage.Location = new System.Drawing.Point(174, 112);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(72, 23);
            this.buttonAverage.TabIndex = 11;
            this.buttonAverage.Text = "Average";
            this.average.SetToolTip(this.buttonAverage, "Click this button to calculate the average of all numbers in list box");
            this.buttonAverage.UseVisualStyleBackColor = false;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // buttonRange
            // 
            this.buttonRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRange.ForeColor = System.Drawing.Color.White;
            this.buttonRange.Location = new System.Drawing.Point(174, 54);
            this.buttonRange.Name = "buttonRange";
            this.buttonRange.Size = new System.Drawing.Size(72, 23);
            this.buttonRange.TabIndex = 12;
            this.buttonRange.Text = "Range";
            this.range.SetToolTip(this.buttonRange, "Click this button to calculate range");
            this.buttonRange.UseVisualStyleBackColor = false;
            this.buttonRange.Click += new System.EventHandler(this.buttonRange_Click);
            // 
            // textBoxOut1
            // 
            this.textBoxOut1.Location = new System.Drawing.Point(130, 28);
            this.textBoxOut1.Name = "textBoxOut1";
            this.textBoxOut1.Size = new System.Drawing.Size(116, 20);
            this.textBoxOut1.TabIndex = 13;
            this.output.SetToolTip(this.textBoxOut1, "Displays all outcomes");
            this.textBoxOut1.TextChanged += new System.EventHandler(this.textBoxOut1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Output";
            this.output.SetToolTip(this.label1, "Displays all outcomes in text box below");
            // 
            // buttonSeqSearch
            // 
            this.buttonSeqSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSeqSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSeqSearch.Location = new System.Drawing.Point(93, 83);
            this.buttonSeqSearch.Name = "buttonSeqSearch";
            this.buttonSeqSearch.Size = new System.Drawing.Size(72, 23);
            this.buttonSeqSearch.TabIndex = 15;
            this.buttonSeqSearch.Text = "SeqSearch";
            this.seqSearch.SetToolTip(this.buttonSeqSearch, "Click this button to perform Linear search");
            this.buttonSeqSearch.UseVisualStyleBackColor = false;
            this.buttonSeqSearch.Click += new System.EventHandler(this.buttonSeqSearch_Click);
            // 
            // range
            // 
            this.range.Popup += new System.Windows.Forms.PopupEventHandler(this.range_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(254, 549);
            this.Controls.Add(this.buttonSeqSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOut1);
            this.Controls.Add(this.buttonRange);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.buttonMode);
            this.Controls.Add(this.buttonMidExtreme);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBoxMain);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelTxtBx);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Astro Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTxtBx;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonMidExtreme;
        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Button buttonRange;
        private System.Windows.Forms.TextBox textBoxOut1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSeqSearch;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip output;
        private System.Windows.Forms.ToolTip Generate;
        private System.Windows.Forms.ToolTip binSearch;
        private System.Windows.Forms.ToolTip range;
        private System.Windows.Forms.ToolTip edit;
        private System.Windows.Forms.ToolTip seqSearch;
        private System.Windows.Forms.ToolTip mode;
        private System.Windows.Forms.ToolTip sort;
        private System.Windows.Forms.ToolTip midExtreme;
        private System.Windows.Forms.ToolTip average;
        private System.Windows.Forms.ToolTip listBox;
        private System.Windows.Forms.ToolTip enterText;
    }
}

