namespace StringComparator
{
    partial class frmMain
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
            this.scContent = new System.Windows.Forms.SplitContainer();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grbPatterns = new System.Windows.Forms.GroupBox();
            this.txtPatterns = new System.Windows.Forms.TextBox();
            this.cmbCompareMethods = new System.Windows.Forms.ComboBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblCompareMethods = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).BeginInit();
            this.scContent.Panel1.SuspendLayout();
            this.scContent.Panel2.SuspendLayout();
            this.scContent.SuspendLayout();
            this.grbInput.SuspendLayout();
            this.grbPatterns.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scContent
            // 
            this.scContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scContent.Location = new System.Drawing.Point(12, 27);
            this.scContent.Name = "scContent";
            this.scContent.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scContent.Panel1
            // 
            this.scContent.Panel1.Controls.Add(this.grbInput);
            // 
            // scContent.Panel2
            // 
            this.scContent.Panel2.Controls.Add(this.grbPatterns);
            this.scContent.Size = new System.Drawing.Size(353, 436);
            this.scContent.SplitterDistance = 175;
            this.scContent.TabIndex = 6;
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtInput);
            this.grbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbInput.Location = new System.Drawing.Point(0, 0);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(353, 175);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Input";
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(3, 16);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(347, 156);
            this.txtInput.TabIndex = 0;
            // 
            // grbPatterns
            // 
            this.grbPatterns.Controls.Add(this.txtPatterns);
            this.grbPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPatterns.Location = new System.Drawing.Point(0, 0);
            this.grbPatterns.Name = "grbPatterns";
            this.grbPatterns.Size = new System.Drawing.Size(353, 257);
            this.grbPatterns.TabIndex = 0;
            this.grbPatterns.TabStop = false;
            this.grbPatterns.Text = "Patterns";
            // 
            // txtPatterns
            // 
            this.txtPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPatterns.Location = new System.Drawing.Point(3, 16);
            this.txtPatterns.Multiline = true;
            this.txtPatterns.Name = "txtPatterns";
            this.txtPatterns.Size = new System.Drawing.Size(347, 238);
            this.txtPatterns.TabIndex = 0;
            // 
            // cmbCompareMethods
            // 
            this.cmbCompareMethods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompareMethods.FormattingEnabled = true;
            this.cmbCompareMethods.Location = new System.Drawing.Point(583, 27);
            this.cmbCompareMethods.Name = "cmbCompareMethods";
            this.cmbCompareMethods.Size = new System.Drawing.Size(165, 21);
            this.cmbCompareMethods.TabIndex = 7;
            this.cmbCompareMethods.SelectedValueChanged += new System.EventHandler(this.cmbCompareMethods_SelectedValueChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutput.Location = new System.Drawing.Point(371, 54);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(377, 406);
            this.txtOutput.TabIndex = 8;
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(371, 38);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "Output";
            // 
            // lblCompareMethods
            // 
            this.lblCompareMethods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompareMethods.AutoSize = true;
            this.lblCompareMethods.Location = new System.Drawing.Point(487, 30);
            this.lblCompareMethods.Name = "lblCompareMethods";
            this.lblCompareMethods.Size = new System.Drawing.Size(90, 13);
            this.lblCompareMethods.TabIndex = 10;
            this.lblCompareMethods.Text = "Compare method:";
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.Location = new System.Drawing.Point(676, 466);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(72, 23);
            this.btnCompare.TabIndex = 11;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(760, 24);
            this.mnuMain.TabIndex = 12;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoad,
            this.mnuSave});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuLoad
            // 
            this.mnuLoad.Name = "mnuLoad";
            this.mnuLoad.Size = new System.Drawing.Size(152, 22);
            this.mnuLoad.Text = "Load";
            this.mnuLoad.Click += new System.EventHandler(this.mnuLoad_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(152, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 501);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.lblCompareMethods);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.cmbCompareMethods);
            this.Controls.Add(this.scContent);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(776, 540);
            this.Name = "frmMain";
            this.Text = "Main form";
            this.scContent.Panel1.ResumeLayout(false);
            this.scContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).EndInit();
            this.scContent.ResumeLayout(false);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbPatterns.ResumeLayout(false);
            this.grbPatterns.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer scContent;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.GroupBox grbPatterns;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtPatterns;
        private System.Windows.Forms.ComboBox cmbCompareMethods;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblCompareMethods;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
    }
}

