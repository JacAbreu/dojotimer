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
       private Options recentOptions;

        public PostResumeDojoForm(Options options)
        {
            InitializeComponent();
            formTitleBar1.BindHandleTo(this);

            this.recentOptions = options;
        }

        private void sendResumeDojo_Click(object sender, EventArgs e)
        {

            Post postTemplateInstance = new Post();

            postTemplateInstance.WpPassord = this.password.Text;

            postTemplateInstance.WpAuthorId = this.user.Text;

            MetaWeblogClient metaWeblogClientForPost = new MetaWeblogClient();

            var wordpress  = XmlRpcProxyGen.Create<IWordpress>();

            string urlBlog = "http://"+this.urlDestiny.Text+"/xmlrpc.php";

            try
            {
                metaWeblogClientForPost.newPost(this.user.Text, this.password.Text,
                    postTemplateInstance.contentPostTemplateToPublish(this.local.Text, this.subject.Text, this.source.Text, this.resume.Text, this.dojoFacts.Text, this.recentOptions), postTemplateInstance.Title, urlBlog);

                MessageBox.Show("Post criado com sucesso");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
