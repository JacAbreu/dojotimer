﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DojoTimer.Helpers;
using CookComputing.XmlRpc;
using DojoTimer.Interfaces;



namespace DojoTimer
{

    public partial class PostResumeDojoForm : Form
    {

        public Post postTemplateInstance;

        public PostResumeDojoForm()
        {
            InitializeComponent();
        }

        private void sendResumeDojo_Click(object sender, EventArgs e)
        {

            Post postTemplateInstance = new Post();

            postTemplateInstance.WpPassord = this.password.Text;

            postTemplateInstance.WpAuthorId = this.user.Text;

            postTemplateInstance.contentPostTemplateToPublish(this.local.Text, this.subject.Text, this.source.Text, this.resume.Text, this.dojoFacts.Text);

            var wordpress = XmlRpcProxyGen.Create<IWordpress>();

            var author = wordpress.GetAuthors(0, "jacabreu", "c0d1ngD0j0");

            var returnCall = wordpress.newPost(0, "jacabreu", "c0d1ngD0j0", postTemplateInstance, true);

        }

      
    }
}
