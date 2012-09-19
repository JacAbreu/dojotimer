using System;
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

        public PostResumeDojoForm()
        {
            InitializeComponent();
        }

        private void sendResumeDojo_Click(object sender, EventArgs e)
        {

            Post postTemplateInstance = new Post();

            postTemplateInstance.WpPassord = this.password.Text;

            postTemplateInstance.WpAuthorId = this.user.Text;

            

            MetaWeblogClient metaWeblogClientForPost = new MetaWeblogClient();


            metaWeblogClientForPost.newPost(this.user.Text, this.password.Text,
                postTemplateInstance.contentPostTemplateToPublish(this.local.Text, this.subject.Text, this.source.Text, this.resume.Text, this.dojoFacts.Text), postTemplateInstance.Title);


            var wordpress = XmlRpcProxyGen.Create<IWordpress>();

            var author = wordpress.GetAuthors(0, postTemplateInstance.WpAuthorId, postTemplateInstance.WpPassord);

            //var returnCall = wordpress.newPost("0", postTemplateInstance.WpAuthorId, postTemplateInstance.WpPassord, postTemplateInstance, true);

        }

      
    }
}
