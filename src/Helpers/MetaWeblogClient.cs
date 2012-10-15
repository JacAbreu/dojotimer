using System;
using System.Collections.Generic;
using System.Text;
using CookComputing.XmlRpc;
using System.Windows.Forms;

namespace DojoTimer.Helpers
{
    class MetaWeblogClient : XmlRpcClientProtocol
    {

        [XmlRpcMissingMapping(MappingAction.Ignore)]

        public struct Post
        {
            public DateTime dateCreated;
            public string description;
            public string title;
            public string[] categories;
            public string permalink;
            public string postid;
            public string userid;
            public string wp_slug;

        }

        public void newPost(string userid, string password, string description, string title, string url)
        {

            this.Url = url;

            Post post = new Post();

            post.categories = new string[1];
            post.categories[0] = "Resumo Dojo";
            post.dateCreated = DateTime.Now;
            post.userid = userid;
            post.description = description;
            post.title = title;

            newPost("0", userid, password, post, true);

        }

        [XmlRpcMethod("metaWeblog.newPost")]

        public string newPost(string blogid, string authorId, string password, MetaWeblogClient.Post postTemplateInstance, bool publish)
        {

            //return string postid
            string returnPostId = (string)this.Invoke("newPost", new Object[] { blogid, authorId, password, postTemplateInstance, publish });

            if (Convert.ToInt32(returnPostId) < 0)
            {
                throw new Exception("Não foi possível criar o post. Verifique usuário e senha");
            }

            return returnPostId;
        }
    }
        
}
