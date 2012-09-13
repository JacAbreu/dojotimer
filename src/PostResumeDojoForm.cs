using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DojoTimer.Helpers;


namespace DojoTimer
{
    public partial class PostResumeDojoForm : Form
    {
        public PostResumeDojoForm()
        {
            InitializeComponent();
        }


        private void sendResumeDojo_Click(object sender, EventArgs e)
        {
            PostTemplate postTemplateInstance = new PostTemplate(this.local.Text, this.subject.Text, this.source.Text, this.resume.Text, this.dojoFacts.Text);
        }

        private void dojoResume_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
