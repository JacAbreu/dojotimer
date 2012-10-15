using System;
using System.Collections.Generic;
using System.Text;
using CookComputing.XmlRpc;
using System.Windows.Forms;

namespace DojoTimer.Helpers
{


        public class CustomFields
        {

            public string Id { get; set; }

            public string Key { get; set; }

            public string Value { get; set; }
        }

        public class Enclosure
        {

            public string Url { get; set; }

            public int Length { get; set; }

            public string Type { get; set; }
        }


        public class Post
        {

            public string Title { get; set; }

            public string Description { get; set; }

            public string PostType { get; set; }

            public DateTime dateCreated { get; set; }

            public DateTime date_created_gmt { get; set; }

            public List<string> categories { get; set; }

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

            public bool Sticky { get; set; }

            public List<CustomFields> CustomFields;

            public Enclosure Enclosure;
        
            public Post()
            {
                categories = new List<string>();

                MtKeywords = new List<string>();

                CustomFields = new List<CustomFields>();

                Enclosure = new Enclosure();

                dateCreated = DateTime.Now;

                date_created_gmt = DateTime.Now;

            }

            public string contentPostTemplateToPublish(string local, string subject, string source, string resume, string dojoFacts, Options options)
            {
                StringBuilder postDojoResume = new StringBuilder();

                Title = local + " " + DateTime.Now;
                
                PostType = "post";

                postDojoResume.Append("<p>Boa noite, pessoas. O dojo de hoje terminou agora :D.</p>");

                if (subject.Length > 0)
                {
                    postDojoResume.Append("<p>");
                    postDojoResume.Append("O tema do dojo de hoje foi: ");
                    postDojoResume.Append(subject);
                    postDojoResume.Append(". ");
                    postDojoResume.Append("</p>");
                }
                if (source.Length > 0)
                {
                    postDojoResume.Append("<p>");
                    postDojoResume.Append("O problema de hoje pode ser encontrado no/em:  ");
                    postDojoResume.Append(source);
                    postDojoResume.Append(". ");
                    postDojoResume.Append("</p>");
                }
                if (resume.Length > 0)
                {
                    postDojoResume.Append("<p>");
                    postDojoResume.Append(resume);
                    postDojoResume.Append(". ");
                    postDojoResume.Append("</p>");
                }


                List<string> participants = options.GetNameParticipantsDay(DateTime.Today);

                if (participants.Count > 0)
                {
                    postDojoResume.Append("Os participantes de hoje foram:");

                    postDojoResume.Append("<p><lu>");

                    foreach (string participant in participants)
                    {
                        postDojoResume.Append("<li>" + participant);
                    }

                    postDojoResume.Append("</lu>");

                    postDojoResume.Append("</lu></p>");
                }

                
                if (dojoFacts.Length > 0)
                {
                    postDojoResume.Append("<p>");
                    postDojoResume.Append("E como facts, tivemos: ");
                    postDojoResume.Append(dojoFacts);
                    postDojoResume.Append(". ");
                    postDojoResume.Append("</p>");
                }
                

                Description = postDojoResume.ToString();

                return Description;

            }
    }
}
