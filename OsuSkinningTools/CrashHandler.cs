using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace OsuSkinningTools
{
    public partial class CrashHandler : Form
    {
        public CrashHandler(Exception e)
        {
            InitializeComponent();
            textBoxError.Text = e.ToString();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to a URL.
            const string issueTitle = "UnhandledCrash";
            string issueBody = WebUtility.UrlEncode($"StackTrace\n```\n{textBoxError.Text}\n```");

            var pInfo = new ProcessStartInfo($"{Constants.GithubRepo}/issues/new?title={issueTitle}&body={issueBody}")
            {
                UseShellExecute = true,
            };
            Process.Start(pInfo);
        }
    }
}
