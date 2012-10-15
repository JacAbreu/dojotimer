using System;
using System.Collections.Generic;
using System.Text;
using CookComputing.XmlRpc;
using DojoTimer.Helpers;

namespace DojoTimer.Interfaces
{
    [XmlRpcUrl("http://jacquelineabreu.wordpress.com/xmlrpc.php")]
    public interface IWordpress : IXmlRpcProxy
    {

        [XmlRpcMethod("wp.getAuthors")]
        Author[] GetAuthors(int blogid, string username, string password);

        [XmlRpcMethod("metaWeblog.getRecentPosts")]
        Post[] GetRecentPosts(int blogid, string username, string password, int numberOfPosts);

        [XmlRpcMethod("metaWeblog.getCategories")]
        Category[] getCategories(int blogid, string username, string password);

        [XmlRpcMethod("wp.newCategory")]
        int newCategory(int blogid, string username, string password, Category category);

        [XmlRpcMethod("metaWeblog.newPost")]
        string newPost(string blogid, string authorId, string password, Post postTemplateInstance, bool publish);

    }
       
}
