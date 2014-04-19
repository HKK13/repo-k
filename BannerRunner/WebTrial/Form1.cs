using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace WebTrial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int RETRYCOUNTER = 1;
        string input = "https://suis.sabanciuniv.edu/prod/twbkwbis.P_SabanciLogin";
        string keyword = "User Login";

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MessageBox.Show("You got them bro!");
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);

                    if (textID.Text != "" && textPASS.Text != "" && urlBox.Text != "")
                    {
                        
                        urlLoad();
                    }
                    else
                    {
                        MessageBox.Show("A Student without a password or ID is like a LOSER. Seriously enter your ID and Password. Also verify the url.");
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void urlLoad()
        {
            webBrowser1.Navigate(urlBox.Text);
        }

        private void operationLogIn()
        {
            try
            {
                if (!webBrowser1.DocumentText.Contains(keyword))
                {
                    logBox.AppendText("Retrying \n");
                    urlLoad();
                }
                else
                {
                    HtmlElement submit = webBrowser1.Document.Forms[0].Document.All["PIN"].Parent.Parent.Parent.NextSibling.FirstChild;
                    webBrowser1.Document.Forms[0].All["UserID"].SetAttribute("value", textID.Text);
                    webBrowser1.Document.Forms[0].All["PIN"].FirstChild.SetAttribute("value", textPASS.Text);
                    submit.InvokeMember("Click");
                    logBox.AppendText("Logged in. " + "(num of tries: " + RETRYCOUNTER + ")\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                if (webBrowser1.Url.ToString() == input)
                {
                    var webBrowser = sender as WebBrowser;
                    webBrowser.DocumentCompleted -= webBrowser1_DocumentCompleted;

                        operationLogIn();
                }
                else
                {
                    logBox.AppendText("Retrying..." + RETRYCOUNTER.ToString() + "\n");
                    RETRYCOUNTER++;
                    urlLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You need to enter url to both url sides, then you need to find and write html id for ID input box, PASSWORD input box and SUBMIT button ID. This way you can use this program for other systems even facebook.");
        }

        private void howItWorks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Enter your username and your password then press enter or click start. \n\n Note: This program is only tested and developed for Sabancı University.");
        }

    }
}
