using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinkExtractor
{
    public delegate void ButtonClickHandler(object sender, EventArgs e);

    public partial class Inputer : Form
    {
        public event ButtonClickHandler OkButtonClicked;

        public string Value
        {
            get { return rtbInput.Text; }
            set { rtbInput.Text = value; }
        }

        public string Title
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public Inputer()
        {
            InitializeComponent();
        }

        protected void Fire(Delegate dlg, params object[] pList)
        {
            if (dlg != null)
            {
                this.BeginInvoke(dlg, pList);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Fire(OkButtonClicked, this, e);
        }
    }
}
