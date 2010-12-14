using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace LinkExtractor
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Webovy klient pro stazeni obsahu stranky
        /// </summary>
        protected WebClient client;

        /// <summary>
        /// Seznam na nalezene linky
        /// </summary>
        protected List<string> links;

        /// <summary>
        /// Seznam na filtrovane linky
        /// </summary>
        protected List<string> filteredLinks;

        /// <summary>
        /// Obsah stazene stranky nebo obsah z primeho vstupu
        /// </summary>
        protected string content;

        /// <summary>
        /// Form pro zadavani primeho vstupu
        /// </summary>
        protected Inputer frmDirectInput;

        /// <summary>
        /// Form pro zobrazeni vybranych odkazu
        /// </summary>
        protected Inputer frmSubstractedLinks;

        /// <summary>
        /// Form pro zobrazeni stazeneho obsahu
        /// </summary>
        protected Inputer frmContent;

        public MainForm()
        {
            InitializeComponent();

            this.client = new WebClient();
            this.links = new List<string>();
            this.filteredLinks = new List<string>();
        }

        /// <summary>
        /// Najde vsechny linky v <code>content</code> a ulozi do <code>links</code>
        /// </summary>
        /// <param name="content">retezec obsahujici linky</param>
        public void FindLinks(string content)
        {
            if (!cbxAppend.Checked)
            {
                links.Clear();
                filteredLinks.Clear();
            }

            Regex rgx = new Regex("(https?://([0-9a-zA-Z;/?:@&=+$\\.\\-_!~*'()%]+)?(#[0-9a-zA-Z;/?:@&=+$\\.\\-_!~*'()%]+)?)");
            MatchCollection mc = rgx.Matches(TranslateEntities(content));

            foreach (Match m in mc)
            {
                links.Add(m.Groups[0].Value);
            }
        }

        /// <summary>
        /// Prelozi html entity na "klasicke" znaky
        /// TODO: Vylepsit preklad :)
        /// </summary>
        /// <param name="content">text obsahujici entity</param>
        /// <returns>text s nahrazenymi html entitami</returns>
        public string TranslateEntities(string content)
        {
            return content.Replace(@"&#58;", ":");
        }

        /// <summary>
        /// Nacte obsah z webu a vrati ho
        /// </summary>
        /// <param name="url">Url adresa odkud se bude cist</param>
        /// <returns>obsah zadane url</returns>
        public string DownloadContent(string url)
        {
            StreamReader sr = new StreamReader(client.OpenRead(url));
            return sr.ReadToEnd();
        }

        /// <summary>
        /// Naplni <code>lvwLinks</code> odkazy v <code>links</code>
        /// <param name="links">Seznam odkazu k zobrazeni</param>
        /// </summary>
        public void FillListView(List<string> links)
        {
            Cursor lastCursor = this.Cursor;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    lvwLinks.BeginUpdate();
                    lvwLinks.Items.Clear();
                    foreach (string link in links)
                    {
                        string[] cols = { "", link };
                        ListViewItem lvi = new ListViewItem(cols);
                        lvi.Checked = true;
                        lvwLinks.Items.Add(lvi);
                    }
                    Application.DoEvents();
                }
                finally
                {
                    lvwLinks.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, String.Format("Some Error occurs;{0}{1}{2}Please, contact author, thanks", Environment.NewLine, ex.Message, Environment.NewLine), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = lastCursor;
            }
        }

        /// <summary>
        /// Zkontroluje zadany retezec je validni url adresa
        /// </summary>
        /// <param name="url">testovany retezec</param>
        /// <returns>true pokud je <code>url</code> validni url adresa, false v opacnem pripade</returns>
        public bool ValidateUrl(string url)
        {
            Regex rgx = new Regex("https?://([0-9a-zA-Z;/?:@&=+$\\.\\-_!~*'()%]+)?(#[0-9a-zA-Z;/?:@&=+$\\.\\-_!~*'()%]+)?");
            return rgx.IsMatch(url);
        }

        /// <summary>
        /// Provede filtrovani vyhledanych odkazu podle zadaneho vzoru
        /// </summary>
        /// <param name="pattern">vzor pro hledani odkazu</param>
        public void FilterLinks(string pattern)
        {
            Regex rgx = new Regex(".*" + pattern + ".*");

            filteredLinks.Clear();
            foreach (string item in links)
            {
                if (rgx.IsMatch(item))
                {
                    filteredLinks.Add(item);
                }
            }

            FillListView(filteredLinks);
        }

        private void btnUrl_Click(object sender, EventArgs e)
        {
            if (ValidateUrl(tbxUrl.Text))
            {
                this.Enabled = false;
                this.Text = String.Format("LinkExtractor - Downloading content from {0} ...", tbxUrl.Text);

                content = DownloadContent(tbxUrl.Text);

                this.Enabled = true;
                this.Text = "LinkExtractor";

                FindLinks(content);
                if (tbxAdditionalFilter.Text.Equals(""))
                {
                    FillListView(links);
                }
                else
                {
                    FilterLinks(tbxAdditionalFilter.Text);
                    FillListView(filteredLinks);
                }
            }
            else
            {
                MessageBox.Show("Inputed isn't a valid url address!", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxAdditionalFilter_TextChanged(object sender, EventArgs e)
        {
            FilterLinks(tbxAdditionalFilter.Text);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (frmDirectInput == null)
            {
                frmDirectInput = new Inputer();
                frmDirectInput.Title = "Direct Input";
            }
            if (frmDirectInput.WindowState == FormWindowState.Minimized)
            {
                frmDirectInput.WindowState = FormWindowState.Normal;
            }
            if (!frmDirectInput.Visible)
            {
                frmDirectInput.Show();
            }
            frmDirectInput.BringToFront();
            frmDirectInput.FormClosed += delegate { frmDirectInput = null; };
            frmDirectInput.OkButtonClicked += delegate
            {
                content = frmDirectInput.Value;
                FindLinks(content);
                if (tbxAdditionalFilter.Text.Equals(""))
                {
                    FillListView(links);
                }
                else
                {
                    FilterLinks(tbxAdditionalFilter.Text);
                    FillListView(filteredLinks);
                }
                frmDirectInput.Close();
            };
        }

        private void btnSubstractLinks_Click(object sender, EventArgs e)
        {
            if (frmSubstractedLinks == null)
            {
                frmSubstractedLinks = new Inputer();
                frmSubstractedLinks.Title = "Substracted Links";

                foreach (ListViewItem item in lvwLinks.Items)
                {
                    if (item.Checked)
                    {
                        frmSubstractedLinks.Value += item.SubItems[1].Text + Environment.NewLine;
                    }
                }
            }
            if (frmSubstractedLinks.WindowState == FormWindowState.Minimized)
            {
                frmSubstractedLinks.WindowState = FormWindowState.Normal;
            }
            if (!frmSubstractedLinks.Visible)
            {
                frmSubstractedLinks.Show();
            }
            frmSubstractedLinks.BringToFront();
            frmSubstractedLinks.FormClosed += delegate { frmSubstractedLinks = null; };
            frmSubstractedLinks.OkButtonClicked += delegate
            {
                frmSubstractedLinks.Close();
            };
        }

        private void lnlShowHidePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (frmContent == null)
            {
                frmContent = new Inputer();
                frmContent.Title = "Donwloaded Content";
                frmContent.Value = content;
            }
            if (frmContent.WindowState == FormWindowState.Minimized)
            {
                frmContent.WindowState = FormWindowState.Normal;
            }
            if (!frmContent.Visible)
            {
                frmContent.Show();
            }
            frmContent.BringToFront();
            frmContent.FormClosed += delegate { frmContent = null; };
            frmContent.OkButtonClicked += delegate
            {
                frmContent.Close();
            };
        }
    }
}
