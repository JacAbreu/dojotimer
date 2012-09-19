using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookComputing.XmlRpc;

namespace DojoTimer.Helpers
{
    class MetaWeblogClient:XmlRpcClientProtocol
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

        public void newPost(string userid, string password, string description, string title)
        {
            this.Url = "http://jacquelineabreu.wordpress.com/xmlrpc.php";

            Post post = new Post();

            post.userid = userid;
            post.description = description;
            post.title = title;

            newPost("0", userid, password, post, true);

        }

        [XmlRpcMethod("metaWeblog.newPost")]

        public string newPost(string blogid, string authorId, string password, MetaWeblogClient.Post postTemplateInstance, bool publish)
        {

            return (string)this.Invoke("newPost", new Object[] {blogid, authorId, password, postTemplateInstance, publish });
        }
    }
}
