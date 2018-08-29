using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace flink
{
    public partial class frmflink : Form
    {
        public frmflink()
        {
            InitializeComponent();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmflink_Load(object sender, EventArgs e)
        {
            cmbSearchEngines.Items.Add("Google");
            cmbSearchEngines.Items.Add("Youtube");
            cmbSearchEngines.Items.Add("Wikipidea");

            cmbSearchEngines.SelectedIndex = 0;
            webBrowser1.Navigate("www.google.com");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnHome_Click(Object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.facebook.com");
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtUrl.Text = webBrowser1.Url.ToString();
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(txtUrl.Text);
            }
        }

        private void incognitoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmbSearchEngines_KeyUp(object sender, KeyEventArgs e)
        {
            switch (cmbSearchEngines.SelectedIndex){
                case 0:
                        if (e.KeyCode == Keys.Enter)
                        {
                            webBrowser1.Navigate("https://www.google.com/");
                        }
                    break;
                case 1:
           if (e.KeyCode == Keys.Enter)
                  {
                    webBrowser1.Navigate("https://www.youtube.com");
                }
                    break;
                case 2:
            if(e.KeyCode == Keys.Enter) {
                    webBrowser1.Navigate("https://en.wikipedia.org/wiki/Main_Page");
            }
                    break;
            }
        }
               
        private void txtUrlSearchEngines_KeyUp(object sender, KeyEventArgs e)
        {
            switch (cmbSearchEngines.SelectedIndex)
            {
                case 0:
                    webBrowser1.Navigate("https://www.google.com/#q=" + txtUrlSearchEngines.Text);
                    break;
                case 2:
                    webBrowser1.Navigate("https://en.wikipedia.org/wiki/" + txtUrlSearchEngines.Text);
                    break;
                case 1:
                    webBrowser1.Navigate("https://www.youtube.com/" + txtUrlSearchEngines.Text);
                    break;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
         
            webBrowser1.Stop();
        }
    }
    }
