namespace WebSearch
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
            this.lblSearchQuery = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbSettings = new System.Windows.Forms.GroupBox();
            this.cmbSearchEngine = new System.Windows.Forms.ComboBox();
            this.lblSearchEngine = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblSearchQuery
            // 
            this.lblSearchQuery.AutoSize = true;
            this.lblSearchQuery.Location = new System.Drawing.Point(9, 42);
            this.lblSearchQuery.Name = "lblSearchQuery";
            this.lblSearchQuery.Size = new System.Drawing.Size(38, 13);
            this.lblSearchQuery.TabIndex = 0;
            this.lblSearchQuery.Text = "Query:";
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point(53, 39);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(273, 20);
            this.txtQuery.TabIndex = 1;
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(332, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grbSettings
            // 
            this.grbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSettings.Location = new System.Drawing.Point(12, 114);
            this.grbSettings.Name = "grbSettings";
            this.grbSettings.Size = new System.Drawing.Size(395, 129);
            this.grbSettings.TabIndex = 4;
            this.grbSettings.TabStop = false;
            this.grbSettings.Text = "Settings";
            this.grbSettings.Visible = false;
            // 
            // cmbSearchEngine
            // 
            this.cmbSearchEngine.FormattingEnabled = true;
            this.cmbSearchEngine.Location = new System.Drawing.Point(97, 12);
            this.cmbSearchEngine.Name = "cmbSearchEngine";
            this.cmbSearchEngine.Size = new System.Drawing.Size(170, 21);
            this.cmbSearchEngine.TabIndex = 0;
            this.cmbSearchEngine.SelectedValueChanged += new System.EventHandler(this.cmbSearchEngine_SelectedValueChanged);
            // 
            // lblSearchEngine
            // 
            this.lblSearchEngine.AutoSize = true;
            this.lblSearchEngine.Location = new System.Drawing.Point(12, 15);
            this.lblSearchEngine.Name = "lblSearchEngine";
            this.lblSearchEngine.Size = new System.Drawing.Size(79, 13);
            this.lblSearchEngine.TabIndex = 6;
            this.lblSearchEngine.Text = "Search engine:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 13);
            this.lblTitle.TabIndex = 7;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(12, 98);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(0, 13);
            this.lblLink.TabIndex = 8;
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 255);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSearchEngine);
            this.Controls.Add(this.cmbSearchEngine);
            this.Controls.Add(this.grbSettings);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.lblSearchQuery);
            this.MinimumSize = new System.Drawing.Size(435, 294);
            this.Name = "frmMain";
            this.Text = "Main form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grbSettings;
        private System.Windows.Forms.ComboBox cmbSearchEngine;
        private System.Windows.Forms.Label lblSearchEngine;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}

