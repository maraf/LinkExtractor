namespace LinkExtractor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnUrl = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.lvwLinks = new System.Windows.Forms.ListView();
            this.chdUse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lnlShowHidePage = new System.Windows.Forms.LinkLabel();
            this.btnSubstractLinks = new System.Windows.Forms.Button();
            this.lblAdditionalFilter = new System.Windows.Forms.Label();
            this.tbxAdditionalFilter = new System.Windows.Forms.TextBox();
            this.cbxAppend = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxUrl
            // 
            this.tbxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUrl.Location = new System.Drawing.Point(41, 14);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(375, 20);
            this.tbxUrl.TabIndex = 0;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 17);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(23, 13);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "Url:";
            // 
            // btnUrl
            // 
            this.btnUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrl.Location = new System.Drawing.Point(422, 12);
            this.btnUrl.Name = "btnUrl";
            this.btnUrl.Size = new System.Drawing.Size(75, 23);
            this.btnUrl.TabIndex = 2;
            this.btnUrl.Text = "Open Url";
            this.btnUrl.UseVisualStyleBackColor = true;
            this.btnUrl.Click += new System.EventHandler(this.btnUrl_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaste.Location = new System.Drawing.Point(503, 12);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(91, 23);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.Text = "Direct Input";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // lvwLinks
            // 
            this.lvwLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLinks.CheckBoxes = true;
            this.lvwLinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdUse,
            this.chdLink});
            this.lvwLinks.FullRowSelect = true;
            this.lvwLinks.GridLines = true;
            this.lvwLinks.Location = new System.Drawing.Point(15, 41);
            this.lvwLinks.Name = "lvwLinks";
            this.lvwLinks.Size = new System.Drawing.Size(704, 356);
            this.lvwLinks.TabIndex = 4;
            this.lvwLinks.UseCompatibleStateImageBehavior = false;
            this.lvwLinks.View = System.Windows.Forms.View.Details;
            // 
            // chdUse
            // 
            this.chdUse.Text = "Use";
            this.chdUse.Width = 35;
            // 
            // chdLink
            // 
            this.chdLink.Text = "Link";
            this.chdLink.Width = 627;
            // 
            // lnlShowHidePage
            // 
            this.lnlShowHidePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnlShowHidePage.AutoSize = true;
            this.lnlShowHidePage.Location = new System.Drawing.Point(446, 408);
            this.lnlShowHidePage.Name = "lnlShowHidePage";
            this.lnlShowHidePage.Size = new System.Drawing.Size(100, 13);
            this.lnlShowHidePage.TabIndex = 5;
            this.lnlShowHidePage.TabStop = true;
            this.lnlShowHidePage.Text = "Show page content";
            this.lnlShowHidePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlShowHidePage_LinkClicked);
            // 
            // btnSubstractLinks
            // 
            this.btnSubstractLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubstractLinks.Location = new System.Drawing.Point(552, 403);
            this.btnSubstractLinks.Name = "btnSubstractLinks";
            this.btnSubstractLinks.Size = new System.Drawing.Size(164, 23);
            this.btnSubstractLinks.TabIndex = 6;
            this.btnSubstractLinks.Text = "Substract selected links";
            this.btnSubstractLinks.UseVisualStyleBackColor = true;
            this.btnSubstractLinks.Click += new System.EventHandler(this.btnSubstractLinks_Click);
            // 
            // lblAdditionalFilter
            // 
            this.lblAdditionalFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAdditionalFilter.AutoSize = true;
            this.lblAdditionalFilter.Location = new System.Drawing.Point(12, 408);
            this.lblAdditionalFilter.Name = "lblAdditionalFilter";
            this.lblAdditionalFilter.Size = new System.Drawing.Size(81, 13);
            this.lblAdditionalFilter.TabIndex = 7;
            this.lblAdditionalFilter.Text = "Additional Filter:";
            // 
            // tbxAdditionalFilter
            // 
            this.tbxAdditionalFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAdditionalFilter.Location = new System.Drawing.Point(99, 405);
            this.tbxAdditionalFilter.Name = "tbxAdditionalFilter";
            this.tbxAdditionalFilter.Size = new System.Drawing.Size(323, 20);
            this.tbxAdditionalFilter.TabIndex = 8;
            this.tbxAdditionalFilter.TextChanged += new System.EventHandler(this.tbxAdditionalFilter_TextChanged);
            // 
            // cbxAppend
            // 
            this.cbxAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAppend.AutoSize = true;
            this.cbxAppend.Checked = true;
            this.cbxAppend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAppend.Location = new System.Drawing.Point(600, 16);
            this.cbxAppend.Name = "cbxAppend";
            this.cbxAppend.Size = new System.Drawing.Size(116, 17);
            this.cbxAppend.TabIndex = 9;
            this.cbxAppend.Text = "Append New Links";
            this.cbxAppend.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 440);
            this.Controls.Add(this.cbxAppend);
            this.Controls.Add(this.tbxAdditionalFilter);
            this.Controls.Add(this.lblAdditionalFilter);
            this.Controls.Add(this.btnSubstractLinks);
            this.Controls.Add(this.lnlShowHidePage);
            this.Controls.Add(this.lvwLinks);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.tbxUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "LinkExtractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnUrl;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.ListView lvwLinks;
        private System.Windows.Forms.ColumnHeader chdUse;
        private System.Windows.Forms.ColumnHeader chdLink;
        private System.Windows.Forms.LinkLabel lnlShowHidePage;
        private System.Windows.Forms.Button btnSubstractLinks;
        private System.Windows.Forms.Label lblAdditionalFilter;
        private System.Windows.Forms.TextBox tbxAdditionalFilter;
        private System.Windows.Forms.CheckBox cbxAppend;
    }
}

