using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Web;

namespace CodingTheTweet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btwTweet_Click(object sender, EventArgs e)
        {
            oAuthTwitter oAuth = new oAuthTwitter();
            
            // Set up our credentials...
            oAuth.Token = Settings1.Default.token;
            oAuth.TokenSecret = Settings1.Default.secretToken;

            // And send the tweet!
            string xml = oAuth.oAuthWebRequest(oAuthTwitter.Method.POST, "http://twitter.com/statuses/update.xml", 
               "status=" + HttpUtility.UrlEncode(txtTweet.Text));

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Settings1.Default.token = "";
            Settings1.Default.secretToken = "";
            Settings1.Default.consumerKey = "";
            Settings1.Default.consumerSecret = "";

            txtTweet.Enabled = btwTweet.Enabled = btnSave.Enabled = false;
            txtConsumerSecret.Enabled = txtConsumerKey.Enabled = true;
            txtConsumerKey.Text = txtConsumerSecret.Text = String.Empty;
            

            Settings1.Default.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConsumerKey.Text) || String.IsNullOrEmpty(txtConsumerSecret.Text))
            {
                MessageBox.Show("You must specify a consumer key and consumer secret.");
            }

            oAuthTwitter oAuth = new oAuthTwitter();

            if (DialogResult.No ==
                MessageBox.Show("In order to use Coding the Tweet with Twitter, you must first " +
                "authorize it using your Twitter account. Would you like to do so now?",
                "Coding the Tweet", MessageBoxButtons.YesNo))
                return;

            // Store the consumer key/secret...
            Settings1.Default.consumerKey = txtConsumerKey.Text;
            Settings1.Default.consumerSecret = txtConsumerSecret.Text;

            // Each Twitter application has an authorization page where the user can specify
            // 'yes, allow this application' or 'no, deny this application'. The following
            // call obtains the URL to that page.
            string authLink = oAuth.AuthorizationLinkGet();

            //Authorization link will look something like this.
            //http://twitter.com/oauth/authorize?oauth_token=c8GZ6vCDdgKO4gTx0ZZXzvjZ76auuvlD1hxoLeiWc
            // User now has to visit 'authLink' URL and approve the application

            System.Diagnostics.Process.Start(authLink);
            if (DialogResult.OK ==
                MessageBox.Show("Coding the Tweet will now open the authorization page in an external browser." +
                                "Please click OK when you have approved the Coding the Tweet application for use.",
                                "Coding the Tweet", MessageBoxButtons.OKCancel))
            {
                // Now that the application's been authenticated, let's get the (permanent)
                // token and secret token that we'll use to authenticate from now on.
                oAuth.AccessTokenGet(oAuth.OAuthToken);

                // Store them...
                Settings1.Default.token = oAuth.Token;
                Settings1.Default.secretToken = oAuth.TokenSecret;
                Settings1.Default.Save();

                txtTweet.Enabled = btwTweet.Enabled = true;
                btnSave.Enabled = txtConsumerKey.Enabled = txtConsumerSecret.Enabled = false;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtConsumerKey.Text = Settings1.Default.consumerKey;
            txtConsumerSecret.Text = Settings1.Default.consumerSecret;

            bool hasConsumerKeyAndSecret = !String.IsNullOrEmpty(txtConsumerKey.Text) &&
                                           !String.IsNullOrEmpty(txtConsumerSecret.Text);

            txtTweet.Enabled = btwTweet.Enabled = 
                 !String.IsNullOrEmpty(Settings1.Default.token) && 
                 !String.IsNullOrEmpty(Settings1.Default.secretToken) &&
                 hasConsumerKeyAndSecret;

            txtConsumerKey.Enabled = txtConsumerSecret.Enabled = !hasConsumerKeyAndSecret;
            btnSave.Enabled = false;
        }

        private void txtConsumerKey_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (!String.IsNullOrEmpty(txtConsumerKey.Text) && !String.IsNullOrEmpty(txtConsumerSecret.Text));

        }

    }
}
