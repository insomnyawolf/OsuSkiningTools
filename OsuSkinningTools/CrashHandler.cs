using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            System.Diagnostics.Process.Start(Constants.GithubRepoIssues);
        }
    }
}
