using JsonToNetscape;
using System;
using System.Windows.Forms;

namespace JsonToNetscapeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // "Host\tDomainFlag\tPath\tSecureFlag\tExpiry\tName\tValue\tHttpOnlyFlag\tSessionFlag\r\n ..." for Firefox
        // "Host\tDomainFlag\tPath\tSecureFlag\tExpiry\tName\tValue\tHttpOnlyFlag\tSessionFlag\tSameSite\tPriority\r\n ..." for Chrome.</para>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            mNetscape.Text = CookieConv.ToNetscape(mJson.Text);
        }
    }
}
