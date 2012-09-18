using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookComputing.XmlRpc;
using DojoTimer.Helpers;

namespace DojoTimer.Interfaces
{
    [XmlRpcUrl("http://jacquelineabreu.wordpress.com/xmlrpc.php")]
    public interface IWordpress
    {

        [XmlRpcMethod("wp.getAuthors")]
        Author[] GetAuthors(int blogid, string username, string password);

        [XmlRpcMethod("metaWeblog.getRecentPosts")]
        Post[] GetRecentPosts(int blogid, string username, string password, int numberOfPosts);

        [XmlRpcMethod("metaWeblog.newPost")]
        string newPost(int blogid, string authorId, string password, Post postTemplateInstance, bool publish);
    }
       
}
