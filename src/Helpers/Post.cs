using System;
using System.Collections.Generic;
using System.Text;

namespace DojoTimer.Helpers
{
    public class Post
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public string PostType { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateCreatedGmt { get; set; }

        public List<string> Categories { get; set; }

        public List<string> MtKeywords { get; set; }

        public string MtExcerpt { get; set; }

        public string MtTextMore { get; set; }

        public string MtAllowComments { get; set; }

        public string MtAllowPings { get; set; }

        public string WpSlug { get; set; }

        public string WpPassord { get; set; }

        public string WpAuthorId { get; set; }

        public string WpAuthorDisplayName { get; set; }

        public string PostStatus { get; set; }

        public string WpPostFormat { get; set; }

        public bool sticky { get; set; }

        public Post()
        {
            Categories = new List<string>();

            MtKeywords = new List<string>();
        }

        public void contentPostTemplateToPublish(string local, string subject, string source, string resume, string dojoFacts)
        {
            StringBuilder postDojoResume = new StringBuilder();

            Title = local + " " + DateTime.Now;

            Categories.Add("resumo dojo");

            DateCreated = DateTime.Now;

            PostType = "post";

            postDojoResume.Append("Boa noite, pessoas. O dojo de hoje terminou agora :D");

            if (subject.Length > 0)
            {
                postDojoResume.Append("O tema do dojo de hoje foi");
                postDojoResume.Append(subject);
            }
            if (source.Length > 0)
            {
                postDojoResume.Append("O problema de hoje pode ser encontrado em ");
                postDojoResume.Append(source);
            }

            postDojoResume.Append(resume);

            if (dojoFacts.Length > 0)
            {
                postDojoResume.Append("E como facts, tivemos: ");
                postDojoResume.Append(dojoFacts);
            }

            Description = postDojoResume.ToString();



        }
    }
}
